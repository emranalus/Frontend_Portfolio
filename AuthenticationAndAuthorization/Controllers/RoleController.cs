using AuthenticationAndAuthorization.Models.DTOs;
using AuthenticationAndAuthorization.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(roleManager.Roles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(

            [Required(ErrorMessage = "Role name is a must!")]
            [MinLength(3, ErrorMessage = "MinLength is 3!")]
            string name
            )
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(name));

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

            return View(name);
        }

        public async Task<IActionResult> AssignedRole(string id)
        {
            IdentityRole identityRole = await roleManager.FindByIdAsync(id);
            List<AppUser> hasRole = new List<AppUser>();
            List<AppUser> hasNotRole = new List<AppUser>();

            foreach (AppUser user in userManager.Users)
            {

                bool result = await userManager.IsInRoleAsync(user, identityRole.Name);

                if (result)
                {
                    hasRole.Add(user);
                }
                else
                {
                    hasNotRole.Add(user);
                }

            }

            AssignedRoleDTO assignedRoleDTO = new AssignedRoleDTO
            {
                Role = identityRole,
                HasRole = hasRole,
                HasNotRole = hasNotRole,
                RoleName = identityRole.Name
            };

            return View(assignedRoleDTO);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignedRole(AssignedRoleDTO roleDTO)
        {
            IdentityResult result;
            string[] addIds = roleDTO.AddIds;
            string[] deleteIds = roleDTO.DeleteIds;

            if (addIds != null)
            {
                foreach (var userId in addIds)
                {
                    AppUser user = await userManager.FindByIdAsync(userId);
                    result = await userManager.AddToRoleAsync(user, roleDTO.RoleName);
                }
            }

            if (deleteIds != null)
            {
                foreach (var userId in deleteIds)
                {
                    AppUser user = await userManager.FindByIdAsync(userId);
                    result = await userManager.RemoveFromRoleAsync(user, roleDTO.RoleName);
                }
            }

            return RedirectToAction("Index");
        }

    }
}
