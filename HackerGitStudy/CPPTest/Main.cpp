#include <iostream>
#include <string>
#include "person.h"
#include <time.h>
#include <fstream>


using namespace std;


/*
struct subject //����
{
	string itemName;	//�����̸�
	int score;	//���� ����
};

struct student 
{
	string name;		// �л��̸�
	int subjectCount;	// ���ð����
	subject* pItem;		// ���� ���
};
*/

//	�� ������ �ذ����� ������, �ش� �������� commit �� ��.
//	commit �޽����� �����Ӱ� �ص� �˴ϴ�.
/*
void swap(int *ap, int *bp)
{
	int temp = *ap;
	*ap = *bp;
	*bp = temp;
}
*/

int main()
{
	//	1��
	//	0~99 ������ ������ ���� 100���� �����ϰ�, ������������ �����Ͽ� ����Ͻÿ�.
	//	��, ��� ������ int�� �����͸� ����� ��.

	/*
	srand(time(NULL));
	int num=100;
	int *arr = new int [num];
	for (int i=0;  i<num; i++)
	{
		arr[i]=rand()%100;
	}
	
	for(int i=0; i<num; i++)
	{	
		for (int j=i+1; j<num; j++)
		{
			if (arr[i]>arr[j])
			{
				swap(arr[i], arr[j]);
			}
		}
	}
	
	for (int i=0; i<10; i++)
	{
		for (int j=0; j<10; j++)
		{
			cout << arr[(10*i)+j] <<" ";
		}
		cout << endl;
	}
	*/


	//	2��
	//	���(Person)�� ��Ÿ�� Ŭ������ �ۼ��Ͻÿ�. Person.h, Person.cpp ������ ����� ������ ��.
	//	��� ����, �Լ��� public���� �����ϰ� �� ��.
	//	�������
	//		�̸�(name)			: string
	//		����(age)			: int
	//		���翩��(isAlive)	: bool
	//	����Լ�
	//		���ϱ�(talk)			: "Hello, world!"�� ����Ѵ�.
	//		���ڱ�(sleep)		: "zzz"�� ����Ѵ�.

	talk();

	//  3��
	//	�� ���� ���� �ý���
    //  �л�(student)�� ���� ����ü�� ���ð���(item)�� ���� ����ü�� �����.
    //
    //  list.txt ������ �о�鿩 main���� student* �����͸� �̿��Ͽ� �ο����� �����Ҵ�
    //  ���� ���ð��񺰷� subject�� ���� �����Ҵ��� �����Ѵ�.
    //  ���Ͽ��� ��� �����͸� �о��ٸ�
    //  �� ������ "�� �����ο�: 00��" �� ǥ���ϰ�,
    //  �л��̸�: �̸� / ���ð����: 0�� / ����1: 00, ����2: 00, ����3: 00 ...
    //  �� ���� �÷� ����Ѵ�.
    //
    //  �߰��� ���� �����Ϳ� �Ѹ� ���� �ֿܼ��� �߰��Ͽ�
    //  �� �����ο��� ���ο� �л��� ���� ������ ����ϴ� �ڵ带 ������ ��!
    
	/*
	char c;
	int num=1;
	int i=0;
	ifstream fin;
	ofstream fou;
	fin.open ("list.txt");
	fou.open ("output.txt");

	while(!fin.eof())
	{
		fin.get(c);
		if(c=='\n')
		{
			num++;
		}
	}
	student *t1 = new student[num+1];
	
	fin.close();
	fin.open ("list.txt");

	cout << "�� ���� �ο� : " << num << "��" << endl;	
	
	while(i<num)
	{
		fin >> t1[i].name >> t1[i].subjectCount;
		
		t1[i].pItem = new subject[t1[i].subjectCount]; 
		for (int j=0; j<(t1[i].subjectCount); j++)
		{
			fin >> t1[i].pItem[j].itemName >> t1[i].pItem[j].score;
		}
		i++;
	}
	
	for (int i=0; i<num; i++)
	{
		cout << t1[i].name << '\t' << t1[i].subjectCount;
		for(int j=0; j<t1[i].subjectCount; j++)
		{
			cout << '\t' << t1[i].pItem[j].itemName << '\t' << t1[i].pItem[j].score;
		}
		cout << endl;
	}

	cout << "���� �߰��� �л��� �̸��� �����ΰ���? :" ;
	cin >> t1[num].name;
	cout << "������ ������ ����? : " ;
	cin >> t1[num].subjectCount;
	
	t1[num].pItem = new subject[t1[num].subjectCount];

	for(int k=0; k<t1[num].subjectCount; k++)
	{
		cout << "������ ������ �̸��� �����ּ��� : ";
		cin >> t1[num].pItem[k].itemName;
		cout << "������ ������ ������ �����ּ��� : ";
		cin >> t1[num].pItem[k].score;
	}

	cout << "\n �� �����ο� : " << num+1 << " ��" << endl;

	for (int i=0; i<num+1; i++)
	{
		cout << t1[i].name << '\t' << t1[i].subjectCount;
		fou << t1[i].name << '\t' << t1[i].subjectCount;
		for(int j=0; j<t1[i].subjectCount; j++)
		{
			cout << '\t' << t1[i].pItem[j].itemName << '\t' << t1[i].pItem[j].score;
			fou << '\t' << t1[i].pItem[j].itemName << '\t' << t1[i].pItem[j].score;
		}
		cout << '\n';
		fou << '\n';
	}

	delete[] t1;
	
	fin.close();
	fou.close();

	*/

	//	4��
	//	�����ڿ��� �ϰ���� ���� �����ÿ�.
	//	......
	//	......
	//	......
	//	������ �ֱ׷����.



	return 0;
}