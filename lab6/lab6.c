#include <stdio.h>
#include <stdlib.h>
#include<math.h>

//----------------------------------------------Двунаправленный список-------------------------------------------------------------------------------------------------------------
struct ListNode
{
    int data;
    struct ListNode* prev;
    struct ListNode* next;
};

struct List
{
    struct ListNode* head;
    struct ListNode* tail;
    int size;
};

void PushBackToList(struct List* list, int num)
{
    if (list->head == NULL)
    {
        list->head = (struct ListNode*) malloc(sizeof(struct ListNode));
        list->head->data = num;
        list->head->prev = NULL;
        list->head->next = NULL;
        list->tail = list->head;
    }
    else
    {
        list->tail->next = (struct ListNode*) malloc(sizeof(struct ListNode));
        list->tail->next->prev = list->tail;
        list->tail->next->next = NULL;
        list->tail = list->tail->next;
        list->tail->data = num;
    }
    list->size++;
}

void PushFrontToList(struct List* list, int num)
{
    struct ListNode* current = (struct ListNode*) malloc(sizeof(struct ListNode));
    current->next = list->head;
    current->prev = NULL;
    list->head = current;
    if (list->size == 0)
        list->tail = list->head;
    list->size++;
}

void PopBackList(struct List* list)
{
    if (list->size == 0)
        return;
    if (list->size == 1)
    {
        free(list->head);
        list->head = NULL;
        list->tail = NULL;
        list->size--;
        return;
    }
    struct ListNode* current = list->tail->prev;
    free(list->tail);
    list->tail = current;
    list->tail->next = NULL;
    list->size--;
}

void PopFrontList(struct List* list)
{
    if (list->size == 0)
        return;
    list->head = list->head->next;
    free(list->head->prev);
    list->head->prev = NULL;
    list->size--;
}

int GetListData(struct List* list, int i)
{
    int counter;
    if (i < list->size/2)
    {
        counter = 0;
        struct ListNode* current = list->head;
        while (current!=NULL)
        {
            if (counter == i)
            {
                return current->data;
            }
            counter++;
            current = current->next;
        }
    }
    else
    {
        counter = list->size - 1;
        struct ListNode* current = list->tail;
        while (current != NULL)
        {
            if (counter == i)
            {
                return current->data;
            }
            counter--;
            current = current->prev;
        }
    }
}
//-------------------------------------------------------------------------------Конец двунаправленного списка--------------------------------------------------------------------

//-------------------------------------------------------------------------------Бинарное дерево--------------------------------------------------------------------------------------

struct Tree // структура для представления узлов дерева
{
    int key;
    unsigned char height;
    struct Tree* left;
    struct Tree* right;
};

unsigned char Height(struct Tree* tree)
{
    return tree ? tree->height : 0;
}

int BalanceFactor(struct Tree* tree)
{
    return Height(tree->right) - Height(tree->left);
}

void Fix(struct Tree* tree)
{
    unsigned char hl = Height(tree->left);
    unsigned char hr = Height(tree->right);
    tree->height = (hl > hr ? hl : hr) + 1;
}

struct Tree* RotateRight(struct Tree* tree) 
{
    struct Tree* temp = tree->left;
    tree->left = temp->right;
    temp->right = tree;
    Fix(tree);
    Fix(temp);
    return temp;
}

struct Tree* RotateLeft(struct Tree* tree) 
{
    struct Tree* temp = tree->right;
    tree->right = temp->left;
    temp->left = tree;
    Fix(tree);
    Fix(temp);
    return temp;
}

struct Tree* Balance(struct Tree* tree)
{
    Fix(tree);
    if (BalanceFactor(tree) == 2)
    {
        if (BalanceFactor(tree->right) < 0)
            tree->right = RotateRight(tree->right);
        return RotateLeft(tree);
    }
    if (BalanceFactor(tree) == -2)
    {
        if (BalanceFactor(tree->left) > 0)
            tree->left = RotateLeft(tree->left);
        return RotateRight(tree);
    }
    return tree; 
}

struct Tree* Insert(struct Tree* tree, int num) 
{
    if (!tree)
    {
        struct Tree* temp = (struct Tree*) malloc(sizeof(struct Tree));
        temp->key = num;
        temp->left = NULL;
        temp->right = NULL;
        temp->height = 1;
        return temp;
    }
    if (num < tree->key)
        tree->left = Insert(tree->left, num);
    else
        tree->right = Insert(tree->right, num);
    return Balance(tree);
}

struct Tree* FindMin(struct Tree* tree) 
{
    return tree->left ? FindMin(tree->left) : tree;
}

struct Tree* RemoveMin(struct Tree* tree)
{
    if (tree->left == 0)
        return tree->right;
    tree->left = RemoveMin(tree->left);
    return Balance(tree);
}

struct Tree* Remove(struct Tree* tree, int num)
{
    if (!tree) return 0;
    if (num < tree->key)
        tree->left = Remove(tree->left, num);
    else if (num > tree->key)
        tree->right = Remove(tree->right, num);
    else
    {
        struct Tree* q = tree->left;
        struct Tree* r = tree->right;
        free(tree);
        if (!r) return q;
        struct Tree* min = FindMin(r);
        min->right = RemoveMin(r);
        min->left = q;
        return Balance(min);
    }
    return Balance(tree);
}

void print_Tree(struct Tree* p, int level)
{
    if (p)
    {
        print_Tree(p->right, level + 1);
        for (int i = 0; i < level; i++) printf("          ");
        printf("%d\n\n", p->key);
        print_Tree(p->left, level + 1);
    }
}
//-------------------------------------------------------------------------------Конец бинарного дерева-----------------------------------------------------------------------------

//-------------------------------------------------------------------------------Стек----------------------------------------------------------------------------------------------------
struct StackNode
{
    int data;
    struct StackNode* next;
};

struct Stack
{
    struct StackNode* head;
    int size;
};

void Push(struct Stack* stack, int num)
{
    struct StackNode* current = (struct StackNode*) malloc(sizeof(struct StackNode));
    current->next = stack->head;
    stack->head = current;
    stack->head->data = num;
    stack->size++;
}

void Pop(struct Stack* stack)
{
    if (stack->size == 0)
        return;
    struct StackNode* current = stack->head;
    stack->head = stack->head->next;
    free(current);
    stack->size--;
}

int GetStackData(struct Stack* stack, int num)
{
    int counter = 0;
    struct StackNode* current = stack->head;
    while (current != NULL)
    {
        if (counter == num)
        {
            return current->data;
        }
        counter++;
        current = current->next;
    }
}
void FillTheStack(struct Tree* p, struct Stack* one, struct Stack* two)
{
    if (p)
    {
        if (abs(p->key) % 2)
        {
            Push(two, p->key);
        }
        else
        {
            Push(one, p->key);
        }
    }
    else
    {
        return;
    }
    FillTheStack(p->left, one, two);
    FillTheStack(p->right, one, two);
}
//-------------------------------------------------------------------------------Конец стека-------------------------------------------------------------------------------------------
int main()
{
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    struct List list = { NULL, NULL, 0 };
    struct Tree* tree = NULL;
    struct Stack odd = { NULL, 0 };
    struct Stack even = {NULL, 0};
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    PushBackToList(&list, 4); 
    PushBackToList(&list, 123);
    PushBackToList(&list, -1);
    PushBackToList(&list, -123);
    PushBackToList(&list, 54);
    PushBackToList(&list, 9);
    PushBackToList(&list, 67);
    PushBackToList(&list, 2);
    PushBackToList(&list, 0);
    for (int i = 0; i < list.size; i++)
    {
        printf("%d ", GetListData(&list, i));
    }
    printf("\n\n");
    system("pause");
    system("cls");
    for (int i = 0; i < list.size; i++)
    {
        tree = Insert(tree, GetListData(&list, i));
    }
    print_Tree(tree, 0);
    printf("\n\n");
    system("pause");
    system("cls");
    FillTheStack(tree, &even, &odd);
    printf("Odd stack\n");
    for (int i = 0; i < odd.size; i++)
    {
        printf("%d ", GetStackData(&odd, i));
    }
    printf("\n\nEven stack\n");
    for (int i = 0; i < even.size; i++)
    {
        printf("%d ", GetStackData(&even, i));
    }
    printf("\n\n");
    system("pause");
    system("cls");
    return 0;
}