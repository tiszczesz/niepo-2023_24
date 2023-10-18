
import { User } from '../Exercises/Exercise4'

type PropsUserList = {
    users: User[];
    clickHandler:(id:number)=>void
}

const UserList = ({users,clickHandler}: PropsUserList) => {
    return (
        <>
            <div>Lista użytkowników</div>
            <ul className="list-group">
                {users.map((el)=>(
                    <li className='list-group-item d-flex justify-content-between' key={el.id}>
                       <span> Nazwa: {el.name} username: {el.username}
                        email: {el.email}</span>
                        <button onClick={()=>clickHandler(el.id)} className='btn btn-secondary'>X</button>
                    </li>
                ))}
            </ul>
        </>

    )
}

export default UserList