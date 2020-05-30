#pragma once

#ifndef HUMAN_H
#define HUMAN_H

#include <stdio.h>
#include <stdlib.h>
#include "Friend.h"

typedef struct _human
{
	int id;
	char surname[30];
	char name[15];
	char mobile_phone[15];
	char mail[150];
	char city[30];
	char education[50];
	char place_of_work[30];
	char position[30];
	char interests[60];
	FriendList friends;
}Human;
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

typedef struct _node_human 
{
	struct _human human;
	struct _node_human* next;
	struct _node_human* prev;
}NodeHuman;

typedef struct _human_list
{
	int size;
	struct _node_human* head;
	struct _node_human* tail;
}HumanList;

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void PushBackHuman(HumanList* list, Human* human)
{
	if (list->head == NULL)
	{
		list->head = (NodeHuman*) malloc(sizeof(NodeHuman));
		list->head->human = *human;
		list->head->prev = NULL;
		list->head->next = NULL;
		list->tail = list->head;
	}
	else
	{
		list->tail->next = (NodeHuman*) malloc(sizeof(NodeHuman));
		list->tail->next->prev = list->tail;
		list->tail->next->next = NULL;
		list->tail = list->tail->next;
		list->tail->human = *human;
	}
	list->size++;
}

void PushFrontHuman(HumanList* list, Human* human)
{
	NodeHuman* current = (NodeHuman*) malloc(sizeof(NodeHuman));
	current->next = list->head;
	current->prev = NULL;
	current->human = *human;
	list->head = current;
	if (list->size == 0)
		list->tail = list->head;
	list->size++;
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void PopBackHuman(HumanList* list)
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
	NodeHuman* current = list->tail->prev;
	free(list->tail);
	list->tail = current;
	list->tail->next = NULL;
	list->size--;
}

void PopFrontHuman(HumanList* list)
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

void InsertHuman(HumanList* list, Human* human, int index)
{
	if (index == 0)
		PushFrontHuman(list, human);
	else if (index == list->size)
		PushBackHuman(list, human);
	else
	{
		if (index < list->size / 2)
		{
			NodeHuman* current = list->head;
			for (int i = 0; i < index; i++)
			{
				current = current->next;
			}
			NodeHuman* temp = (NodeHuman*)malloc(sizeof(NodeHuman));
			temp->human = *human;
			temp->next = current->next;
			temp->prev = current;
			current->next = temp;
			temp->next->prev = temp;
		}
		else
		{
			NodeHuman* current = list->tail;
			for (int i = list->size-1; i >= index; i--)
			{
				current = current->prev;
			}
			NodeHuman* temp = (NodeHuman*)malloc(sizeof(NodeHuman));
			temp->human = *human;
			temp->prev = current->prev;
			temp->prev->next = temp;
			current->prev = temp;
			temp->next = current;
		}
		list->size++;
	}
}

void DeleteHuman(HumanList* list, int id)
{
	if (list->size == 0)
		return;
	if (list->head->human.id == id)
		PopFrontHuman(list);
	else if (list->tail->human.id == id)
		PopBackHuman(list);
	else
	{
		NodeHuman* current = list->head;
		while (current->human.id != id)
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

void FreeHumanList(HumanList* list)
{
	while (list->size)
	{
		PopFrontHuman(list);
	}
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

int Check(FriendList* list, int id)
{
	NodeFriend* current = list->head;
	while (current != NULL)
	{
		if (current->id == id)
			return 0;
		current = current->next;
	}
	return 1;
}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void CreateChain(HumanList*list, int id, int friend_id)
{
	if (id == friend_id)
	{
		printf("Friend not founded");
		return;
	}
	NodeHuman* current = list->head;
	while (current->human.id!=id)
	{
		current = current->next;
		if (current == NULL)
		{
			printf("Friend not founded");
			return;
		}
	}
	if (Check(&current->human.friends, friend_id))
		PushBackFriend(&current->human.friends, friend_id);
	else
		return;

	current = list->head;
	while (current->human.id != friend_id)
	{
		current = current->next;
		if (current == NULL)
			return;
	}
	PushBackFriend(&current->human.friends, id);
}

void DestroyChain(HumanList* list, int id, int friend_id)
{
	NodeHuman* current = list->head;
	while (current->human.id != id)
	{
		current = current->next;
		if (current == NULL)
			return;
	}
	DeleteFriend(&current->human.friends, friend_id);

	current = list->head;
	while (current->human.id != friend_id)
	{
		current = current->next;
		if (current == NULL)
			return;
	}
	DeleteFriend(&current->human.friends, id);
}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

void Sort(FriendList* friend_list)
{
	int temp;
	NodeFriend* current_friend = friend_list->head;
	while (current_friend->next!=NULL)
	{
		NodeFriend* start_friend = current_friend;
		while (start_friend->next->next!=NULL)
		{
			if (start_friend->id > start_friend->next->id)
			{
				temp = start_friend->id;
				start_friend->id = start_friend->next->id;
				start_friend->next->id = temp;
			}
			start_friend = start_friend->next;
		}
		current_friend = current_friend->next;
	}
}

//---------------------------------------------------------------------------------------------------
void ShowFriends(HumanList* list, FriendList* friend_list)
{
	NodeHuman* current_human = list->head;
	NodeFriend* current_friend = friend_list->head;
	Sort(friend_list);
	if (current_friend == NULL)
		return;
	while (current_human != NULL)
	{
		if (current_human->human.id == current_friend->id)
		{
			printf("--------------------------------------\nID: %d\n", current_human->human.id);
			printf("Name: %s\n", current_human->human.name);
			printf("Surname: %s\n\n", current_human->human.surname);
			current_friend = current_friend->next;
			if (current_friend == NULL)
			{
				printf("---------------end of friends------------------------------\n");
				return;
			}
		}
		current_human = current_human->next;
	}
}

void ShowList(HumanList* list)
{
	NodeHuman* current = list->head;
	while (current != NULL)
	{
		printf("ID: %d\n", current->human.id);
		printf("Name: %s\n", current->human.name);
		printf("Surname: %s\n\n", current->human.surname);
		current = current->next;
	}
}
//---------------------------------------------------------------------------------------------------
void ShowInfo(HumanList* list, int id)
{
	NodeHuman* current = list->head;
	while (current->human.id != id)
	{
		current = current->next;
		if (current == NULL)
		{
			printf("Not finded");
			return;
		}
	}
	printf("Name: %s\n", current->human.name);
	printf("Surname: %s\n", current->human.surname);
	printf("Mobile: %s\n", current->human.mobile_phone);
	printf("Mail: %s\n", current->human.mail);
	printf("City: %s\n", current->human.city);
	printf("Education: %s\n", current->human.education);
	printf("Work: %s\n", current->human.place_of_work);
	printf("Position: %s\n", current->human.position);
	printf("Interest: %s\n", current->human.interests);
	ShowFriends(list, &current->human.friends);
}
//---------------------------------------------------------------------------------------------------
void GroupPeople(HumanList* list, char group_param[], int group)
{
	NodeHuman* current = list->head;
	if (group == 1)
	{
		printf("City: %s", group_param);
		while (current != NULL)
		{
			if (strcmp(current->human.city, group_param) == 0)
			{
				printf("\n");
				printf("ID: %d\n", current->human.id);
				printf("Name: %s\n", current->human.name);
				printf("Surname: %s\n", current->human.surname);
				printf("Mobile: %s\n", current->human.mobile_phone);
				printf("Mail: %s\n", current->human.mail);
				printf("City: %s\n", current->human.city);
				printf("Education: %s\n", current->human.education);
				printf("Work: %s\n", current->human.place_of_work);
				printf("Position: %s\n", current->human.position);
				printf("Interest: %s\n", current->human.interests);
			}
			current = current->next;
		}
		return;
	}
	if (group == 2)
	{
		while (current != NULL)
		{
			printf("Education: %s", group_param);
			while (current != NULL)
			{
				if (strcmp(current->human.education, group_param) == 0)
				{
					printf("\n");
					printf("ID: %d\n", current->human.id);
					printf("Name: %s\n", current->human.name);
					printf("Surname: %s\n", current->human.surname);
					printf("Mobile: %s\n", current->human.mobile_phone);
					printf("Mail: %s\n", current->human.mail);
					printf("City: %s\n", current->human.city);
					printf("Education: %s\n", current->human.education);
					printf("Work: %s\n", current->human.place_of_work);
					printf("Position: %s\n", current->human.position);
					printf("Interest: %s\n", current->human.interests);
				}
				current = current->next;
			}
			return;
		}
		return;
	}
	if (group == 3)
	{
		while (current != NULL)
		{
			printf("Work: %s", group_param);
			while (current != NULL)
			{
				if (strcmp(current->human.place_of_work, group_param) == 0)
				{
					printf("\n");
					printf("ID: %d\n", current->human.id);
					printf("Name: %s\n", current->human.name);
					printf("Surname: %s\n", current->human.surname);
					printf("Mobile: %s\n", current->human.mobile_phone);
					printf("Mail: %s\n", current->human.mail);
					printf("City: %s\n", current->human.city);
					printf("Education: %s\n", current->human.education);
					printf("Work: %s\n", current->human.place_of_work);
					printf("Position: %s\n", current->human.position);
					printf("Interest: %s\n", current->human.interests);
				}
				current = current->next;
			}
			return;
		}
		return;
	}
	if (group == 4)
	{
		while (current != NULL)
		{
			printf("Interest: %s", group_param);
			while (current != NULL)
			{
				if (strcmp(current->human.interests, group_param) == 0);
				{
					printf("\n");
					printf("ID: %d\n", current->human.id);
					printf("Name: %s\n", current->human.name);
					printf("Surname: %s\n", current->human.surname);
					printf("Mobile: %s\n", current->human.mobile_phone);
					printf("Mail: %s\n", current->human.mail);
					printf("City: %s\n", current->human.city);
					printf("Education: %s\n", current->human.education);
					printf("Work: %s\n", current->human.place_of_work);
					printf("Position: %s\n", current->human.position);
					printf("Interest: %s\n", current->human.interests);
				}
				current = current->next;
			}
			return;
		}
		return;
	}
}
//---------------------------------------------------------------------------------------------------

#endif // !HUMAN_H