import axios from "axios";
import { useEffect, useState } from "react";
import UserList from "../components/UserList";

export interface User{
    id:number;
    name:string;
    username:string;
    email:string
}


const Exercise4 = () => {
    const [users,setUsers] = useState<User[]>([]);
    const [loading,setLoading] = useState(true);    
    const removeUser = (id:number)=>{
        console.log("usuwanie: "+id);
        console.log(users);
        
        const removed = users.filter((elem)=>{
            return elem.id!==id
        })
        setUsers(removed)
        console.log(removed);
    }
    useEffect(()=>{
        console.log("rendering Exercise4.....");        
        axios.get<User[]>('https://jsonplaceholder.typicode.com/users')
        .then((res)=>{
            console.log(res.data); 
            setUsers(res.data)           
        }).finally(
            ()=>setLoading(false)
        )
    },[])
  return (
    <div className="container">
        {loading?<p className="spinner-border"></p> 
        :<UserList users={users} clickHandler={(id)=>removeUser(id)}/>}
        
    </div>
  )
}

export default Exercise4