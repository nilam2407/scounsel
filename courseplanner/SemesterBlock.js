import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import { loadCourses } from "../../actions/courseActions";
import PropTypes from "prop-types";
import Widget from "../../elements/Widget";
import Select from "react-select";
import CourseSelect from "./CourseSelect";

function SemesterBlock({
  courses,
  yearNumber,
  semesterType,
  numberOfCoursesPerSemester
}) {
  let arr = [];
  for (let i = 1; i < numberOfCoursesPerSemester + 1; i++) {
    arr.push(
      <CourseSelect
        courses={courses}
        yearNumber={yearNumber}
        semesterType={semesterType}
        courseNumber={i}
      />
    );
  }

  return (
    <div>
      <br></br>
      <h6>{semesterType}</h6>
      {arr}
      <br></br>
    </div>
  );
}

SemesterBlock.propTypes = {
  courses: PropTypes.array.isRequired,
  semesterType: PropTypes.string.isRequired,
  yearNumber: PropTypes.number.isRequired,
  numberOfCoursesPerSemester: PropTypes.number.isRequired
};

export default SemesterBlock;
