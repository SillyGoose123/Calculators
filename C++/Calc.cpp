#include <iostream>
#include <string>
using namespace std;

int calc(char op, string in){
    switch (op)
    {
    case '+':

        break;
    
    default:

        break;
    }
    return 0;
}

int main(){
    cout << "Hello from Calc in C++! \n";
    cout << "Type \"exit\" to exit. \n";

    while (true)
    {
        string in = "";
        cout << ">";
        cin >> in;

        if(in.find("+") != 18446744073709551615){
            calc('+', in);

        } else if(in.find("-") != 18446744073709551615){
            calc('-', in);

        } else if(in.find("/") != 18446744073709551615){
              calc('/', in);
  
        } else if(in.find("*") != 18446744073709551615){
             calc('/', in);
  
        } else if(in.find("%") != 18446744073709551615){
            calc('%', in);

        } else if(in.find("exit") != 18446744073709551615){
            return 0;

        } else {

        }
    }
    
    return 0;
}

