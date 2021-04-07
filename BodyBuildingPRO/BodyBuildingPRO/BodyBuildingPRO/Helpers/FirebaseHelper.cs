using BodyBuildingPRO.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
namespace BodyBuildingPRO.Helpers
{
    class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://bodybuilding-f3671-default-rtdb.firebaseio.com/");

        public async Task<List<User>> GetAllPersons()
        {

            return (await firebase
              .Child("User")
              .OnceAsync<User>()).Select(item => new User
              {
                  Name = item.Object.Name,
                  Password = item.Object.Password
              }).ToList();
        }

        public async Task<User> GetPerson(string name)
        {
           
            var allPersons = await GetAllPersons();
            await firebase
              .Child("User")
              .OnceAsync<User>();
            return allPersons.Where(a => a.Name == name).FirstOrDefault();
        }
    }
}
