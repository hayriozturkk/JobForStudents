namespace JobForStudents
{

    public interface IAccountService
    {
        Task<ServiceResponse<Account>> CreateAccount(Account Account);
        Task<ServiceResponse<Account>> DeleteAccount(int id);
        Task<ServiceResponse<List<Account>>> GetAllAccount();
        Task<ServiceResponse<Account>> AccountEdit(Account Account);
        Task<ServiceResponse<List<Account>>> GetAccountByRoleName(string Name);
        Task<ServiceResponse<List<Account>>> GetAccountByVisibility(string Name);
        Task<ServiceResponse<Account>> UpdateAccountPassword(Account account,string OldPassword);
        Task<ServiceResponse<Account>> GetAccountByEmail(string email);
        Task<ServiceResponse<Account>> ChangeVisibilityOfAccount(int id);
        Task<ServiceResponse<Account>> BlockAccount(int id);
        Task<ServiceResponse<Account>> ChangeRoleOfAccount(Account account);




    }
}