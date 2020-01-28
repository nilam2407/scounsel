import React from "react";
import Table from "./DefaultTable";
import * as courseActions from "../../actions/courseActions";
import { connect } from "react-redux";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class CourseTable extends React.Component {
  componentDidMount() {
    if (this.props.courses.length === 0) {
      this.props.actions.loadCourses().catch(error => {
        alert("Loading courses failed" + error);
      });
    }

    this.columns = ["course_id", "course_name", "description"];
    this.columnNames = ["Course Code", "Course Name", "Course Description"];
  }

  constructor() {
    super();
    this.onSearch = this.onSearch.bind(this);
    this.onChangeItemsPerPage = this.onChangeItemsPerPage.bind(this);
    this.state = {
      items: [],
      search: "",
      itemsPerPage: 10
    };
  }

  onSearch(e) {
    e.preventDefault();

    this.setState({
      search: e.target.value
    });
    return false;
  }

  onChangeItemsPerPage(e) {
    e.preventDefault();
    this.setState({
      itemsPerPage: e.target.value
    });
    return false;
  }

  render() {
    return (
      <Table
        items={this.props.courses}
        columns={this.columns}
        columnNames={this.columnNames}
        itemsPerPage={this.state.itemsPerPage}
        search={this.state.search}
        onSearch={this.onSearch}
      />
    );
  }
}

CourseTable.propTypes = {
  courses: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
  return {
    courses: state.courses
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadCourses: bindActionCreators(courseActions.loadCourses, dispatch)
    }
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CourseTable);
