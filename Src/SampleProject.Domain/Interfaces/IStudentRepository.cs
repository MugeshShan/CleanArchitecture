namespace SampleProject.Domain;

/// <summary>
/// Repository Interface for Student
/// </summary>
public interface IStudentRepository
{
    /// <summary>
    /// Get Student by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Student> GetByIdAsync(int id);

    /// <summary>
    /// Add Student
    /// </summary>
    /// <param name="student"></param>
    /// <returns></returns>
    Task AddSync(Student student);
}
