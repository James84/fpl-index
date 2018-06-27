import React from 'react';
import {Line} from 'react-chartjs-2';

export default (props) => { 
    const data = { datasets: props.datasets, labels: props.labels};

    return (
        <Line data={data}/>
    );
}

