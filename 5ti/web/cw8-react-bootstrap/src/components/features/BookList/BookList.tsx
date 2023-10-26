
import React from 'react'
import { Book } from '../../../interfaces/book'
import { Col, ListGroup, ListGroupItem, Row } from 'react-bootstrap'

type BookListProps = {
  books:Book[],
}

const BookList = ({books}: BookListProps) => {
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
              <Col></Col>
            </Row>
          </ListGroup.Item>
        )))}
      </ListGroup>
    </div>
  )
}

export default BookList     