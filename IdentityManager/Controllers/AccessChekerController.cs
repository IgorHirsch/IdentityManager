using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
    [Authorize]
    public class AccessCheckerController : Controller
    {
        //Anyone can access this
        [AllowAnonymous]
        public IActionResult AllAccess()
        {
            return View();
        }


        //Anyone that has logged in can access
        public IActionResult AuthorizedAccess()
        {
            return View();
        }


        //account with role of user or admin can access
        [Authorize(Roles = $"{SD.Admin},{SD.User}")]
        public IActionResult UserORAdminRoleAccess()
        {
            return View();
        }

        [Authorize(Policy = "AdminAndUser")]
        //account with role of user or admin can access
        public IActionResult UserANDAdminRoleAccess()
        {
            return View();
        }


        //account with role of admin can access
        [Authorize(Policy = "Admin")]
        public IActionResult AdminRoleAccess()
        {
            return View();
        }

        //account with admin role and create Claim can access
        [Authorize(Policy = "AdminRole_CreateClaim")]
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }

        //account with admin role and (create & Edit & Delete) Claim can access (AND NOT OR)
        [Authorize(Policy = "AdminRole_CreateEditDeleteClaim")]
        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }

        [Authorize(Policy = "AdminRole_CreateEditDeleteClaim_ORSuperAdminRole")]
        //account with admin role and (create & Edit & Delete) Claim can access (AND NOT OR)
        public IActionResult Admin_Create_Edit_DeleteAccess_OR_SuperAdminRole()
        {
            return View();
        }
        [Authorize(Policy = "AdminWithMoreThan1000Days")]
        public IActionResult OnlyIgor()
        {
            return View();
        }
        [Authorize(Policy = "FirstNameAuth")]
        public IActionResult FirstNameAuth()
        {
            return View();
        }
    }
}
