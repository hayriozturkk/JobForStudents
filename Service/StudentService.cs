
namespace JobForStudents
{
    public class StudentService : IStudentService
    {
        private StudentRepository _StudentRepository;
        public StudentService()
        {
            _StudentRepository = new StudentRepository();
        }

        public async Task<ServiceResponse<Student>> CreateStudent(Student Student)
        {
            ServiceResponse<Student> response = new ServiceResponse<Student>();
            var FromRepositoryStudent = await _StudentRepository.FindStudentById(Student.Id);
            if (FromRepositoryStudent == null)
            {
                await _StudentRepository.CreateStudent(Student);
                response.ResponseCode = ResponseCodeEnum.CreateStudentOperationSuccess;
                response.Data = Student;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateStudentOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Student>> DeleteStudent(int id)
        {
            ServiceResponse<Student> response = new ServiceResponse<Student>();
            var FromRepositoryStudent = await _StudentRepository.FindStudentById(id);
            if (FromRepositoryStudent != null)
            {
                await _StudentRepository.DeleteStudent(id);
                response.ResponseCode = ResponseCodeEnum.DeleteStudentOperationSuccess;
                response.Data = FromRepositoryStudent;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteStudentOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetAllStudent()
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            List<Student> IncomingFromRepository = await _StudentRepository.GetAllStudent();
            if(IncomingFromRepository.Count != 0)
            {
                response.Data = await _StudentRepository.GetAllStudent();
                response.ResponseCode = ResponseCodeEnum.GetAllStudentOperationSuccess;
                return response;
            }
            else 
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllStudentOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Student>> StudentEdit(Student Student)
        {
            ServiceResponse<Student> response = new ServiceResponse<Student>();
            var editedStudent = _StudentRepository.StudentEdit(Student);

            if (editedStudent != null)
            {

                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedStudent;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.StudentEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Student>> FindStudentByName(string StudentName)
        {
            ServiceResponse<Student> response = new ServiceResponse<Student>();
            if (await GetAllStudent() != null && StudentName.Length >= 3)
            {
                Student IncomingFromRepository = await _StudentRepository.FindStudentByName(StudentName);
                if ( IncomingFromRepository != null)
                {
                    response.Data = await _StudentRepository.FindStudentByName(StudentName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.FindStudentByNameOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.FindStudentByNameRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByCity(string CityName)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && CityName.Length >= 3)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByCity(CityName);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsByCity(CityName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByCityOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByCityRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByDistrict(string DistrictName)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && DistrictName.Length >= 3)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByDistrict(DistrictName);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsByDistrict(DistrictName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByDistrictOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByDistrictRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByEducation(int EducationId)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && EducationId != null)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByEducation(EducationId);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsByEducation(EducationId);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByEducationOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByEducationRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByEducationTour(int EducationTourId)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && EducationTourId != null)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByEducationTour(EducationTourId);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsByEducationTour(EducationTourId);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByEducationTourOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByEducationTourRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByGender(int GenderId)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && GenderId != null)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByGender(GenderId);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsByGender(GenderId);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByGenderOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByGenderRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsBySchool(string SchoolName)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && SchoolName.Length >= 3)
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsBySchool(SchoolName);
                if ( IncomingFromRepository.Count != 0)
                {
                    response.Data = await _StudentRepository.GetStudentsBySchool(SchoolName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsBySchoolOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsBySchoolRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Student>>> GetStudentsByBirthDate(DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            ServiceResponse<List<Student>> response = new ServiceResponse<List<Student>>();
            if (await GetAllStudent() != null && (MaxBirthDate != null || MinBirthDate != null))
            {
                List<Student> IncomingFromRepository = await _StudentRepository.GetStudentsByBirthDate(MaxBirthDate, MinBirthDate);
                if ( IncomingFromRepository.Count != 0 )
                {
                    response.Data = await _StudentRepository.GetStudentsByBirthDate(MaxBirthDate, MinBirthDate);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetStudentsByBirthDateOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetStudentsByBirthDateRequired;
                return response;
            }
        }
    }
}






