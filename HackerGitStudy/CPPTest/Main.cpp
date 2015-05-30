#include <iostream>
#include <string>
#include "person.h"
#include <time.h>
#include <fstream>


using namespace std;


/*
struct subject //과목
{
	string itemName;	//과목이름
	int score;	//과목 점수
};

struct student 
{
	string name;		// 학생이름
	int subjectCount;	// 응시과목수
	subject* pItem;		// 과목 목록
};
*/

//	각 문제를 해결했을 때마다, 해당 시점에서 commit 할 것.
//	commit 메시지는 자유롭게 해도 됩니다.
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
	//	1번
	//	0~99 범위의 임의의 정수 100개를 저장하고, 오름차순으로 정렬하여 출력하시오.
	//	단, 모든 변수는 int형 포인터만 사용할 것.

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


	//	2번
	//	사람(Person)을 나타낼 클래스를 작성하시오. Person.h, Person.cpp 파일을 만들어 구현할 것.
	//	모든 변수, 함수는 public으로 접근하게 할 것.
	//	멤버변수
	//		이름(name)			: string
	//		나이(age)			: int
	//		생사여부(isAlive)	: bool
	//	멤버함수
	//		말하기(talk)			: "Hello, world!"를 출력한다.
	//		잠자기(sleep)		: "zzz"를 출력한다.

	talk();

	//  3번
	//	반 성적 관리 시스템
    //  학생(student)에 대한 구조체와 응시과목(item)에 대한 구조체를 만든다.
    //
    //  list.txt 파일을 읽어들여 main에서 student* 포인터를 이용하여 인원별로 동적할당
    //  또한 응시과목별로 subject에 대한 동적할당을 구현한다.
    //  파일에서 모든 데이터를 읽었다면
    //  맨 위에는 "총 응시인원: 00명" 을 표시하고,
    //  학생이름: 이름 / 응시과목수: 0개 / 과목1: 00, 과목2: 00, 과목3: 00 ...
    //  와 같은 꼴로 출력한다.
    //
    //  추가로 현재 데이터에 한명만 직접 콘솔에서 추가하여
    //  총 응시인원과 새로운 학생에 대한 점수를 출력하는 코드를 만들어보실 것!
    
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

	cout << "총 응시 인원 : " << num << "명" << endl;	
	
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

	cout << "새로 추가할 학생의 이름은 무엇인가요? :" ;
	cin >> t1[num].name;
	cout << "응시한 과목의 수는? : " ;
	cin >> t1[num].subjectCount;
	
	t1[num].pItem = new subject[t1[num].subjectCount];

	for(int k=0; k<t1[num].subjectCount; k++)
	{
		cout << "응시한 과목의 이름을 적어주세요 : ";
		cin >> t1[num].pItem[k].itemName;
		cout << "응시한 과목의 점수를 적어주세요 : ";
		cin >> t1[num].pItem[k].score;
	}

	cout << "\n 총 응시인원 : " << num+1 << " 명" << endl;

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

	//	4번
	//	교육자에게 하고싶은 말을 적으시오.
	//	......
	//	......
	//	......
	//	나한테 왜그랬어요.



	return 0;
}