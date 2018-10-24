

var UserTableRow = React.createClass({

    render: function () {
        return (
            <tr>
                <td>{this.props.item.FirstName}</td>
                <td>{this.props.item.LastName}</td>
                <td>{this.props.item.Email}</td>
            </tr>
        );
    }

});