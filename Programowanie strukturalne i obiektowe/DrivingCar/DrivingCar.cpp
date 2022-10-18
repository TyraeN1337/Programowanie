#include <iostream>
using namespace std;

struct CoordinateGPS
{
    int x, y;

};
struct Direction
{
    int x, y;
};
class Car
{
public:
#pragma region Konstrukty
    Car(string name)
    {
        this->name = name;
        coordinateGPS.x = 0;
        coordinateGPS.y = 0;
        direction.x = 1;
        direction.y = 0;
    }
    Car(string name, int x, int y)
    {
        this->name = name;
        coordinateGPS.x = x;
        coordinateGPS.y = y;
        direction.x = 1;
        direction.y = 0;
    }
#pragma endregion
    void ShowInfo()
    {
        cout << "************************************************" << endl;
        cout << "Samochod o nazwie  " << name << endl;
        cout << "Pozycja (" << coordinateGPS.x << ";" << coordinateGPS.y << ")" << endl;
        cout << "************************************************" << endl;
    }

    void moveForward()
    {
        coordinateGPS.x += direction.x;
        coordinateGPS.y += direction.y;

    }
#pragma region TurnMethod
    void TurnLeft()
    {
        int tmpX = direction.x;
        direction.x = -direction.y;
        direction.y = tmpX;
    }
    void TurnRight()
    {
        int tmpX = direction.x;
        direction.x = direction.y;
        direction.y = -tmpX;
    }
    void TurnBack()
    {
        TurnRight();
        TurnRight();
    }
#pragma endregion
protected:




private:
    string name;
    CoordinateGPS coordinateGPS;

    Direction direction;
};

int main()
{
    setlocale(LC_CTYPE, "polish");
    Car carFirst("Super bryka");
    Car carSecond("Kr¹¿ownik szos", 10, 10);

   carFirst.ShowInfo();
   carSecond.ShowInfo();
   carFirst.moveForward();
   carFirst.TurnLeft();
   carFirst.moveForward();

   carFirst.ShowInfo();

}

