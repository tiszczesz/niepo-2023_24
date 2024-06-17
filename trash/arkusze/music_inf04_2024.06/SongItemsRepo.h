#pragma once
#include <fstream>
#include <vector>
#include <string>
#include "SongItem.h"

class SongItemsRepo {
public:
	std::vector<SongItem> songs;

	void GetSongsFromFile(const std::string& filename,const int recNumber = 6) {
		std::fstream file;
		file.open(filename);
		std::string artist;
		std::string album;
		std::string songNumber;
		std::string year;
		std::string downloadNumber;
		if(file.is_open()) {
			std::string line;
			int index = 0;
			while (std::getline(file,line)) {
				if(index%recNumber==0) {
					artist = line;
				}
				if (index % recNumber == 1) {
					album = line;
				}
				if (index % recNumber == 2) {
					songNumber = line;
				}
				if (index % recNumber == 3) {
					year = line;
				}
				if (index % recNumber == 4) {
					downloadNumber = line;
				}
				if(index % recNumber == 5) {
					songs.push_back(SongItem(artist, album, 
						songNumber, year, downloadNumber));
				}
				index++;
			}
			//ostatni
			songs.push_back(SongItem(artist, album, songNumber, year, downloadNumber));

			file.close();
		}
	}
};
