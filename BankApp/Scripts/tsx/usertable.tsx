
import * as React from '../react/react.js';
import * as ReactDOM from '../react/react-dom.js';

export class UserTable1 extends React.Component {

    constructor(props) {
        super(props);
    }

    public render() {
        return <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>

                </tr>
            </thead>
            <tbody>

            </tbody>
        </table>;        
        
    }
}  

export function render() {
    ReactDOM.render(<UserTable1/>);
}