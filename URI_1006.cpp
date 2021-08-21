#include <iostream>
using namespace std;
int main()
{
  double A,B,C;
  cin>>A>>B>>C;
  double media = (A *2 + B*3 + C * 5)/10;
  cout.precision(1);
  cout.setf(ios::fixed,ios::floatfield);
  cout << "MEDIA = " << media << endl;
}
