using E2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E2.ViewComponents
{
    [ViewComponent]
    public class UserViewComponent : ViewComponent
    {
        private readonly E2DbContext _e2DbContext;
        public UserViewComponent(E2DbContext e2DbContext)
        {
            _e2DbContext = e2DbContext;
        }

        public IViewComponentResult Invoke()
        {
            var Users = _e2DbContext.Users.ToList();
            return View(new SelectList(Users, "UserId", "UserName"));
            //return View(Users);
        }
    }
}
