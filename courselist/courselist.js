import React, {Component} from 'react'
import Widget from '../../elements/Widget'
import CourseTable from './coursetable'

const Courselist = () => (
    <div className="row">
        <div className="col">
            <Widget title="Course List" description="Browse through the list of courses to find ones that suit your interests/needs">
                <CourseTable />
            </Widget>
        </div>
    </div>
)

export default Courselist