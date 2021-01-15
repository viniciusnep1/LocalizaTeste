import React, { Component } from 'react';
import { Container, Button } from 'reactstrap';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }


    async populateWeatherData() {
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: 45
        };

        const response = await fetch('divisors', requestOptions);
        const data = await response.json();
        console.log(data);
        this.setState({ forecasts: data, loading: false });
    }


    render() {

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                <Button type="button" onClick={this.populateWeatherData.bind(this)} > Botão </ Button>

            </div>
        );
    }

    
}
