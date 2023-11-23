#pragma once
#include <iostream>
using namespace std;
class Control
{
public:
	std::string info = "Control";
	virtual void Draw() = 0;
	virtual void Other() {
		cout << "Inna metoda z klasy Control" << endl;
	}

	virtual ~Control() {
		cout << "niszczenie obiektu" << endl;
	}
};

