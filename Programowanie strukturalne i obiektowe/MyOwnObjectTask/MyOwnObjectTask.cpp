#include <iostream>
#include <ctime>
using namespace std;


/* Zadanie
  Napisac klase oraz kod testujacy opisujacy osobe
  -dodac 5 pol opisujacych osobe (ma byc rok urodzenia)

*/
class Person
{
	
public:
	
	/*Person(string name, string identifier, int BirthYear, int CurrentYear)
	{
		
		 
		this->name = name;
		this->indentifier = identifier;
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);
		BirthYear = 1900 + ltm->tm_year;
		CurrentYear = 1900 + ltm->tm_year;
		if (CurrentYear - BirthYear >= 18)
			Is18 = true;
		else
			Is18 = false;
	}
	*/
	Person(string name, string surname, string height,string weight, string sex, string city)
	{
		this->name = name;
		this->surname = surname;
		this->height = height;
		this->weight = weight;
		this->sex = sex;
		this->city = city;

	};
	void ShowInfo()
	{
		
		cout << "************************************************" << endl;
		cout << "Imie i Nazwisko  " << name << " " << surname << endl;
		cout << "Wysokoœæ " << height << endl;
		cout << "Waga " << weight << endl;
		cout << "P³eæ " << sex << endl;
		cout << "Miasto " << city << endl;
		cout << "************************************************" << endl;
	}
	

protected:

private:
	string name;
	string indentifier;
	string surname;
	string height; 
	string weight;
	string sex;
	string city;
	bool Is18;
}
;


int main()
{
	setlocale(LC_CTYPE, "polish");
	Person personFirst("Jajam" , "Iomate", "178cm", "80", "m","Floryda");
	personFirst.ShowInfo();

	/*time_t now = time(0);

	std::cout << "Number of second since January 1,1970 is:: "
		<< now << std::endl;

	tm* ltm = new tm;
	localtime_s(ltm, &now);

	// print various components of tm structure.
	std::cout << "Year:" << 1900 + ltm->tm_year << std::endl;
	std::cout << "Month: " << 1 + ltm->tm_mon << std::endl;
	std::cout << "Day: " << ltm->tm_mday << std::endl;
	std::cout << "Time: ";
	std::cout << ltm->tm_hour << ":";
	std::cout << ltm->tm_min << ":";
	std::cout << ltm->tm_sec << std::endl;
	delete ltm;
	*/
	
}


