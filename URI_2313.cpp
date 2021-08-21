#include<iostream>
using namespace std;
int main(){

  string saida = "";
  float a,b,c;
  cin >> a >> b >> c;
  if (
          a <= 0 or b <= 0 or c <= 0 or
          a > 100000 or b > 100000 or c > 100000
          or !(a < b + c and b  < a + c and c < a +  b )
     )
    saida = "Invalido";
  else
    if ((a == b ) and (b == c))
      saida = "Valido-Equilatero";
    else
  if ((a == b) or (a == c) or (b == c))
    saida = "Valido-Isoceles";
      else
      if ((a != b) and (a != c) and (b != c))
        saida = "Valido-Escaleno";
        else
          saida = "Invalido";
  if (saida != "")
    cout << saida << endl;

  if ((saida != "Invalido" and saida != "")){


    if(
            (a * a == (b * b + c * c))
         or (b * b == (a * a + c * c))
         or (c * c == (a * a + b * b))

       )
      cout <<"Retangulo: S" << endl;
     else
       cout << "Retangulo: N" << endl;
  }

}
