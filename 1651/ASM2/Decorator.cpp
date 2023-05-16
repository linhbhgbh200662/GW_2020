#include "Decorator.h"

Decorator::Decorator(Coffee* topping)
{
	coffee = topping;
}

string Milk::get_description() const
{
	return coffee->get_description() + ", Milk";
}

int Milk::cost() const
{
	return 50 /*+ coffee->cost()*/;
}

string Mocha::get_description() const
{
	return coffee->get_description() + ", Mocha";
}

int Mocha::cost() const
{
	return 60 /*+ coffee->cost()*/;
}

string Chocolate::get_description() const
{
	return coffee->get_description() + ", Chocolate";
}

int Chocolate::cost() const
{
	return 70 + coffee->cost();
}

string Vani::get_description() const
{
	return coffee->get_description() + ", Vani";
}

int Vani::cost() const
{
	return 80 + coffee->cost();
}



