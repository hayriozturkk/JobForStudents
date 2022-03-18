using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class AccountRepository : IAccountRepository
    {
        DBContext _DbContext;

        public AccountRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Account> CreateAccount(Account Account)
        {
            try
            {

                await _DbContext.Set<Account>().AddAsync(Account);
                await _DbContext.SaveChangesAsync();
                return Account;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Account> DeleteAccount(int id)
        {
            var deletedAccount = await _DbContext.Set<Account>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Account>().Remove(deletedAccount);
            _DbContext.SaveChangesAsync();
            return deletedAccount;

        }

        public async Task<Account> FindAccountById(int id)
        {
            try
            {
                return await _DbContext.Set<Account>().FirstOrDefaultAsync(c => c.Id == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<Account>> GetAllAccount()
        {
            try
            {
                return await _DbContext.Set<Account>().ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public async Task<Account> GetAccountByEmail(string email)
        {
            return await _DbContext.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
        }

        public async Task<List<Account>> GetAccountByRoleName(string RoleName)
        {
            try
            {
                return await _DbContext.Set<Account>().Where(c => c.Role.Name == RoleName).ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<Account>> GetAccountByVisibility(string Visibility)
        {
            try
            {
                return await _DbContext.Set<Account>().Where(c => c.Visibility.ToString() == Visibility).ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Account> AccountEdit(Account Account)
        {
            _DbContext.Set<Account>().Update(Account);
            _DbContext.SaveChangesAsync();

            return Account;
        }

        public Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
        {
            var accountFinded = (from x in _DbContext.Accounts
                                 where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                                 select x).FirstOrDefault();
            return accountFinded;
        }

        public Account FindAccountByForJwt(int id)
        {
            var accountByID = (from x in _DbContext.Accounts
                               where x.Id == id
                               select x).FirstOrDefault();
            return accountByID;
        }
        public async Task<Account> ChangeVisibilityOfAccount(Account account)
        {
            account.Visibility = !account.Visibility;
            _DbContext.Set<Account>().Update(account);
            _DbContext.SaveChangesAsync();
            return account;
        }
        public async Task<Account> UpdateAccountPassword(Account account)
    {

        _DbContext.Set<Account>().Update(account);
        _DbContext.SaveChangesAsync();
        return account;
    }

        public  async Task<Account> BlockAccount(Account account)
        {

            _DbContext.Set<Account>().Update(account);
            await _DbContext.SaveChangesAsync();
            return account;
        }

        public async Task<Account> ChangeRoleOfAccount(Account account)
        {
            _DbContext.Set<Account>().Update(account);
            _DbContext.SaveChangesAsync();
            return account;
        }

    }
}


