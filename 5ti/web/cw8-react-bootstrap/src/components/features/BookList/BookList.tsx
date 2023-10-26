
import React from 'react';
import { Book } from '../../../interfaces/book';
import { Col, ListGroup, Row } from 'react-bootstrap';
import Delete from '../../../delete.png';
import './BookList.css';

type BookListProps = {
  books:Book[],
  deleteBook:(id:string)=>void
}

const BookList = ({books,deleteBook}: BookListProps) => {
  return (
    <div>
      <h2>Lista książek</h2>
      <ListGroup className='mt-4'>
        {books.map((book =>(
          <ListGroup.Item className='bg-light' key={book.id}>
            <Row>
              <Col md={6}>
                {book.title} {book.author} {book.price} zł
              </Col>
              <Col md={{ span:1, offset:5}}>
              <img src={Delete} alt="kosz" className='booklist-image' 
              onClick={(event)=>deleteBook(book.id)}/>
              </Col>
            </Row>
          </ListGroup.Item>
        )))}
      </ListGroup>
    </div>
  )
}

export default BookList     