import React, { Component } from 'react';
import './App.css';
import { AgGridReact } from 'ag-grid-react';
import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-balham.css';

class App extends Component {

  constructor(props) {
      super(props);

      this.state = {
          columnDefs: [
              {headerName: 'Id', field: 'id'},
              {headerName: 'Description', field: 'description'},
              {headerName: 'Users', field: 'user_number'},
              {headerName: 'Storage', field: 'storage_limit'},
              {headerName: 'Date', field: 'creation_date'},
          ],
          rowData: []
      }
  }

  componentDidMount() {
      fetch('http://127.0.0.1:5003/api/values/')
          .then(result => result.json())
          .then(rowData => this.setState({rowData}))
  }

  render() {
    return (
      <div>
        <div style={{textAlign: 'center'}}><h1>SenseiOS</h1></div>      
        <div className="ag-theme-balham" style={{ height: '200px', margin: '0 auto', width: '50%' }} >
          <AgGridReact
              enableSorting={true}
              columnDefs={this.state.columnDefs}
              rowData={this.state.rowData}>
          </AgGridReact>
        </div>
      </div>
    );
  }
}

export default App;
