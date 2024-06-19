#include <cstdlib>
#include <iostream>
#include <fstream>
#include "SongItemsRepo.h"
using namespace std;

int main() {
	SongItemsRepo repo;
	repo.GetSongsFromFile("Data.txt");
	auto songs = repo.songs;
	for (SongItem item : songs) {
		item.ShowSongInfo();
		cout << "\n";
	}
	return EXIT_SUCCESS;
}