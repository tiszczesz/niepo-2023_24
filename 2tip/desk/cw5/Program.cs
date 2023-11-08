using cw5;

FilmsRepo repo = new FilmsRepo();

var films = repo.GetAllFilms();

FilmsInput input = new FilmsInput(films);
input.ShowAllFilms();
