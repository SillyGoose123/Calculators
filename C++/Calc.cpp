#include <iostream>
#include <string>
using namespace std;

int calc(char op, string in){
    string i1 = in.substr(0, in.find(op));
    string i2 = in.substr(in.find(op) + 1, in.length());
    switch (op) {
        case '+':
            return stoi(i1) + stoi(i2);

        case '-':
           return stoi(i1) - stoi(i2);

        case '/':
            return stoi(i1) / stoi(i2);
        
        case '*':
            return stoi(i1) * stoi(i2);

        case '%':
            return stoi(i1) % stoi(i2);
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

        if(in.find("+") != 18446744073709551615 && in.find("+") != 0){
            cout << calc('+', in);

        } else if(in.find("-") != 18446744073709551615 && in.find("+") != 0){
            cout << calc('-', in);

        } else if(in.find("/") != 18446744073709551615 && in.find("+") != 0){
            cout << calc('/', in);
  
        } else if(in.find("*") != 18446744073709551615 && in.find("+") != 0){
            cout << calc('*', in);
  
        } else if(in.find("%") != 18446744073709551615 && in.find("+") != 0){
            cout << calc('%', in);

        } else if(in.find("exit") != 18446744073709551615 && in.find("+") != 0){
            return 0;

        } else {
            cout << "No correct placed operator or not supported operator.";
        }

        cout << "\n";
    }
    
    return 0;
}

