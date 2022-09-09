#include <iostream>

void showMenu()
{
	system("cls");
	std::cout << "Menu:\n";
	std::cout << "1. Pole kwadratu\n";
	std::cout << "2. Pole trojkata\n";
}

void chooseOptionFromUser()
{
	std::cout << "Wybierz opcje\n";
	int selectedOption;
	std::cin >> selectedOption;
}

void doSelectedTask()
{
	if (selectedOption == 1)
	{
		PoleKwadratu();
	}
	if (selectedOption == 2)
	{
		PoleTrojkata();
	}
}

void mainProgram()
{
	//1. wyœwietlenie menu
	showMenu();

	//2. wybranie opcji przez u¿ytkownika
	chooseOptionFromUser();

	//3. Wykonanie wybranego zadania
	doSelectedTask();
}

void main()
{
	mainProgram();
}

