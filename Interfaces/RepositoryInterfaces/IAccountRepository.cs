namespace JobForStudents
{

    public interface IAccountRepository
    {
        Task<Account> CreateAccount(Account Account);
        Task<Account> DeleteAccount(int id);
        Task<List<Account>> GetAllAccount();
        Task<Account> FindAccountById(int id);
        Task<Account> AccountEdit(Account Account);
        Task<List<Account>> GetAccountByRoleName(string RoleName);
        Task<List<Account>> GetAccountByVisibility(string Visibility);
        Task<Account> GetAccountByEmail(string Email);
        Account FindAccountByEmailAndPassword(LoginDTO loginDTO);
        Account FindAccountByForJwt(int id);
        Task<Account> ChangeVisibilityOfAccount(Account account);
        Task<Account> BlockAccount(Account account);
        Task<Account> ChangeRoleOfAccount(Account account);
        Task<Account> UpdateAccountPassword(Account account);




    }
}