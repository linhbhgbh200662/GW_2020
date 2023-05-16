#pragma once
#include"Decorator.h"
#include"Coffee.h"
#include<iostream>
#include<vector>
#include<string>
#include<cstdlib>
using namespace std;
class System
{
public:
	
	System();
	void run();
private:
	void print_menu1();
	void print_menu2();
	int get_choice();
	void do_task(const int& choice);
	void run1();
	void do_task1(const int& choice);
	void run2();
	void do_task2(const int& choice);
	void run3();
	void do_task3(const int& choice);
	void run4();
	void do_task4(const int& choice);
};
