#include <iostream>
using namespace std;

int GlobalVariable = 7;

void AnotherFunction(int parameter)
{
    parameter = 12;
    int anotherLocalVariableInFunction = 6;
    GlobalVariable = 8;
}
void TestFunction()
{
    int localVariableInFunction = 5;
    AnotherFunction(localVariableInFunction);
    GlobalVariable = 12;
}
int main()
{
  /*  int localVariableInMain = 8;
    TestFunction();
    GlobalVariable = 77;
    AnotherFunction(7); */
    

    // ta zmienna wyladuje na stosie
    // deklaracja zmiennej o nazwie 'number' TYPU int
    int number;
    number = 77;
    cout << number << "\n";
    //sterta wolny obszar pamiecie RAM
    //deklaracja zmiennej lokalnej o nazwie 'wsk' ktora jest wskaznikiem na TYP int
    int* wsk;
    wsk = new int;
    *wsk = 7;
    // wyswietlanie adresu w jakiej znajduje sie obraz w stercie
    cout << wsk << endl;
    cout << *wsk << endl;
    number = (*wsk) * 2;
    cout << "************************\n";

    int tab[14];
    const int rozmiar = 5;
    // int tab[]
    int tab4[rozmiar];
    int* tab5 = new int[number];
    tab5[7] = 15;

}


