using Microsoft.AspNetCore.Mvc;
namespace JobForStudents
{



    public class ResponseGeneratorHelper : ControllerBase
    {
        public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
        {
            switch (incomingResponse.ResponseCode)
            {
                case ResponseCodeEnum.Success:
                case ResponseCodeEnum.CreateDistrictOperationSuccess:
                case ResponseCodeEnum.GetAllDistrictsOperationSuccess:
                case ResponseCodeEnum.DeleteDistrictOperationSuccess:
                case ResponseCodeEnum.CreateCityOperationSuccess:
                case ResponseCodeEnum.DeleteCityOperationSuccess:
                case ResponseCodeEnum.GetAllCityOperationSuccess:
                case ResponseCodeEnum.CreateSchoolOperationSuccess:
                case ResponseCodeEnum.DeleteSchoolOperationSuccess:
                case ResponseCodeEnum.GetAllSchoolOperationSuccess:
                case ResponseCodeEnum.CreateStudentOperationSuccess:
                case ResponseCodeEnum.DeleteStudentOperationSuccess:
                case ResponseCodeEnum.GetAllStudentOperationSuccess:
                case ResponseCodeEnum.CreateEmployerOperationSuccess:
                case ResponseCodeEnum.DeleteEmployerOperationSuccess:
                case ResponseCodeEnum.GetAllEmployerOperationSuccess:
                case ResponseCodeEnum.CreateCompanyOperationSuccess:
                case ResponseCodeEnum.DeleteCompanyOperationSuccess:
                case ResponseCodeEnum.GetAllCompanyOperationSuccess:
                case ResponseCodeEnum.CreateCategoryOperationSuccess:
                case ResponseCodeEnum.DeleteCategoryOperationSuccess:
                case ResponseCodeEnum.GetAllCategoryOperationSuccess:
                case ResponseCodeEnum.CreateRoleOperationSuccess:
                case ResponseCodeEnum.DeleteRoleOperationSuccess:
                case ResponseCodeEnum.GetAllRoleOperationSuccess:
                case ResponseCodeEnum.CreateAccountOperationSuccess:
                case ResponseCodeEnum.DeleteAccountOperationSuccess:
                case ResponseCodeEnum.GetAllAccountOperationSuccess:
                

                    {
                        return Ok(incomingResponse);
                    }
                case ResponseCodeEnum.GetAllDistrictsOperationFail:
                case ResponseCodeEnum.GetAllCityOperationFail:
                case ResponseCodeEnum.GetAllSchoolOperationFail:
                case ResponseCodeEnum.GetAllStudentOperationFail:
                case ResponseCodeEnum.GetAllEmployerOperationFail:
                case ResponseCodeEnum.GetAllCompanyOperationFail:
                case ResponseCodeEnum.GetAllCategoryOperationFail:
                case ResponseCodeEnum.GetAllRoleOperationFail:
                case ResponseCodeEnum.GetAllAccountOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByCategoryOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByTitleOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByCityOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByDistrictOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByNameOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByWorkingTimeOperationFail:
                case ResponseCodeEnum.GetJobAdvertisementByCompanyNameOperationFail:
                case ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleOperationFail:
                case ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleRequired:
                case ResponseCodeEnum.GetCompanyByNameOperationFail:
                case ResponseCodeEnum.GetCategoryByNameOperationFail:
                case ResponseCodeEnum.GetAccountByRoleNametOperationFail:
                case ResponseCodeEnum.GetAccountByVisibltytOperationFail:
                case ResponseCodeEnum.GetStudentsByCityOperationFail:
                case ResponseCodeEnum.GetStudentsByDistrictOperationFail:
                case ResponseCodeEnum.GetStudentsByEducationOperationFail:
                case ResponseCodeEnum.GetStudentsByEducationTourOperationFail:
                case ResponseCodeEnum.GetStudentsByGenderOperationFail:
                case ResponseCodeEnum.GetStudentsBySchoolOperationFail:
                case ResponseCodeEnum.FindStudentByNameOperationFail:
                case ResponseCodeEnum.GetStudentsByBirthDateOperationFail:
                case ResponseCodeEnum.GetEmployerByGenderOperationFail:
                case ResponseCodeEnum.GetEmployersByBirthDateOperationFail:
                case ResponseCodeEnum.GetEmployerByNameOperationFail:
                case ResponseCodeEnum.GetEmployerCompanyOperationFail:
                case ResponseCodeEnum.GetSchoolsByDistrictOperationFail:
                case ResponseCodeEnum.GetSchoolsByCityOperationFail:
                case ResponseCodeEnum.GetSchoolByNameOperationFail: 

                    {
                        return NotFound(incomingResponse);
                    }
                case ResponseCodeEnum.CreateDistrictOperationFail:
                case ResponseCodeEnum.DeleteDistrictOperationFail:
                case ResponseCodeEnum.CreateCityOperationFail:
                case ResponseCodeEnum.DeleteCityOperationFail:
                case ResponseCodeEnum.CityEditOperationFail:
                case ResponseCodeEnum.CreateSchoolOperationFail:
                case ResponseCodeEnum.DeleteSchoolOperationFail:
                case ResponseCodeEnum.SchoolEditOperationFail:
                case ResponseCodeEnum.CreateStudentOperationFail:
                case ResponseCodeEnum.DeleteStudentOperationFail:
                case ResponseCodeEnum.StudentEditOperationFail:
                case ResponseCodeEnum.CreateEmployerOperationFail:
                case ResponseCodeEnum.DeleteEmployerOperationFail:
                case ResponseCodeEnum.EmployerEditOperationFail:
                case ResponseCodeEnum.CreateCompanyOperationFail:
                case ResponseCodeEnum.DeleteCompanyOperationFail:
                case ResponseCodeEnum.CompanyEditOperationFail:
                case ResponseCodeEnum.CreateCategoryOperationFail:
                case ResponseCodeEnum.DeleteCategoryOperationFail:
                case ResponseCodeEnum.CategoryEditOperationFail:
                case ResponseCodeEnum.CreateRoleOperationFail:
                case ResponseCodeEnum.DeleteRoleOperationFail:
                case ResponseCodeEnum.RoleEditOperationFail:
                case ResponseCodeEnum.CreateAccountOperationFail:
                case ResponseCodeEnum.DeleteAccountOperationFail:
                case ResponseCodeEnum.AccountEditOperationFail:
                
                
                    {
                        return NoContent();
                    }
                default:
                    {
                        return BadRequest(incomingResponse);
                    }
            }
        }
    }
}