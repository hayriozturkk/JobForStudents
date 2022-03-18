namespace JobForStudents
{

    public interface IStudentRepository
    {
        Task<Student> CreateStudent(Student Student);
        Task<Student> DeleteStudent(int id);
        Task<List<Student>> GetAllStudent();
        Task<Student> FindStudentById(int id);
        Task<Student> StudentEdit(Student Student);
        Task<Student> FindStudentByName(string StudentName);
        Task<List<Student>> GetStudentsByEducation(int EducationId);
        Task<List<Student>> GetStudentsByGender(int GenderId);
        Task<List<Student>> GetStudentsByEducationTour(int EducationTourId);
        Task<List<Student>> GetStudentsByCity(string CityName);
        Task<List<Student>> GetStudentsByDistrict(string DistrictName);
        Task<List<Student>> GetStudentsBySchool (string SchoolName);
        Task<List<Student>> GetStudentsByBirthDate (DateTime MaxBirthDate, DateTime MinBirthDate);
        



    }
}