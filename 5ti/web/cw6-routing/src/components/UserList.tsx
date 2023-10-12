
import { User } from '../Exercises/Exercise4'

type PropsUserList = {
    users: User[]
}

const UserList = ({users}: PropsUserList) => {
    return (
        <>
            <div>Lista użytkowników</div>
            <ul className="list-group">
                {users.map((el)=>(
                    <li className='list-group-item d-flex justify-content-between' key={el.id}>
                       <span> Nazwa: {el.name} username: {el.username}
                        email: {el.email}</span>
                        <button className='btn btn-secondary'>X</button>

                    </li>
                ))}
            </ul>
        </>

    )
}

export default UserList