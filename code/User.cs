using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allhlepidrash
{
    public class User
    {
        public Boolean isEmployee;

        public String gender;

        public User(string type) {
            if (type == "employee") {
                isEmployee = true;
            }
            else if (type == "customer") {
                isEmployee = false;
            }

            gender = "male";
        }

        public List<String> employee_get_new_messages()
        {
            List<String> names_of_chats = new List<String>();
            names_of_chats.Add("Γιώργος Σδρόλιας");
            names_of_chats.Add("Μάνος Κόμπας");
            names_of_chats.Add("Ανδρονίκη Ελευθερίου");


            return names_of_chats;
        }

        public List<List<String>> get_conversations(String person)
        {
            List<List<String>> conversation = new List<List<String>>();

            List<string> temp = new List<string>();
            temp.Add("customer");
            temp.Add("Καλησπέρα. Σας στέλνω αυτό το μήνυμα για να σας ρωτήσω πότε θα έρθει η παραγγελία μου");
            conversation.Add(temp);

            temp = new List<string>();
            temp.Add("employee");
            temp.Add("Καλησπέρα. Σε 5 λεπτά θα είναι έτοιμη!");
            conversation.Add(temp);

            temp = new List<string>();
            temp.Add("customer");
            temp.Add("Καντε λιγο πιο γρήγορα!");
            conversation.Add(temp);

            temp = new List<string>();
            temp.Add("employee");
            temp.Add("Καλησπέρα. Σε 5 λεπτά θα είναι έτοιμη! Προσπαθούμε να κάνουμε το καλύτερο για τους πελάτες μας. Ελπίζουμε να απολαμβάνετε την διαμονή σας εδώ!");
            conversation.Add(temp);


            return conversation;
        }

    }
}
