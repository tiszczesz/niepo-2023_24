export default  function GetPost(){
    return fetch("https://jsonplaceholder.typicode.com/posts")
    .then(res=>res.json())
    .then(data=>data);
}