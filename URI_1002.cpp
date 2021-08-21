#include <iostream>
using namespace std;
int main()
{
    double a;
    cin >> a;
    cout.precision(4);
    cout.setf(ios::fixed,ios::floatfield);
    cout << "A="<<3.14159*a*a << endl;
    return 0;  
}
