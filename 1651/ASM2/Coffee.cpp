#include "Coffee.h"
using namespace std;



string Capucinno::get_description() const
{
	return "Capucinno";
}

int Capucinno::cost() const
{
	return 100;
}


string MilkCoffee::get_description() const
{
	return "MilkCoffee";
}

int MilkCoffee::cost() const
{
	return 100;
}

string Espresso::get_description() const
{
	return "Espresso";
}

int Espresso::cost() const
{
	return 100;
}

string Americano::get_description() const
{
	return "Americano";
}

int Americano::cost() const
{
	return 100;
}


