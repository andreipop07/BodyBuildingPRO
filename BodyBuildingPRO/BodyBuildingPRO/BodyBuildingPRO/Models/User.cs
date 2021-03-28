using System;
using System.Collections.Generic;
using System.Text;

namespace BodyBuildingPRO.Models
{
    class User
    {
        private string userName;
        private string userPassword;
        private string userEmail;
        private string userPhoneNumber;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPhoneNumber { get => userPhoneNumber; set => userPhoneNumber = value; }
    }
}
