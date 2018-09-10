using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [Route("api/UserAccounts")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<UserAccount>> GetAll()
        {
                return UserList._userList;
        }

       
        [HttpPost]
        public ActionResult<List<UserAccount>> Create(UserAccount userAccount)
        {
            // userAccount = new UserAccount();
            DBUtils du = new DBUtils();
            UserList._userList.Add(userAccount);
            du.AddUser(userAccount);
            return UserList._userList;
        }
    }
}