#include <iostream>
#include<bits/stdc++.h>
using namespace std;
 int bin1[32];
 int bin2[32];
 int bin3[32];
 int tam1 = 0, tam2 = 0;

void intToBi(long long int num,  int* bin, int& tam)
{
   tam = 0;
   int i = 0;
   for(i = 0; num > 0; ++i)
   {
       bin[i] = num % 2;
       num  = num / 2;
       tam++;
   }
   //cout << tam << endl;
}


long long int calcBin()
{
    int tam = tam1 > tam2 ? tam1 : tam2;
    
    for(int i  = 0; i < tam; ++i)
    {
       int v = bin1[i] + bin2[i];
       if(v == 2)
            v = 0;
        bin3[i] = v;
    }
    
    long long int base = 1;
    long long int numero = 0;
    for(int i = 0; i < tam; ++i )
    {
        long long int digito = bin3[i] % 10;
        numero += digito * base;
        base = base * 2;
        //cout << i << " > " << numero << endl;
    }
    return numero;
}
    
 
int main() {
    long long int e1,e2;
    memset(bin2,0,sizeof(bin2));
    memset(bin1,0,sizeof(bin1));
    memset(bin3,0,sizeof(bin3));
    while(cin >> e1 >> e2)
    {
        intToBi(e1,bin1,tam1);
        
        intToBi(e2,bin2,tam2);
        cout << calcBin() << endl;
        memset(bin2,0,sizeof(bin2));
        memset(bin1,0,sizeof(bin1));
        memset(bin3,0,sizeof(bin3));
    }
    return 0;
}





