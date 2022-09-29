
#include <iostream>
using namespace  std;

void CoordinateTestVersion1()
{
	system("cls");
	int x, y;
	cout << "Podaj x: \n";
	cin >> x;
	cout << "Podaj y: \n";
	cin >> y;

	double distance = calculateDistance(x, y);
	cout << "Odleglosc to:  " << distance << '\n';
}
double calculateDistance(int a, int b)
{
	return sqrt(a * a + b * b);
}
int main()
{
	CoordinateTestVersion1();
}

