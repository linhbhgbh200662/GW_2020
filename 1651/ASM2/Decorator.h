#pragma once
#include <iostream>
#include <string>
#include "Coffee.h"
using namespace std;

class Decorator : public Coffee
{
protected:
	Coffee* coffee;
public:
	Decorator(Coffee* topping);
	virtual string get_description() const = 0;
	virtual int cost() const = 0;
};

class Milk : public Decorator
{
public:
	Milk(Coffee* topping) : Decorator(topping) {}
	string get_description() const;
	int cost() const;
};

class Mocha : public Decorator
{
public:
	Mocha(Coffee* topping) : Decorator(topping) {}
	string get_description() const;
	int cost() const;
};

class Chocolate : public Decorator
{
public:
	Chocolate(Coffee* topping) : Decorator(topping) {}
	string get_description() const;
	int cost() const;
};

class Vani : public Decorator
{
public:
	Vani(Coffee* topping) :Decorator(topping) {}
	string get_description() const;
	int cost() const;
};