using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace CSCI213___Assignment_5.Models {
    public class User {
        public User(int id, string name, string email, string password) {
            UserID = id;
            UserName = name;
            UserEmail = email;
            UserPassword = password;
        }

        public int UserID { get;  init; } 
        public string UserName { get;  set;} 
        public string UserEmail { get;  set;} 
        public string UserPassword { get;  set;}

        /*public bool login(string email,  string password) { }

        public void logout() { }

        public void updatePaymentInfor() { }*/

        public override string ToString() => $"User: {UserEmail} (ID: {UserID})";
    }
}
