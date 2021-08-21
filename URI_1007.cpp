#include <iostream>
using namespace std;
int main()
{
  int A,B,C,D;
  cin>>A>>B>>C>>D;
  int DIFERENCA = (A * B - C * D);
  cout.precision(1);
  cout.setf(ios::fixed,ios::floatfield);
  cout << "DIFERENCA = " << DIFERENCA << endl;
}
