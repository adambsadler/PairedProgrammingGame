using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfoRepository
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string FriendName { get; set; }
        public int Age { get; set; }

        public UserInfo() { }

        public UserInfo(string name, string city, string friendName, int age)
        {
            Name = name;
            City = city;
            FriendName = friendName;
            Age = age;
        }

    }
}
