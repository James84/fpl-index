import React from 'react';
import {Line} from 'react-chartjs-2';

function LineChart(props) => { 
    const data = { datasets: props.datasets, labels: props.labels};

    return (
        <Line data={data}/>
    );
}

export default LineChart;