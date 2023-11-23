#pragma once
#include "Control.h"
class RadioButton :    public Control
{
    void Draw() override {
        cout << "Teraz rysujemy RadioButton" << endl;
    }
    ~RadioButton() {
        cout << "niszczenie obiektu RadioButton" << endl;
    }
};

