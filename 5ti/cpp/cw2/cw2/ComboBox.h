#pragma once
#include "Control.h"

class ComboBox : public Control
{
public:
	void Draw() override {
		cout << " To jest metoda Draw() nadpisana w klasie ComboBox" << endl;
	}
	void Other() override {
		cout << " To jest metoda Other() nadpisana w klasie ComboBox" << endl;
	}
	~ComboBox() {
		cout << "niszczenie obiektu ComboBox" << endl;
	}
};

