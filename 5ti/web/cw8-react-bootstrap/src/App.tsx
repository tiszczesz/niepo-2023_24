import React from 'react';

import './App.css';
import { Col, Container } from 'react-bootstrap';
import Header from './components/layout/Header/Header';

function App() {
  return (
    <Container>
      <Header />
      <Col xs="12" md="9">
      <main className='mt-2 mb-2'>
        
      </main>
      </Col>
      <Col xs="12" md="3"></Col>
    </Container>
  );
}

export default App;
