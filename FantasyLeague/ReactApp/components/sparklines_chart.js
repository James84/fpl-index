import React from 'react';
import { Sparklines, SparklinesLine, SparklinesReferenceLine } from 'react-sparklines';

export default (props) => {
    return (
        <div>
            <Sparklines width={80} height={40} data={props.data}>
                <SparklinesLine style={{ fill: "none" }} color={'red'}/>
                <SparklinesReferenceLine type="avg"/>
            </Sparklines>
            <div>{props.label}</div>
        </div>
    );
}