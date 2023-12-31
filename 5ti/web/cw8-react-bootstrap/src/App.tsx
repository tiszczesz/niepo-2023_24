import React, { useState } from 'react';

import './App.css';
import { Col, Container, Row } from 'react-bootstrap';
import Header from './components/layout/Header/Header';
import BookList from './components/features/BookList/BookList';
import Sidebar from './components/layout/Sidebar/Sidebar';
import { booksData } from './data/BookRepo';


function App() {
  const [books,setBooks] = useState(booksData);

  const deleteBook = (id:string)=>{
    console.log(`usuwanie ksiazki o id: ${id}`);
    setBooks(books.filter((b)=>{return b.id!==id}))
  }
  return (
    <Container>
      <Header />
      <Row>
        <Col xs="12" md="9">
          <main className='mt-2 mb-2'>
            <BookList books={books} deleteBook={deleteBook} />
          </main>
        </Col>
        <Col xs="12" md="3">
          <Sidebar />
        </Col>
      </Row>
    </Container>
  );
}

export default App;
