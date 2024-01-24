import fs from 'fs/promises';
import { colors } from './data.js';


for(const c of colors){
    await fs.appendFile('dane.txt',c+"\n",'utf8')
}
const result = await fs.readFile('dane.txt','utf8');
console.log(result);

