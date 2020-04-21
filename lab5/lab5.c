#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<Windows.h>
struct Recruit
{
	int num;
	int first;
	int second;
	int third;
	int fourth;
	int fifth;
};

struct Node
{
	struct Recruit recruit;
	struct Node* next;
};

struct Queue
{
	struct Node* head;
	struct Node* tail;
	int size;
};
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
void Push(struct Queue* queue, struct Recruit* recruit, int num)
{
	if (queue->head == NULL)
	{	
		queue->head = (struct Node*) malloc(sizeof(struct Node));
		queue->head->recruit.num = num;
		queue->head->next = NULL;
		queue->head->recruit.first = recruit->first;
		queue->head->recruit.second = recruit->second;
		queue->head->recruit.third = recruit->third;
		queue->head->recruit.fourth = recruit->fourth;
		queue->head->recruit.fifth = recruit->fifth;
		queue->tail = queue->head;
	}
	else
	{
		queue->tail->next = (struct Node*) malloc(sizeof(struct Node));
		queue->tail->next->recruit.num = num;
		queue->tail->next->next = NULL;
		queue->tail = queue->tail->next;
		queue->tail->recruit.first = recruit->first;
		queue->tail->recruit.second = recruit->second;
		queue->tail->recruit.third = recruit->third;
		queue->tail->recruit.fourth = recruit->fourth;
		queue->tail->recruit.fifth = recruit->fifth;
	}
	queue->size++;
}

void Pop(struct Queue* queue)
{
	if (queue->size == 0)
		return;
	if (queue->size == 1)
	{
		free(queue->head);
		queue->head = NULL;
		queue->tail = NULL;
		queue->size--;
		return;
	}
	struct Node* current = queue->head->next;
	free(queue->head);
	queue->head = current;
	queue->size--;
}

void Show(struct Queue* queue)
{
	struct Node* current = queue->head;
	while (current != NULL)
	{
		printf("%d ", current->recruit.num);
		current = current->next;
	}
}
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

int FindMin(struct Recruit* recruit, int a, int b, int c, int d, int e)
{
	int min_queue;
	int min;
	if (recruit->first)
	{
		if (recruit->second)
		{
			if (recruit->third)
			{
				if (recruit->fourth)
				{
					min = e;
					min_queue = 5;
				}
				else
				{
					min = d;
					min_queue = 4;
				}
			}
			else
			{
				min = c;
				min_queue = 3;
			}
		}
		else
		{
			min = b;
			min_queue = 2;
		}
	}
	else
	{
		min = a;
		min_queue = 1;
	}

	if (!recruit->first)
	{
		if (a < min)
		{
			min = a;
			min_queue = 1;
		}
	}
	if (!recruit->second)
	{
		if (b < min)
		{
			min = b;
			min_queue = 2;
		}
	}
	if (!recruit->third)
	{
		if (c < min)
		{
			min = c;
			min_queue = 3;
		}
	}
	if (!recruit->fourth)
	{
		if (d < min)
		{
			min = d;
			min_queue = 4;
		}
	}
	if (!recruit->fifth)
	{
		if (e < min)
		{
			min_queue = 5;
		}
	}
	return min_queue;
}

int Finish(struct Recruit* recruit)
{
	if (recruit->first && recruit->second && recruit->third && recruit->fourth && recruit->fifth)
		return 1;
	else
		return 0;
}
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
void InsertInMin(struct Queue* first, struct Queue* second, struct Queue* third, struct Queue* fourth, struct Queue* fifth, int i, struct Recruit* recruit, int num)
{
	switch (i)
	{
	case 1:
		Push(first, recruit, num);
		break;
	case 2:
		Push(second, recruit, num);
		break;
	case 3:
		Push(third, recruit, num);
		break;
	case 4:
		Push(fourth, recruit, num);
		break;
	case 5:
		Push(fifth, recruit, num);
		break;
	}
}

void Delete(struct Queue* first, struct Queue* second, struct Queue* third, struct Queue* fourth, struct Queue* fifth, int num)
{
	switch (num)
	{
	case 1:
		Pop(first);
		break;
	case 2:
		Pop(second);
		break;
	case 3:
		Pop(third);
		break;
	case 4:
		Pop(fourth);
		break;
	case 5:
		Pop(fifth);
		break;
	}
}

struct Recruit* Get(struct Queue* first, struct Queue* second, struct Queue* third, struct Queue* fourth, struct Queue* fifth, int i)
{	
	switch (i)
	{
	case 1:
		return &first->head->recruit;
		break;
	case 2:
		return &second->head->recruit;
		break;
	case 3:
		return &third->head->recruit;
		break;
	case 4:
		return &fourth->head->recruit;
		break;
	case 5:
		return &fifth->head->recruit;
		break;
	}
}

void SetDoctor(struct Recruit* recruit, int num)
{
	switch (num)
	{
	case 1:
		recruit->first = 1;
		break;
	case 2:
		recruit->second = 1;
		break;
	case 3:
		recruit->third = 1;
		break;
	case 4:
		recruit->fourth = 1;
		break;
	case 5:
		recruit->fifth = 1;
		break;
	}
}

int FinishWork(struct Queue* first, struct Queue* second, struct Queue* third, struct Queue* fourth, struct Queue* fifth)
{
	if (!first->size && !second->size && !third->size && !fourth->size && !fifth->size)
		return 1;
	return 0;
}
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

int main()
{
	//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	struct Queue first = { NULL, NULL, 0 };
	struct Queue second = { NULL, NULL, 0 };
	struct Queue third = { NULL, NULL, 0 };
	struct Queue fourth = { NULL, NULL, 0 };
	struct Queue fifth = { NULL, NULL, 0 };
	struct Recruit recruit = { 0,0,0,0,0,0 };
	struct Recruit *temp;
	int num;
	//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	for (int i = 1;; i++)
	{
		printf("Surgeon: ");
		Show(&first);
		printf("\n\nOphthalmologist: ");
		Show(&second);
		printf("\n\nOtolaryngologist: ");
		Show(&third);
		printf("\n\nPsychiatrist: ");
		Show(&fourth);
		printf("\n\nTherapist: ");
		Show(&fifth);
		printf("\n\n");
		switch (rand() % 3 + 1)
		{
		case 1:
			InsertInMin(&first, &second, &third, &fourth, &fifth, FindMin(&recruit, first.size, second.size, third.size, fourth.size, fifth.size), &recruit, i);
			break;
		default:
			num = rand() % 5 + 1;
			temp = Get(&first, &second, &third, &fourth, &fifth, num);
			if (temp != NULL)
			{
				SetDoctor(temp, num);
				if (!Finish(temp))
				{
					InsertInMin(&first, &second, &third, &fourth, &fifth, FindMin(temp, first.size, second.size, third.size, fourth.size, fifth.size), temp, temp->num);
				}
				else
				{
					printf("\n\n\nRecruit number %d finished inspection for %d minutes\n\n", temp->num, (i - temp->num));
					system("pause");
				}
				Delete(&first, &second, &third, &fourth, &fifth, num);
			}
			break;
		}
		Sleep(rand() % 300 + 100);
		system("cls");
		if (i == 200)
		{
			while (!FinishWork(&first, &second, &third, &fourth, &fifth))
			{
				printf("Surgeon: ");
				Show(&first);
				printf("\n\nOphthalmologist: ");
				Show(&second);
				printf("\n\nOtolaryngologist: ");
				Show(&third);
				printf("\n\nPsychiatrist: ");
				Show(&fourth);
				printf("\n\nTherapist: ");
				Show(&fifth);
				printf("\n\n");
				num = rand() % 5 + 1;
				temp = Get(&first, &second, &third, &fourth, &fifth, num);
				if (temp != NULL)
				{
					SetDoctor(temp, num);
					if (!Finish(temp))
					{
						InsertInMin(&first, &second, &third, &fourth, &fifth, FindMin(temp, first.size, second.size, third.size, fourth.size, fifth.size), temp, temp->num);
					}
					else
					{
						printf("\n\n\nRecruit number %d finished inspection for %d minutes\n\n", temp->num, (i - temp->num));
						system("pause");
					}
					Delete(&first, &second, &third, &fourth, &fifth, num);
				}
				i++;
				Sleep(rand() % 300 + 100);
				system("cls");
			}
			break;
		}
	}
	printf("The working day is over\n\n");
	system("pause");
	return 0;
}