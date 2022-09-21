#include <iostream>
using namespace std;

void showMenu()
{
	system("cls");
	std::cout << "Menu:\n";
	std::cout << "1. Pole kwadratu\n";
	std::cout << "2. Pole trojkata\n";
	std::cout << "3. Liczby nieparzyste\n";
	std::cout << "4. Dzielniki\n";
	std::cout << "5. Fibonnacci\n";
	cout << "6. Liczby slowne\n";
	cout << "7. Liczby binnarne\n";
	std::cout << "0. Zamknij program\n";
}

int chooseOptionFromUser()
{
	std::cout << "Wybierz opcje\n";
	int selectedOption;
	std::cin >> selectedOption;
	return selectedOption;
}
void SquareArea()
{
	system("cls");
	std::cout << "Podaj wartosc boku kwadratu:\n ";
		int side;
		std::cin >> side;
		int area = side * side;
		std::cout << "Pole kwadratu to " << area << '\n';


}
void TriangleArea()
{
	system("cls");
	std::cout << "Podaj wartosc boku trojkata:\n ";
	int side;
	std::cin >> side;
	std::cout << "Podaj wartosc wysokosci trojkata:\n";
	int height;
	std::cin >> height;
	int area = side * height / 2;
	std::cout << "Pole trojkata to " << area << '\n';



}
void Non()
{
	system("cls");
	std::cout << "Podaj liczbe: \n";
    int number;
	std::cin >> number;
	
	for (int i= number; i >= 0; i--)
	{
		if (i % 2 != 0)
		std::cout << i << " , ";
		 
	}
	std::cout << '\n';
} 
void i24()
{
	system("cls");
	std::cout << "Podaj liczbe: \n";
	int number;
	std::cin >> number;

	for (int i = 1; i <= number /2; i++)
	{
		if (number % i == 0)
			std::cout << i << " , ";
	}
	std::cout << number << '\n';

	std::cout << '\n';

}
void ficiu()
{
	system("cls");
	std::cout << "Podaj liczbe liczb ciagu fibonaciego:\n";
	int number;

	std::cin >> number;
	int currentFibonacciNumber = 0;
	int PrevOneFibonacciNumber = 0;
    int prevTwoFibonacciNumber = 1;
	for (int i = 0; i < number; i++)
	{
		currentFibonacciNumber = PrevOneFibonacciNumber + prevTwoFibonacciNumber;
		std::cout << currentFibonacciNumber << ", ";

		prevTwoFibonacciNumber = PrevOneFibonacciNumber;
		PrevOneFibonacciNumber = currentFibonacciNumber;
	}
	std::cout << '\n';

}
void NumberToWords()
{
	system("cls");
	string arrayofWordsNumbers[10] = { "zero",  "jeden",  "dwa", "trzy","cztery","piec","szesc","siedem","osiem","dziewiec" };
	cout << "Podaj liczbe do przetworzenia slownie: \n";
	int numberFromUser;
	cin >> numberFromUser;

	int number = numberFromUser;
	
	do
	{
		int digit = number % 10;
		number = number / 10;

		cout << arrayofWordsNumbers[digit] << "   ";
	} while (number != 0);
	cout << '\n';
	number = numberFromUser;
	string stringnumber = "";
	do
	{
		int digit = number % 10;
		number = number / 10;

		stringnumber = arrayofWordsNumbers[digit] + "  " + stringnumber;
	} while (number != 0);
	cout << stringnumber;
	cout << '\n';
}
void FromNumberToBinnar()
{
	system("cls");
	int number;
	std::cout << "Podaj liczbe: \n";
	cin >> number;
	
	int i = 0, tab[31];
	while (number)
	{
		tab[i++] = number % 2; 
			number /= 2;
	}
	for (int a = i - 1; a >= 0; a--)
		cout << tab[a];
		cout << "\n";

}

void doSelectedTask(int selectedOption)
{
	switch (selectedOption)
	{
	 case 1:
		SquareArea();
		break;
	 case 2:
		TriangleArea();
		break;
	 case 3:
		 Non();
		 break;
	 case 4:
		 i24();
		 break;
	 case 5:
		 ficiu();
		 break;
	 case 6:
		 NumberToWords();
		 break;
	 case 7:
		 FromNumberToBinnar();
		 break;
     case 0:
		return;
	 default:
		std::cout << "Brak opcji w menu\n"; \
			break;
	}
	
	system("pause");
	
	/*if (selectedOption == 1)
	{
		SquareArea();
	}
	if (selectedOption == 2)
	{
		TriangleArea();
	}
	*/
}


void mainProgram()
{
	int selected;
	do
	{//1. wyœwietlenie menu
		showMenu();

		//2. wybranie opcji przez u¿ytkownika
		selected = chooseOptionFromUser();

		//3. Wykonanie wybranego zadania
		doSelectedTask(selected);
	} while(selected != 0);
}

int main()
{
	mainProgram();
}

