using FluentValidation;
using JobForStudents;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Account>>>> GetAllAccount()
    {
        return await _accountService.GetAllAccount();
    }


    [HttpGet("GetAccountByEmail")]
    public async Task<ActionResult<ServiceResponse<Account>>> GetAccountByEmail(string email)
    {
        return await _accountService.GetAccountByEmail(email);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Account>>> CreateAccount(Account account)
    {
        return await _accountService.CreateAccount(account);
    }

    [HttpPut("UpdateAccount")]
    public async Task<ActionResult<ServiceResponse<Account>>> UpdateAccountByEmail(Account account)
    {
        return await _accountService.AccountEdit(account);

    }


    [HttpPut("UpdateAccountPassword")]
    public async Task<ActionResult<ServiceResponse<Account>>> UpdateAccountPassword(Account account, string OldPassword)
    {
        return await _accountService.UpdateAccountPassword(account, OldPassword);
    }


    
    [HttpPut("Visibility")]
    public async Task<ActionResult<ServiceResponse<Account>>> ChangeVisibilityOfAccount(int id)
    {
        return await _accountService.ChangeVisibilityOfAccount(id);
    }
    [HttpPut("Block")]
    public async Task<ActionResult<ServiceResponse<Account>>> BlockAccount(int id)
    {
        return await _accountService.BlockAccount(id);
    }
    [HttpPut("Role")]
    public async Task<ActionResult<ServiceResponse<Account>>> ChangeRoleOfAccount(Account account)
    {
        return await _accountService.ChangeRoleOfAccount(account);
    }
}






