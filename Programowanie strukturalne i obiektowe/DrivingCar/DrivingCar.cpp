#include <iostream>
using namespace std;

struct CoordinateGPS
{
    int x, y;

};
class Car
{
public:
    Car(string name)
    {
        this->name = name;
        coordinateGPS.x = 0;
        coordinateGPS.y = 0;
    }
    Car(string name, int x, int y)
    {
        this->name = name;
        coordinateGPS.x = x;
        coordinateGPS.y = y;
    }
    void ShowInfo()
    {
        cout << "************************************************" << endl;
        cout << "Auto o nazwie  " << name << endl;
        cout << "Pozycja (" << coordinateGPS.x << ";" << coordinateGPS.y << ")" << endl;
        cout << "************************************************" << endl;
    }
protected:



private:
    string name;
    CoordinateGPS coordinateGPS;
};

int main()
{
    setlocale(LC_CTYPE, "polish");
    Car carFirst("Super bryka");
    Car carSecond("Kr¹¿ownik szos", 10, 10);

   carFirst.ShowInfo();
   carSecond.ShowInfo();
}

