using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
namespace Quiz_app.Classes
{
    [FirestoreData]
    public class Data_DapAn
    {
       
        [FirestoreProperty]
        public string Cauhoi { get; set; }
        [FirestoreProperty]
        public string DA1 { get; set; }
        [FirestoreProperty]
        public string DA2 { get; set; }
        [FirestoreProperty]
        public string DA3 { get; set; }
        [FirestoreProperty]
        public string DA4 { get; set; }
        [FirestoreProperty]
        public string DADung { get; set; }
        [FirestoreProperty]
        public string AnhMinhHoa { get; set; }
    }
}
