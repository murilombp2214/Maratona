#include <iostream>
#include<bits/stdc++.h>
using namespace std;
    
bool isPrimeNumber(int number)
{
    int s = sqrt(number);
    for(int i = 2; i <= s; ++i)
    {
        if(number % i == 0) 
        {
            return false;
        }
            
    }
    return true;
}
  
int* primos = new int[100000];
int indexPrimos = 0;
void gerarPrimos()
{
    for(int i = 2; i < 100000; ++i)
    {
        if(isPrimeNumber(i))
        {
            primos[indexPrimos++] = i;
        }
        

    }
}



int main() {
    int input = -1;
    gerarPrimos();
    cin >> input;
    while(input)
    {
        std::vector<int> vet;
        for(int i = 1; i <= input; ++i)
            vet.push_back(i);
        
        int i = 0;
        int pos = 0;
        while(vet.size() > 1)
        {
            pos = (pos + (primos[i++] - 1)) % vet.size();
            vet.erase(vet.begin() + pos);
        }
        
        
        cout << vet[0] << endl;
        cin >> input;
        
    }

}





