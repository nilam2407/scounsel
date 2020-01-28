import React, {Component} from 'react'
import Widget from '../../elements/Widget'
import Select from 'react-select'
import Form from '../Form'

const adminchanges =[
    {value: 'Edit Course Choice', label: 'Edit Course Choice'},
    {value: 'Change Password', label: 'Change Password'},
]

const currentcourses = []

const allcourses =[
    {value: 'COMP3710', label: 'COMP3710'},
    {value: 'COMP4220', label: 'COMP4220'},
    {value: 'COMP4150', label: 'COMP4220'},
    {value: 'COMP3670', label: 'COMP3670'},
    {value: 'COMP4990', label: 'COMP4990'},
]

const Admin = () => (
    <div className="row">
        <Widget 
        title="Admin Entry"
        description="Administrator form for editing user data">
            <div className="col col-md-4">
                <p>Username:</p>
                <input type="text"></input>
                <br></br>
                Change desired:
                <Select options={adminchanges} />
                <br></br>
                Change:
                <Select options={currentcourses} />
                to
                <Select options={allcourses} />
                <br></br>
                OR
                <br></br><br></br>
                Enter new password
                <br></br>
                <input type="password">

                </input>
                <br></br>
                <br></br>

                <div className="form-group">
                    <button
                        className="btn btn-primary btn-rounded btn-outline"
                        type="submit"
                        Submit>
                            Submit
                    </button>
                </div>
            </div>
        </Widget>
    </div>
)

export default Admin