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
        {loading?<p className="spinner-border"></p> :<UserList users={users} />}
        
    </div>
  )
}

export default Exercise4