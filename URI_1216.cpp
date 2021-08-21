#include <iostream>
using namespace std;
int main()
{
    string nome;
    double contador=0, distancia=0;
    double distanciatotal=0, media=0;
    cout<<fixed;
    cout.precision(1);

    while (getline(cin,nome))
    {
        cin>>distancia;
        contador++;
        distanciatotal += distancia;
        getline(cin,nome);


}

       media = distanciatotal/contador;
       cout<<media<<endl;
}