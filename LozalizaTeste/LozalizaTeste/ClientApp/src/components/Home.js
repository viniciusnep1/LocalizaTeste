import React, { Component } from 'react';
import { Container, Row, Col, ListGroupItem, ListGroup, Button, Form, FormGroup, Input, Label } from 'reactstrap';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            data: {
                primes: null,
                divisors: null
            }, divisor: ""
        };
    }


    async fetchData() {
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: this.state.divisor
        };

        const response = await fetch('divisors', requestOptions);
        const data = await response.json();
        console.log(data.result);
        this.setState({ data: data.result });
    }


    render() {

        return (
            <Container>
                <h1 > Calcular Divisores </h1>

                <Form>
                    <FormGroup>
                        <Label for="divisor">Digite um divisor:*</Label>
                        <Input type="number" min="0" name="divisor" id="divisor" placeholder="Digite aqui" onChange={e => this.setState({ divisor: e.target.value, data: { primes: null, divisors: null } })} style={{ width: 250 }} />
                    </FormGroup>
                    <Button type="button" color="primary" active onClick={this.fetchData.bind(this)} style={{ marginBottom: 10 }}> Calcular </ Button>

                </Form>
                {
                    this.state.data.divisors &&
                    <Col md="12">
                        <hr />
                        <h3 > Resultado: </h3>
                        <div>
                            <span>Numero de Entrada:</span> {this.state.divisor}
                        </div>
                        <div>
                            <span>Numero de Divisores:</span> {this.state.data.divisors}
                        </div>
                        <div>
                            <span>Divisores Primos:</span> {this.state.data.primes}
                        </div>
                    </Col>
                }
            </Container>
        );
    }


}
