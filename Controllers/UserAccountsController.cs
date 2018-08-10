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
            //List<UserAccount> acc=new  List<UserAccount>();
            //     acc.Add(new UserAccount{Id="1",Name="Rabi"});
         
                return UserList._userList;
        }

       
        [HttpPost]
        public ActionResult<List<UserAccount>> Create(UserAccount userAccount) //IActionResult
        {
            UserList._userList.Add(new UserAccount { Id = "1", Name = userAccount.Name });
            return   UserList._userList;
            // return RedirectToActionPermanent("GetAll");
        }
    }
}