#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include<string.h>
#include "Human.h"
#include "DataBase.h"

int main()
{
	const char data[] = "database.txt";
	HumanList list = { 0, NULL, NULL };
	Human human = {0,"","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" };
	int go_to_friend;
	int choose = 0;
	int choose_friend;
	int id = 0;
	int friend_id = 0;
	int group = 0;
	char group_param[150];
	//----------------------------------------------------------------------------------------------------------------
	fileInterface* file_interface = FileInit(data);
	LoadDataBase(file_interface, &list);
	
	ShowList(&list);
	int counter = list.size;

	while (choose!=7)
	{
		printf("1. Add\n2. Delete\n3. Create Chain\n4. Destroy Chain\n5. Show info\n6. Show groups\n7. Finish work\n");
		scanf("%d", &choose);
		switch (choose)
		{
		case 1:
			human.id = counter;
			counter++;
			printf("Enter name\n");
			scanf("%15s", human.name);
			printf("Enter surname\n");
			scanf("%30s", human.surname);
			printf("Enter mobile phone\n");
			scanf("%14s", human.mobile_phone);
			printf("Enter mail\n");
			scanf("%150s", human.mail);
			printf("Enter city\n");
			scanf("%30s", human.city);
			printf("Enter edu\n");
			scanf("%50s", human.education);
			printf("Enter work place\n");
			scanf("%30s", human.place_of_work);
			printf("Enter position\n");
			scanf("%30s", human.position);
			printf("Enter interests\n");
			scanf("%60s", human.interests);
			PushBackHuman(&list, &human);
			fflush(stdin);
			break;
		case 2:
			printf("Enter id\n");
			scanf("%d", &id);
			DeleteHuman(&list, id);
			break;
		case 3:
			printf("Enter id\n");
			scanf("%d", &id);
			printf("\nEnter friend's id\n");
			scanf("%d", &friend_id);
			CreateChain(&list, id, friend_id);
			break;
		case 4:
			printf("Enter id\n");
			scanf("%d", &id);
			printf("\nEnter friend's id\n");
			scanf("%d", &friend_id);
			DestroyChain(&list, id, friend_id);
			break;
		case 5:
			go_to_friend = 1;
			printf("Enter id\n");
			scanf("%d", &id);
			system("cls");
			ShowInfo(&list, id);
			while (go_to_friend==1)
			{
				printf("\n1. Get info \n2. Go back\n");
				scanf("%d", &choose_friend);
				if (choose_friend == 1)
				{
					printf("Enter id\n");
					scanf("%d", &id);
					system("cls");
					ShowInfo(&list, id);
				}
				else
					go_to_friend = 0;
			}
			break;
		case 6:
			go_to_friend = 1;
			system("cls");
			printf("Choose the category\n1. City\n2. Education\n3. Work\n4. Interests\n");
			scanf("%d", &group);
			printf("\nEnter the parametr\n");
			scanf("\n");
			fgets(group_param,150, stdin);
			group_param[strlen(group_param) - 1] = '\0';
			system("cls");
			GroupPeople(&list, group_param, group); 
			while (go_to_friend == 1)
			{
				printf("\n1. Get info \n2. Go back\n");
				scanf("%d", &choose_friend);
				if (choose_friend == 1)
				{
					printf("Enter id\n");
					scanf("%d", &id);
					system("cls");
					ShowInfo(&list, id);
				}
				else
					go_to_friend = 0;
			}
			break;
		case 7:
			SaveDataBase(file_interface, &list);
			return 0;
		}
		system("cls");
		ShowList(&list);
	}
}