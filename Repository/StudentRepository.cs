using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class StudentRepository : IStudentRepository
    {
        DBContext _DbContext;

        public StudentRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Student> CreateStudent(Student Student)
        {
            await _DbContext.Set<Student>().AddAsync(Student);
            await _DbContext.SaveChangesAsync();
            return Student;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            var deletedStudent = await _DbContext.Set<Student>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Student>().Remove(deletedStudent);
            _DbContext.SaveChangesAsync();
            return deletedStudent;
        }

        public async Task<Student> FindStudentById(int id)
        {
            return await _DbContext.Set<Student>().FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await _DbContext.Set<Student>().ToListAsync();

        }
        public async Task<Student> StudentEdit(Student Student)
        {
            _DbContext.Set<Student>().Update(Student);
            _DbContext.SaveChangesAsync();
            return Student;
        }

        public async Task<Student> FindStudentByName(string StudentName)
        {
            return await _DbContext.Set<Student>().FirstOrDefaultAsync(p => p.Name == StudentName);
        }

        public async Task<List<Student>> GetStudentsByCity(string CityName)
        {
            return await _DbContext.Set<Student>().Where(p => p.Address.City.Name == CityName).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByDistrict(string DistrictName)
        {
            return await _DbContext.Set<Student>().Where(p => p.Address.District.Name == DistrictName).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByEducation(int EducationId)
        {
            return await _DbContext.Set<Student>().Where(p => ((int)p.Education) == EducationId).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByGender(int GenderId)
        {
            return await _DbContext.Set<Student>().Where(p => ((int)p.Gender) == GenderId).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByEducationTour(int EducationTourId)
        {
            return await _DbContext.Set<Student>().Where(p => ((int)p.EducationTour) == EducationTourId).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsBySchool(string SchoolName)
        {
            return await _DbContext.Set<Student>().Where(p => p.School.Name == SchoolName).ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByBirthDate(DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            return await _DbContext.Set<Student>().Where(p => p.BirthDate >= MinBirthDate && p.BirthDate <= MaxBirthDate).ToListAsync();

        }
    }



}


