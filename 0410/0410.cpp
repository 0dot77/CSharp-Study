// 0410.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

// 포인터 변수의 상수화
int main()
{
	int a = 0;
	const int* ptr = &a;

	a = 1;
	*ptr = 2;

	return 0;
}
