#pragma once
#ifndef DATABASE_H
#define DATABASE_H

#include<stdio.h>
#include<stdlib.h>
#include"Human.h"


typedef int cursor;

typedef struct _file_interface
{
	FILE* file;
	const char* _PATH;
	cursor pos;
}fileInterface;
//-------------------------------------------------------------------------------------------------------
fileInterface* FileInit(const char* _PATH)
{
	fileInterface* _file = (fileInterface*)malloc(sizeof(fileInterface));
	if (_file == NULL)
		return NULL;
	_file->_PATH = _PATH;
	return _file;
}

void FileDestroy(fileInterface* file)
{
	free((void*)file->_PATH);
}
//-------------------------------------------------------------------------------------------------------

int LoadDataBase(fileInterface* _file, HumanList* list)
{
	Human tempHuman = { 0,"","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" };
	int i, j, size, friends_size, friend_id;
	FILE* file = _file->file;
	file = fopen(_file->_PATH, "r");
	if (!file)
	{
		return 0;
	}
	fscanf(file, "%d", &size);
	for (i = 0; i < size; ++i)
	{
		fscanf(file, "%d%s%s%s%s%s%s%s%s%s", &tempHuman.id, tempHuman.name, tempHuman.surname, tempHuman.mobile_phone, tempHuman.mail, tempHuman.city, tempHuman.education, tempHuman.place_of_work, tempHuman.position, tempHuman.interests);
		PushBackHuman(list, &tempHuman);
		fscanf(file, "%d", &friends_size);
		for (j = 0; j < friends_size; ++j)
		{
			fscanf(file, "%d", &friend_id);
			PushBackFriend(&list->tail->human.friends, friend_id);
		}
	}
	fclose(file);
	return 1;
}

int SaveDataBase(fileInterface* _file, HumanList* list)
{
	NodeHuman* current = list->head;
	int i, j, size=list->size, friends_size;
	FILE* file = _file->file;
	file = fopen(_file->_PATH, "w");
	if (!file)
	{
		return 0;
	}
	fprintf(file, "%d\n", size);
	for ( i = 0; i < size; ++i)
	{
		fprintf(file, "%d %s %s %s %s %s %s %s %s %s\n", current->human.id, current->human.name, current->human.surname, current->human.mobile_phone, current->human.mail, current->human.city, current->human.education, current->human.place_of_work, current->human.position, current->human.interests);
		NodeFriend* current_friend = current->human.friends.head;
		friends_size = current->human.friends.size;
		fprintf(file, "%d\n", friends_size);
		for (j = 0; j < friends_size; ++j)
		{
			fprintf(file, "%d\n", current_friend->id);
			current_friend = current_friend->next;
		}
		current = current->next;
	}
	fclose(file);
	return 1;
}
#endif // !DATABASE_H

