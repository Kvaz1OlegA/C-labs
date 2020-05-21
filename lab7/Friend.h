#pragma once

#ifndef FRIEND_H
#define FRIEND_H

#include <stdio.h>
#include <stdlib.h>

typedef struct _node_friend
{
	int id;
	struct _node_friend* next;
	struct _node_friend* prev;
}NodeFriend;

typedef struct _friend_list
{
	int size;
	struct _node_friend* head;
	struct _node_friend* tail;
}FriendList;

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void PushBackFriend(FriendList* list, int friend_id)
{
	if (list->head == NULL)
	{
		list->head = (NodeFriend*)malloc(sizeof(NodeFriend));
		list->head->id = friend_id;
		list->head->prev = NULL;
		list->head->next = NULL;
		list->tail = list->head;
	}
	else
	{
		list->tail->next = (NodeFriend*)malloc(sizeof(NodeFriend));
		list->tail->next->prev = list->tail;
		list->tail->next->next = NULL;
		list->tail = list->tail->next;
		list->tail->id = friend_id;
	}
	list->size++;
}

void PushFrontFriend(FriendList* list, int friend_id)
{
	NodeFriend* current = (NodeFriend*)malloc(sizeof(NodeFriend));
	current->next = list->head;
	current->prev = NULL;
	current->id = friend_id;
	list->head = current;
	if (list->size == 0)
		list->tail = list->head;
	list->size++;
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void PopBackFriend(FriendList* list)
{
	if (list->size == 0)
		return;
	if (list->size == 1)
	{
		free(list->head);
		list->head = list->tail = NULL;
		list->size--;
		return;
	}
	NodeFriend* current = list->tail->prev;
	free(list->tail);
	list->tail = current;
	list->tail->next = NULL;
	list->size--;
}

void PopFrontFriend(FriendList* list)
{
	if (list->size == 0)
		return; 
	if (list->size == 1)
	{
		free(list->head);
		list->head = list->tail = NULL;
		list->size--;
		return;
	}
	list->head = list->head->next;
	free(list->head->prev);
	list->head->prev = NULL;
	list->size--;
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void InsertFriend(FriendList* list, int friend_id, int index)
{
	if (index == 0)
		PushFrontFriend(list, friend_id);
	else if (index == list->size)
		PushBackFriend(list, friend_id);
	else
	{
		if (index < list->size / 2)
		{
			NodeFriend* current = list->head;
			for (int i = 0; i < index; i++)
			{
				current = current->next;
			}
			NodeFriend* temp = (NodeFriend*)malloc(sizeof(NodeFriend));
			temp->id = friend_id;
			temp->next = current->next;
			temp->prev = current;
			current->next = temp;
			temp->next->prev = temp;
		}
		else
		{
			NodeFriend* current = list->tail;
			for (int i = list->size - 1; i >= index; i--)
			{
				current = current->prev;
			}
			NodeFriend* temp = (NodeFriend*)malloc(sizeof(NodeFriend));
			temp->id = friend_id;
			temp->prev = current->prev;
			temp->prev->next = temp;
			current->prev = temp;
			temp->next = current;
		}
		list->size++;
	}
}

void DeleteFriend(FriendList* list, int friend_id)
{
	if (list->size == 0)
		return;
	if (list->head->id == friend_id)
		PopFrontFriend(list);
	else if (list->tail->id == friend_id)
		PopBackFriend(list);
	else
	{
		NodeFriend* current = list->head;
		while (current->id != friend_id)
		{
			current = current->next;
			if (current == NULL)
				return;
		}
		current->prev->next = current->next;
		current->next->prev = current->prev;
		free(current);
		list->size--;
	}
}

void FreeFriendList(FriendList* list)
{
	while (list->size)
	{
		PopFrontFriend(list);
	}
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



#endif // !FRIEND_H
