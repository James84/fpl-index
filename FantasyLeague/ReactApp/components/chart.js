import React from 'react';
import {Line} from 'react-chartjs-2';

export default (props) => {
    const datasets = [{
        data: props.data,
        label: props.title,
        backgroundColor: "rgba(75,192,192,0.4)",
        borderColor: "rgba(75,192,192,1)",
        pointBackgroundColor: "#fff",
        pointsBorderColor: "rgba(75,192,192,1)",
        fill: false,
        borderJoinStyle: "miter"
    }];
        
    const data = { datasets: datasets, labels: props.labels};
        console.log('props', data)

    return (
        <Line data={data}/>
    );
}