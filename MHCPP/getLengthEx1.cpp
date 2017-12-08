// Finding length of a string in C++
#include<iostream>
#include<string>
using namespace std;

int count(string);

int main()
{
string str;
cout << "Enter a string: ";
getline(cin,str);
cout << "\nString: " << str << endl;
cout << count(str) << endl;

return 0;

}

int count(string s){
if(s == "")
  return 0;
if(s.length() == 1)
  return 1;
else
    return (s.length());

}

