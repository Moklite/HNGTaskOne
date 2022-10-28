using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNGTaskOne.Models
{
    public class User
    {
        public string SlackUsername { get; set; }
        public bool Backend { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public User()
        {
        }

        public User(string slackUsername, bool backend, int age, string bio)
        {
            this.SlackUsername = slackUsername;
            this.Backend = backend;
            this.Age = age;
            this.Bio = bio;
        }
    }
}
