using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Pharmacy.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Data
{
    public class UserManagement
    {
        private IHttpContextAccessor _httpContextAccessor;
        private PharmacyContext _contex;
        private SignInManager<IdentityUser> SignInManager;
        private UserManager<IdentityUser> UserManager;
        public UserManagement(IHttpContextAccessor httpContextAccessor, PharmacyContext context,
            SignInManager<IdentityUser> _SignInManager, UserManager<IdentityUser> _UserManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _contex = context;
            SignInManager = _SignInManager;
            UserManager = _UserManager;
        }
        public string GetStaffName()
        {
            string name = string.Empty;
            var person = _contex.ViewUserManagements.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.StaffName;
            }
            return name;
        }
        public string GetStaffId()
        {
            string name = string.Empty;
            var person = _contex.ViewUserManagements.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.StaffId;
            }
            return name;
        }
        public string GetStaffEmail()
        {
            string name = string.Empty;
            var person = _contex.ViewUserManagements.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.Email;
            }
            return name;
        }
        public string GetStaffNumber()
        {
            string name = string.Empty;
            var person = _contex.ViewUserManagements.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.Phone;
            }
            return name;
        }
        public bool IsSignedIn()
        {
            return SignInManager.IsSignedIn(_httpContextAccessor.HttpContext.User);
        }
        public async Task<bool> IsInRole(string UserRole)
        {
            var user = await UserManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            //var a =await UserManager.IsInRoleAsync(user, UserRole);
            return await UserManager.IsInRoleAsync(user, UserRole);
        }
    }
}
