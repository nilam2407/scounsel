import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import { loadCourses } from "../../actions/courseActions";
import { updateSequence } from "../../actions/sequenceActions";
import PropTypes from "prop-types";
import Select from "react-select";
import _ from "lodash";

function CourseSelect({
  courses,
  yearNumber,
  semesterType,
  courseNumber,
  updateSequence,
  sequence
}) {
  function handleChange(event) {
    const { value } = event;

    var semester;
    if (semesterType === "Fall") {
      semester = 0;
    } else if (semesterType === "Winter") {
      semester = 1;
    } else if (semesterType === "Summer") {
      semester = 2;
    }

    let newSequence = _.cloneDeep(sequence);
    newSequence.years[yearNumber - 1].semesters[semester].courses[
      courseNumber - 1
    ].course_id = value;

    updateSequence(newSequence);
  }

  //Helps map the courses we get into something we can pass as options to the select
  var CourseOps = [];

  for (let i = 0; i < courses.length; i++) {
    CourseOps[i] = {
      value: courses[i].course_id,
      label: courses[i].course_id
    };
  }

  return (
    <div>
      <Select
        placeholder="Select your course"
        options={CourseOps}
        onChange={handleChange}
      />
    </div>
  );
}

CourseSelect.propTypes = {
  courses: PropTypes.array.isRequired,
  semesterType: PropTypes.string.isRequired,
  yearNumber: PropTypes.number.isRequired,
  updateSequence: PropTypes.func.isRequired
};

function mapStateToProps(state) {
  return {
    sequence: state.sequence
  };
}

const mapDispatchToProps = {
  updateSequence
};

export default connect(mapStateToProps, mapDispatchToProps)(CourseSelect);
