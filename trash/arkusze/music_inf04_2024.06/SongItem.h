#pragma once
#include <string>
class SongItem
{
public:
	std::string artist;
	std::string album;
	std::string songNumber;
	std::string year;
	std::string downloadNumber;
	SongItem(std::string artist, std::string album, std::string songNumber, 
		std::string year, std::string downloadNumber) {
		this->artist = artist;
		this->album = album;
		this->songNumber = songNumber;
		this->year = year;
		this->downloadNumber = downloadNumber;
	}
	void ShowSongInfo() {
		std::cout << " ----- Informacje o piosence -------- " << std::endl;
		std::cout << artist << std::endl;
		std::cout << album << std::endl;
		std::cout << songNumber << std::endl;
		std::cout << year << std::endl;
		std::cout << downloadNumber << std::endl;
		std::cout << " ----- K O N I E C -------- " << std::endl;
	}

};

