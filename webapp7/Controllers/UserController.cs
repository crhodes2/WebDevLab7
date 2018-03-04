using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp3.Data.Entities;
using webapp3.Data;

namespace webapp3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(GetUser(id));
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var aUser = MapToUser(user);
                Save(aUser);
            }
            return RedirectToAction("List");
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var user = GetAllUsers();
            return View(user);
        }

        private void Save(User user)
        {
            var dbContext = new AppDbContext();
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        private IEnumerable<User> GetAllUsers()
        {
            var userList = new List<User>();
            var dbContext = new AppDbContext();
            var users = dbContext.Users;

            userList.Count();

            foreach (var user in users)
            {
                var usersList = MapToUser(user);
                userList.Add(usersList);
            }
            return userList;
        }

        private User GetUser(int id)
        {
            var dbContext = new AppDbContext();
            var user = dbContext.Users.Find(id);

            return MapToUser(user);
        }

        private void DeleteUser(int id)
        {
            var dbContext = new AppDbContext();
            var users = dbContext.Users;
            var user = users.SingleOrDefault(u => u.Id == id);

            if (user != null)
            {
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
        }

        public ActionResult Delete(int id)
        {
            DeleteUser(id);

            return RedirectToAction("List");
        }

        private User MapToUser(User user)
        {
            return new User
            { 
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleInitial = user.MiddleInitial,
                LastName = user.LastName,
                Email = user.Email,
                YearsInSchool = user.YearsInSchool,
                Biography = user.Biography
            };
        }

    }
}