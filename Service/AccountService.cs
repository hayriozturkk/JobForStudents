
namespace JobForStudents
{
    public class AccountService : IAccountService
    {
        private AccountRepository _AccountRepository;
        public AccountService()
        {
            _AccountRepository = new AccountRepository();
        }

        public async Task<ServiceResponse<Account>> CreateAccount(Account Account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var IncomingAccount = await _AccountRepository.FindAccountById(Account.Id);
            if (IncomingAccount == null)
            {
                await _AccountRepository.CreateAccount(Account);
                response.ResponseCode = ResponseCodeEnum.CreateAccountOperationSuccess;
                response.Data = Account;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateAccountOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Account>> DeleteAccount(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var IncomingAccount = await _AccountRepository.FindAccountById(id);
            if (IncomingAccount != null)
            {
                await _AccountRepository.DeleteAccount(id);
                response.ResponseCode = ResponseCodeEnum.DeleteAccountOperationSuccess;
                response.Data = IncomingAccount;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteAccountOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Account>>> GetAllAccount()
        {
            ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();
            try
            {
                response.Data = await _AccountRepository.GetAllAccount();
                response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Account>>> GetAccountByRoleName(string RoleName)
        {
            ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();
            try
            {
                response.Data = await _AccountRepository.GetAccountByRoleName(RoleName);
                response.ResponseCode = ResponseCodeEnum.Success;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAccountByRoleNametOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Account>>> GetAccountByVisibility(string Visibility)
        {
            ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();
            if (Visibility != null && (Visibility == "Blocked" || Visibility == "UnBlocked"))
            {
                response.Data = await _AccountRepository.GetAccountByVisibility(Visibility);
                response.ResponseCode = ResponseCodeEnum.Success;
                return response;
            }
            else
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAccountByVisibltytOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Account>> AccountEdit(Account Account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var editedAccount = _AccountRepository.AccountEdit(Account);

            if (editedAccount != null)
            {

                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedAccount;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.AccountEditOperationFail;
                return response;
            }
        }
        async Task<ServiceResponse<Account>> IAccountService.GetAccountByEmail(string email)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var userfinderbyemail = await _AccountRepository.GetAccountByEmail(email);


            if (userfinderbyemail != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = userfinderbyemail;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAccountByEmailOperationFail;
                return response;
            }

        }
        async Task<ServiceResponse<Account>> IAccountService.BlockAccount(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();


            Account finder = await _AccountRepository.FindAccountById(id);

            try
            {

                if (finder != null)
                {
                    finder.IsBlocked = !finder.IsBlocked;

                    response.ResponseCode = ResponseCodeEnum.Success;
                    response.Data = await _AccountRepository.BlockAccount(finder);
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.AccountBlockOperationFail;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.ResponseCode = ResponseCodeEnum.AccountBlockOperationFail;
                return response;
            }
        }

        async Task<ServiceResponse<Account>> IAccountService.ChangeRoleOfAccount(Account account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();


            Account finder = await _AccountRepository.GetAccountByEmail(account.Email);
            try
            {

                if (finder != null)
                {
                    finder.RoleId = account.RoleId;

                    response.ResponseCode = ResponseCodeEnum.Success;
                    response.Data = await _AccountRepository.ChangeVisibilityOfAccount(finder);
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.OperationFail;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.ResponseCode = ResponseCodeEnum.OperationFail;
                return response;
            }



        }
        public async  Task<ServiceResponse<Account>> UpdateAccountPassword(Account account, string OldPassword)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            Account finder = await _AccountRepository.GetAccountByEmail(account.Email);

            if (finder != null && finder.Password == OldPassword)
            {
                finder.Password = account.Password;
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await _AccountRepository.AccountEdit(finder);
                return response;
            }

            else
            {
                response.ResponseCode = ResponseCodeEnum.UpdateAccountPasswordOperationFail;
                return response;
            }

        }


        async Task<ServiceResponse<Account>> IAccountService.ChangeVisibilityOfAccount(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();


            Account finder = await _AccountRepository.FindAccountById(id);

            try
            {

                if (finder != null)
                {
                    finder.Visibility = !finder.Visibility;

                    response.ResponseCode = ResponseCodeEnum.Success;
                    response.Data = await _AccountRepository.ChangeVisibilityOfAccount(finder);
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.ResponseCode = ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail;
                return response;
            }
        }
    }
}



