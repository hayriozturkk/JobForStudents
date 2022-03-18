namespace JobForStudents
{

    public interface IStudentService
    {
        Task<ServiceResponse<Student>> CreateStudent(Student Student);
        Task<ServiceResponse<Student>> DeleteStudent(int id);
        Task<ServiceResponse<List<Student>>> GetAllStudent();
        Task<ServiceResponse<Student>> StudentEdit(Student Student);
        Task<ServiceResponse<Student>> FindStudentByName(string StudentName);
        Task<ServiceResponse<List<Student>>> GetStudentsByEducation(int EducationId);
        Task<ServiceResponse<List<Student>>> GetStudentsByGender(int GenderId);
        Task<ServiceResponse<List<Student>>> GetStudentsByEducationTour(int EducationTourId);
        Task<ServiceResponse<List<Student>>> GetStudentsByCity(string CityName);
        Task<ServiceResponse<List<Student>>> GetStudentsByDistrict(string DistrictName);
        Task<ServiceResponse<List<Student>>> GetStudentsBySchool (string SchoolName);
        Task<ServiceResponse<List<Student>>> GetStudentsByBirthDate (DateTime MaxBirthDate,DateTime MinBirthDate);
        




    }
}