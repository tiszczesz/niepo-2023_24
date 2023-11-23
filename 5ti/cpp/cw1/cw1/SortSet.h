#pragma once
#include <cstdlib>
#include <ctime>
#include <iostream>
enum class Genre {
	asc, desc
};
class SortSet
{
private:
	int* tab;
	size_t size;
	int GetMax(int start = 0) {
		int index = start;
		int Max = tab[index];
		for (size_t i = start; i < size; i++) {
			if (tab[i] > Max) {
				index = i;
				Max = tab[i];
			}
		}
		return index;
	}
	int GetMin(int start = 0) {
		int index = start;
		int Min = tab[index];
		for (size_t i = start; i < size; i++) {
			if (tab[i] < Min) {
				index = i;
				Min = tab[i];
			}
		}
		return index;
	}
	void Fill(int rangeLow = 0, int rangUP = 100) {
		srand(time(NULL));
		for (size_t i = 0; i < size; i++) {
			tab[i] = rand() % (rangUP - rangeLow) + rangeLow;
		}
	}
	void Swap(int& a, int& b) {
		int temp = a;
		a = b;
		b = temp;
	}
public:
	SortSet(size_t size=10, int rangeLow = 0, int rangUP = 100) {
		this->size = size <= 0 ? 10 : size;
		tab = new int[this->size];
		Fill(rangeLow, rangUP);
	}

	void Show() {
		for (size_t i = 0; i < size;i++) {
			std::cout << tab[i] << " ";
		}
		std::cout << std::endl;
	}
	

	void Sort(Genre genre= Genre::asc) {
		for(size_t i=0;i<size;i++) {
			if (genre == Genre::asc) {
				Swap(tab[i], tab[GetMin(i)]);
			}else{
				Swap(tab[i], tab[GetMax(i)]);
			}
		}
	}
	 ~SortSet() {
		 delete[] tab;
		 tab = nullptr;
	}
};


