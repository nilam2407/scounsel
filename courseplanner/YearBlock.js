import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import { loadCourses } from "../../actions/courseActions";
import PropTypes from "prop-types";
import Widget from "../../elements/Widget";
import Select from "react-select";
import SemesterBlock from "./SemesterBlock";

function YearBlock({ courses, yearNumber, numberOfCoursesPerSemester }) {
  return (
    <div>
      <h5>Year {yearNumber}:</h5>
      <div className="row">
        <div className="col-4">
          <SemesterBlock
            courses={courses}
            yearNumber={yearNumber}
            semesterType={"Fall"}
            numberOfCoursesPerSemester={numberOfCoursesPerSemester}
          />
        </div>
        <div className="col-4">
          <SemesterBlock
            courses={courses}
            yearNumber={yearNumber}
            semesterType={"Winter"}
            numberOfCoursesPerSemester={numberOfCoursesPerSemester}
          />
        </div>
        <div className="col-4">
          <SemesterBlock
            courses={courses}
            yearNumber={yearNumber}
            semesterType={"Summer"}
            numberOfCoursesPerSemester={numberOfCoursesPerSemester}
          />
        </div>
      </div>
      <br></br>
      <br></br>
      <br></br>
    </div>
  );
}

YearBlock.propTypes = {
  courses: PropTypes.array.isRequired,
  yearNumber: PropTypes.number.isRequired,
  numberOfCoursesPerSemester: PropTypes.number.isRequired
};

export default YearBlock;
