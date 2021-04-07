using System;
using System.Threading.Tasks;
using FireAuth;
using FireAuth.Droid;
using BodyBuildingPRO.Interfaces;
using Xamarin.Forms;
using Firebase.Auth;

[assembly: Dependency(typeof(Auth))]
namespace FireAuth.Droid
{
    public class Auth : IAuth
    {
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return "";
            }
        }
    }
}