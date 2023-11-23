#pragma once
#include <vector>
#include <cstdlib>
#include <ctime>
#include <iostream>

class Finder
{
private:
	std::vector<int> numbers;
public:
	Finder() {
		Fill();
	}
	void Fill() {
		srand(time(NULL));
		int number = 0;
		do {
			number = rand() % 4;
			numbers.push_back(number);
		} while (number != 0);
	}
	void Show() {
		for (int number : numbers) {
			std::cout << number << " ";
		}
		std::cout << std::endl;
	}
	int Search(int toFind) {
		int index = -1;
		do {
			index++;
		} while (numbers[index] != toFind && numbers[index] != 0);
		return (numbers[index] == toFind && numbers[index]!=0) ? index : -1;
	}

};

