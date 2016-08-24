// LearningCPPPart1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <ctype.h>
#include <string>
#include <iostream>

using namespace std;

const float MILES_PER_KM = 0.6214;
const float KMS_PER_MILE = 1.6093;

int _tmain(int argc, _TCHAR* argv[])
{
	int choice;
	float km, miles;

	cout << "\nMiles and Kilometers Converter\n";
	cout << "--------------------------------\n";
	cout << "1 : Miles to kilometers\n";
	cout << "2 : Kilometers to miles\n";
	cout << "3 : Quit\n\n";
	cout << "Enter 1, 2, or 3: ";
	cin >> choice;

	if (choice == 1)
	{
		cout << "Miles? ";
		cin >> miles;
		km = miles * KMS_PER_MILE;
		cout << miles << " miles = " << km << " kilometers\n";
	}
	else if (choice == 2)
	{
		cout << "Kilometers? ";
		cin >> km;
		miles = km * MILES_PER_KM;
		cout << km << " kilometers = " << miles << " miles\n";
	}
	else if (choice != 3)
	{
		cout << "Illegal choice!";
	}
}

