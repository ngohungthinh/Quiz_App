using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Signup.Classes
{
    [FirestoreData]
    public class UserData
    {
        [FirestoreProperty]
        public string Email { get; set; }    // property
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Avatar { get; set; }
    }
}
