import * as fs  from 'fs';
import { colors } from './data.js';

fs.readFile('./info.txt', 'utf8', (error, data) => {
    if (error) {
      console.log(error);
      return;
    }
  
    console.log(data);
  });
  fs