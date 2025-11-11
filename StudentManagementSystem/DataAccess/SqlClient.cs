using System.Configuration;
using MySql.Data.MySqlClient;
using Dapper;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.DataAccess;
public class SqlClient
{
    private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    public async Task<IEnumerable<Student>> GetStudents(string? keyword)
    {
        using var connection = new MySqlConnection(_connectionString);
        var query = "SELECT student_id AS Id, first_name AS FirstName, last_name AS LastName, email AS Email FROM Students";
        if (!String.IsNullOrEmpty(keyword))
        {
            query += " WHERE first_name LIKE @Keyword OR last_name LIKE @Keyword";
        }
        return await connection.QueryAsync<Student>(query, new { Keyword = $"%{keyword}%" });
    }
    public async Task CreateStudent(Student student)
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.ExecuteAsync(
            "INSERT INTO Students (first_name, last_name, email) VALUES (@FirstName, @LastName, @Email)",
            student
        );
    }
    public async Task UpdateStudent(Student student)
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.ExecuteAsync(
            "UPDATE Students SET first_name = @FirstName, last_name = @LastName, email = @Email WHERE student_id = @Id",
            student
        );
    }
    public async Task DeleteStudent(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.ExecuteAsync(
            "DELETE FROM Students WHERE student_id = @Id",
            new { Id = id }
        );
    }
    public async Task<IEnumerable<Course>> GetEnrolledCourses(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        return await connection.QueryAsync<Course>(
            "SELECT c.course_code AS Code, c.course_name AS Name FROM enrolled_courses e JOIN courses c ON e.course_code = c.course_code WHERE e.student_id = @Id",
            new { Id = id }
        );
    }
    public async Task<IEnumerable<Course>> GetAllCourses()
    {
        using var connection = new MySqlConnection(_connectionString);
        return await connection.QueryAsync<Course>(
            "SELECT course_code AS code, course_name AS name FROM courses"
        );
    }
    public async Task EnrollStudentInCourse(int studentId, string courseCode)
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.ExecuteAsync(
            "INSERT INTO enrolled_courses (student_id, course_code) VALUES (@StudentId, @CourseCode)",
            new { StudentId = studentId, CourseCode = courseCode }
        );
    }
    public async Task UnenrollStudentFromCourse(int studentId, string courseCode)
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.ExecuteAsync(
            "DELETE FROM enrolled_courses WHERE student_id = @StudentId AND course_code = @CourseCode",
            new { StudentId = studentId, CourseCode = courseCode }
        );
    }
}