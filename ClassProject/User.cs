using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class User
    {
        public string name = "";
        private string surname = "";

        public string Username { get; set; }
        public string Email { get; set; }

        DateTime birthdate;

        public User()
        {
            Username = "Default Username";
            Email = "Default Email";
        }
        public User(string istifadeciAdi)
        {
            Username = istifadeciAdi;
            Email = "Default Email";
        }

        public User(string istifadeciAdi, string elektronPoctUnvani)
        {
            Console.WriteLine("Constructor worked");
            Username = istifadeciAdi;
            Email = elektronPoctUnvani;
        }

        public string GetUserDetails(string name, string surname)
        {
            string output = $"{name} {surname} - {Email}";
            return output;
        }

    }
}
