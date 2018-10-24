


var UserTable = React.createClass(
    {

        getInitialState: function () {
            return { items: [] }
        },
        componentDidMount: function () {
            $.ajax({
                url: this.props.url,
                dataType: 'json',
                success: function (data) {
                    if (this.isMounted()) {
                        this.setState({
                            items: data.data
                        });
                    }
                }.bind(this),
                error: function (xhr, status, err) {
                    console.error(this.props.url, status, err.toString());  
                }.bind(this)
            });
        },
        render: function () {
            var rows = [];

            var itemsLoc = this.state.items;
            Object.keys(itemsLoc).forEach(function (key) {
                var iteml = itemsLoc[key]
                rows.push(
                    <UserTableRow item={iteml} />);

            });


            return (
                <table>
                    <thead>
                        <tr>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Email</th>

                        </tr>
                    </thead>
                    <tbody>
                        {rows}
                    </tbody>
                </table>
            )
        }
    }
);

React.render(
    <UserTable url="/ReactUser/GetUserList" />,
    document.getElementById('container')
);

