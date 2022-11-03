#include <iostream>
#include <ctime>
using namespace std;


/* Zadanie
  Napisac klase oraz kod testujacy opisujacy osobe
  -dodac 5 pol opisujacych osobe (ma byc rok urodzenia)

*/
int CurrentTime()
{
	time_t now = time(0);
	tm* ltm = new tm;
	localtime_s(ltm, &now);
	return 1900 + ltm->tm_year; 
}
class Person
{
	
public:
	
	
	Person(string name, string surname, string height,string weight, string sex, string city)
	{
		this->name = name;
		this->surname = surname;
		this->height = height;
		this->date = 2009;
		this->weight = weight;
		this->sex = sex;
		this->city = city;

	};
	void ShowInfo()
	{
		
		cout << "************************************************" << endl;
		cout << "Imie i Nazwisko  " << name << " " << surname << endl;
		cout << "Wysokoœæ " << height << endl;
		cout << "Urodziny  " << date << endl;
		cout << "Waga " << weight << endl;
		cout << "P³eæ " << sex << endl;
		cout << "Miasto " << city << endl;
		
	}
	void Legalage()
	{
		if (date >= 18)
			cout << " not 18 " << endl;
		else
			cout << " not 18 " << endl;
	}

protected:

private:
	string name;
	string indentifier;
	string surname;
	string height;
	int date;
	string weight;
	string sex;
	string city;    
   


}
;































;
;;
;
;
;;
;
;

int main()
{
	time_t now = time(0);
	tm* ltm = new tm;
	localtime_s(ltm, &now);
	int date;
	date = 1900 + ltm->tm_year;
	
	setlocale(LC_CTYPE, "polish");
	Person personFirst("Jajam" , "Iomate", "178cm", "80", "m","Floryda");
	personFirst.ShowInfo();
	personFirst.Legalage();
	cout << "************************************************" << endl;
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


