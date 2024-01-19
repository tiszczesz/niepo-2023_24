import * as fs  from 'fs';

fs.readFile('./info.txt', 'utf8', (error, data) => {
    if (error) {
      console.log(error);
      return;
    }
  
    console.log(data);
  });