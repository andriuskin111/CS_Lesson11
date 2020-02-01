using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class UserRepoository
    {
        private List<User> _userList;

        public UserRepoository()
        {
            _userList = new List<User>();
            _userList.Add(new User(1, new Rights(0), "Vasia"));
            _userList.Add(new User(2, new Rights(0), "Katia"));
            _userList.Add(new User(3, new Rights(0), "Vova"));
            _userList.Add(new User(4, new Rights(0), "Kiril"));
            _userList.Add(new User(5, new Rights(0), "Antanas"));
        }

        public User Retrieve(int userId)
        {
            foreach (var user in _userList)
            {
                if(userId == user.UserId)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> Retrieve()
        {
            return _userList;
        }

        public void AddUser(int userId, string userName, int rightsId)
        {
            if (Retrieve(userId) != null)
            {
                return;
            }

            _userList.Add(new User(userId, new Rights(rightsId), userName));         
        }

        public void DeleteUser(int userId)
        {
            if(Retrieve(userId) == null)
            {
                return;
            }

            for (int i = 0; i < _userList.Count; i++)
            {
                if (userId == _userList.ElementAt(i).UserId)
                {
                    _userList.Remove(_userList.ElementAt(i));
                    break;
                }
            }
        }
    }
}
