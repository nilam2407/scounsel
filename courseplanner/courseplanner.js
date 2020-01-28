import React from "react";
import { connect } from "react-redux";
import * as courseActions from "../../actions/courseActions";
import * as programActions from "../../actions/programActions";
import * as sequenceActions from "../../actions/sequenceActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";
import YearBlock from "./YearBlock";
import Select from "react-select";
import Widget from "../../elements/Widget";
import { addNotification } from "reapop";

class CoursePlanner extends React.Component {
  constructor() {
    super();
  }

  componentDidMount() {
    if (this.props.courses.length === 0) {
      this.props.actions.loadCourses().catch(error => {});
    }

    if (this.props.programs.length === 0) {
      this.props.actions.loadPrograms().catch(error => {});
    }
  }

  handleChange = event => {
    const { value } = event;

    let newSequence = {
      ...this.props.sequence,
      program: value
    };

    this.props.actions.updateSequence(newSequence);
  };

  handleValidate = event => {
    event.preventDefault();
    this.props.actions.validateSequence(this.props.sequence);
  };

  render() {
    var ProgramOps = [];

    for (let i = 0; i < this.props.programs.length; i++) {
      ProgramOps[i] = {
        value: this.props.programs[i].program_id,
        label: this.props.programs[i].program_name
      };
    }

    return (
      <div>
        <div className="row">
          <div className="col-8">
            <Widget
              title="Academic Planner"
              description="Plan your degree, and discover any issues that may arise."
            ></Widget>
          </div>
          <div className="col-3">
            <Select
              placeholder="Select your program"
              options={ProgramOps}
              onChange={this.handleChange}
            />
          </div>
          <div className="col-0">
            <button
              className="btn btn-secondary btn-rounded float-right"
              onClick={this.handleValidate}
            >
              VALIDATE
            </button>
          </div>
        </div>
        <YearBlock
          courses={this.props.courses}
          yearNumber={1}
          numberOfCoursesPerSemester={5}
        />
        <YearBlock
          courses={this.props.courses}
          yearNumber={2}
          numberOfCoursesPerSemester={6}
        />
        <YearBlock
          courses={this.props.courses}
          yearNumber={3}
          numberOfCoursesPerSemester={6}
        />
        <YearBlock
          courses={this.props.courses}
          yearNumber={4}
          numberOfCoursesPerSemester={6}
        />
        <YearBlock
          courses={this.props.courses}
          yearNumber={5}
          numberOfCoursesPerSemester={6}
        />
      </div>
    );
  }
}

CoursePlanner.propTypes = {
  courses: PropTypes.array.isRequired,
  programs: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired,
  sequence: PropTypes.any.isRequired
};

function mapStateToProps(state) {
  return {
    programs: state.programs,
    courses: state.courses,
    sequence: state.sequence
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadCourses: bindActionCreators(courseActions.loadCourses, dispatch),
      loadPrograms: bindActionCreators(programActions.loadPrograms, dispatch),
      updateSequence: bindActionCreators(
        sequenceActions.updateSequence,
        dispatch
      ),
      validateSequence: bindActionCreators(
        sequenceActions.validateSequence,
        dispatch
      ),
      addNotification
    }
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CoursePlanner);
