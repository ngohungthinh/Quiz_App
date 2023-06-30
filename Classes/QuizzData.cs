using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Signup.Classes
{
    [FirestoreData]
    public class QuizzData
    {
        [FirestoreProperty]
        public string DateTime { get; set; }
        [FirestoreProperty]
        public string ID { get; set; }
        [FirestoreProperty]
        public string Image { get; set; }

        [FirestoreProperty]
        public string Creator { get; set; }
        [FirestoreProperty]
        public string TenQuiz { get; set; }
    }
}
