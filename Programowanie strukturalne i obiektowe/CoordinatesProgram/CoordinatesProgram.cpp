
#include <iostream>
using namespace  std;

struct Point
{
	int x;
	int y;
	int z;
};
void CoordinateTestVersion1()
{
	system("cls");
	
	Point UserPoint;

	cout << "Podaj x: \n";
	cin >> UserPoint.x;
	cout << "Podaj y: \n";
	cin >> UserPoint.y;
	cout << "Podaj z: \n";
	cin >> UserPoint.z;

	double distance = calculateDistance(UserPoint.x,UserPoint.y);
	cout << "Odleglosc to:  " << distance << '\n';
}
double calculateDistance(int a, int b)
{
	return sqrt(a * a + b * b);
}
int main()
{
	CoordinateTestVersion2();
}

void CoordinateTestVersion2()
{
	system("cls");
	int x, y;

	//Point point;
	cout << "Podaj x: \n";
	cin >> x;
	cout << "Podaj y: \n";
	cin >> y;

	double distance = calculateDistance(x, y);
	cout << "Odleglosc to:  " << distance << '\n';
}