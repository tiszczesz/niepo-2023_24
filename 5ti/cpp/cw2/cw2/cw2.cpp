// cw2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

#include "ComboBox.h"
#include "Control.h"
#include "RadioButton.h"

int main()
{
    auto f1 = [](const int& a, const int& b) {
        if (a == b) return 0;
        return a > b? 1: -1;
        };
    cout << f1(12, 7) << endl;
    //Control* control = new Control(); //klasa abstrakcyjna przynajmniej 1 metoda
    // czysto wirualna
    ComboBox* cb = new ComboBox();
    std::vector<Control*> controls;
    controls.push_back(new ComboBox());
    controls.push_back(new ComboBox());
    controls.push_back(new RadioButton());
    for (auto control : controls) {
        control->Draw();
    }
    for (auto control : controls) {
        delete control;
    }
    controls.clear();
    cout << "ds s fds f s dsd " << endl;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
