#include "System.h"
#include <Windows.h>

using namespace std;
System::System()
{
}

void System::run()
{
    bool running = true;
    while (running)
    {
        print_menu1();
        int choice = get_choice();
        system("cls");
        do_task(choice);
        if (choice == 0) running = false;
    }
}

void System::print_menu1()
{
    cout << "====Well come to NTD Coffee Store!====" << endl;
    cout << "======Please choose your Coffee!======" << endl;
    cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" << endl;
    cout << "1.Capucinno" << endl;
    cout << "2.MilkCoffee" << endl;
    cout << "3.Espresso" << endl;
    cout << "4.Americano" << endl;
    cout << "EXIT: I don't want buy anything!" << endl;
}

void System::print_menu2()
{
    cout << "1.Add Milk" << endl;
    cout << "2.Add Mocha" << endl;
    cout << "3.Add Chocolate" << endl;
    cout << "4.Add Vani" << endl;
    cout << "Choose: ";
}

int System::get_choice()
{
    cout << "Your choice: ";
    int choice;
    cin >> choice;
    return choice;
}

void System::do_task(const int& choice)
{
    switch (choice)
    {   
    case 1: run1();    break;
    case 2: run2();    break;
    case 3: run3();    break;
    case 4: run4();    break;
    case 0:            break;

    default: cout << "Invalid choice" << endl; break;
    }
}

void System::do_task1(const int& choice)
{
    Coffee* capucinno = new Capucinno();
    int sum = capucinno->cost();

    switch (choice)
    {
    case 1:
        capucinno = new Milk(capucinno);
        cout << capucinno->get_description() << " Cost :" << capucinno->cost() << "$" << endl;
        sum = sum + capucinno->cost();
        cout << "All Price: " << sum << endl;
        cout << "======================================" << endl;
        break;
    case 2:
        capucinno = new Mocha(capucinno);
        cout  << capucinno->get_description() << " Cost :" << capucinno->cost() << "$" << endl;
        sum = sum + capucinno->cost();
        cout << "All Price: " << sum << endl;
        cout << "======================================" << endl;
        break;
    case 3:
        capucinno = new Chocolate(capucinno);
        cout << capucinno->get_description() << " Cost :" << capucinno->cost() << "$" << endl;
        sum = sum + capucinno->cost();
        cout << "All Price: " << sum << endl;
        cout << "======================================" << endl;
        break;
    case 4:
        capucinno = new Vani(capucinno);
        cout << capucinno->get_description() << "Vani Cost :" << capucinno->cost() << "$" << endl;
        sum = sum + capucinno->cost();
        cout << "All Price: " << sum << endl;
        cout << "======================================" << endl;
        break;
    }
}

void System::run1()
{
    bool running = true;
    while (running)
    {
        print_menu2();
        int choice = get_choice();
        system("cls");
        do_task1(choice);
        if (choice == 0) running = false;
    }
}

void System::do_task2(const int& choice)
{
    Coffee* milkcoffee = new MilkCoffee();
    switch (choice)
    {
    case 1:
        milkcoffee = new Milk(milkcoffee);
        cout << milkcoffee->get_description() << " Cost :" << milkcoffee->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 2:
        milkcoffee = new Mocha(milkcoffee);
        cout << milkcoffee->get_description() << " Cost :" << milkcoffee->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 3:
        milkcoffee = new Chocolate(milkcoffee);
        cout << milkcoffee->get_description() << " Cost :" << milkcoffee->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 4:
        milkcoffee = new Vani(milkcoffee);
        cout << milkcoffee->get_description() << " Cost :" << milkcoffee->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    }
}

void System::run2()
{
    bool running = true;
    while (running)
    {
        print_menu2();
        int choice = get_choice();
        system("cls");
        do_task2(choice);
        if (choice == 0) running = false;
    }
}

void System::do_task3(const int& choice)
{
    Coffee* espresso = new Espresso();
    switch (choice)
    {
    case 1:
        espresso = new Milk(espresso);
        cout << espresso->get_description() << " Cost :" << espresso->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 2:
        espresso = new Mocha(espresso);
        cout << espresso->get_description() << " Cost :" << espresso->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 3:
        espresso = new Chocolate(espresso);
        cout << espresso->get_description() << " Cost :" << espresso->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 4:
        espresso = new Vani(espresso);
        cout << espresso->get_description() << " Cost :" << espresso->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    }
}

void System::run3()
{
    bool running = true;
    while (running)
    {
        print_menu2();
        int choice = get_choice();
        system("cls");
        do_task3(choice);
        if (choice == 0) running = false;
    }
}

void System::do_task4(const int& choice)
{
    Coffee* americano = new Americano();
    switch (choice)
    {
    case 1:
        americano = new Milk(americano);
        cout << americano->get_description() << " Cost :" << americano->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 2:
        americano = new Mocha(americano);
        cout << americano->get_description() << " Cost :" << americano->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 3:
        americano = new Chocolate(americano);
        cout << americano->get_description() << " Cost :" << americano->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    case 4:
        americano = new Vani(americano);
        cout << americano->get_description() << " Cost :" << americano->cost() << "$" << endl;
        cout << "======================================" << endl;
        break;
    }
}

void System::run4()
{
    bool running = true;
    while (running)
    {
        print_menu2();
        int choice = get_choice();
        system("cls");
        do_task4(choice);
        if (choice == 0) running = false;
    }
}