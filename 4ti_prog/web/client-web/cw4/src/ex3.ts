import fs from 'fs/promises';
import { lines } from './data.js';


for(const c of lines){
    await fs.appendFile('dane.txt',c+"\n",{encoding:'utf-8'})
}
const result = await fs.readFile('dane.txt',{encoding:'utf-8'});
console.log(result);

