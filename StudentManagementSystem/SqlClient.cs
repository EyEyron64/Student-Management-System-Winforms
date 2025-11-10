using System.Configuration;
using MySql.Data.MySqlClient;
using Dapper;

namespace StudentManagementSystem;
public class SqlClient
{
    private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

    public IEnumerable<Student> GetStudents()
    {
        using var connection = new MySqlConnection(_connectionString);
        return connection.Query<Student>(
            "SELECT student_id AS Id, first_name AS FirstName, last_name AS LastName, email AS Email FROM Students"
        );
    }
    public IEnumerable<Student> GetStudents(string keyword)
    {
        using var connection = new MySqlConnection(_connectionString);
        return connection.Query<Student>(
            "SELECT student_id AS Id, first_name AS FirstName, last_name AS LastName, email AS Email FROM Students WHERE first_name LIKE @Keyword OR last_name LIKE @Keyword",
            new { Keyword = $"%{keyword}%" }
        );
    }
    public void CreateStudent(Student student)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Execute(
            "INSERT INTO Students (first_name, last_name, email) VALUES (@FirstName, @LastName, @Email)",
            student
        );
    }
    public void UpdateStudent(Student student)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Execute(
            "UPDATE Students SET first_name = @FirstName, last_name = @LastName, email = @Email WHERE student_id = @Id",
            student
        );
    }
    public void DeleteStudent(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Execute(
            "DELETE FROM Students WHERE student_id = @Id",
            new { Id = id }
        );
    }

    public IEnumerable<KeyValuePair<string, string>> GetEnrolledCourses(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        var rows = connection.Query(
            "SELECT c.course_code AS code, c.course_name AS name FROM enrolled_courses e JOIN courses c ON e.course_code = c.course_code WHERE e.student_id = @Id",
            new { Id = id }
        );
        return rows.Select(r => new KeyValuePair<string, string>(
            (string)r.code,
            (string)r.name
        ));
    }
    public IEnumerable<KeyValuePair<string, string>> GetAllCourses()
    {
        using var connection = new MySqlConnection(_connectionString);
        var rows = connection.Query(
            "SELECT course_code AS code, course_name AS name FROM courses"
        );
        return rows.Select(r => new KeyValuePair<string, string>(
            (string)r.code,
            (string)r.name
        ));
    }
    public void EnrollStudentInCourse(int studentId, string courseCode)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Execute(
            "INSERT INTO enrolled_courses (student_id, course_code) VALUES (@StudentId, @CourseCode)",
            new { StudentId = studentId, CourseCode = courseCode }
        );
    }
    public void UnenrollStudentFromCourse(int studentId, string courseCode)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Execute(
            "DELETE FROM enrolled_courses WHERE student_id = @StudentId AND course_code = @CourseCode",
            new { StudentId = studentId, CourseCode = courseCode }
        );
    }
}