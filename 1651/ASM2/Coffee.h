#pragma once
#include <iostream>
#include <string>

using namespace std;

class Coffee
{
public:
	virtual string get_description() const = 0;
	virtual int cost() const = 0;
};

class Capucinno : public Coffee
{
private:
	Coffee* capucinno;
public:
	string get_description() const;
	int cost() const;
};

class MilkCoffee : public Coffee
{
private:
	Coffee* milkcoffee;
public:
	string get_description() const;
	int cost() const;
};

class Espresso : public Coffee
{
private:
	Coffee* espresso;
public:
	string get_description() const;
	int cost() const;
};

class Americano : public Coffee
{
private:
	Coffee* americano;
public:
	string get_description() const;
	int cost() const;
};

