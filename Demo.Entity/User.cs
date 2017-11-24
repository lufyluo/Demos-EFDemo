using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity.@base;

namespace Demo.Entity
{
    public class User:BaseEntity
    {
        public User()

        {

            this.Diaries = new List<Diary>();

            this.User_Roles = new List<User_Roles>();

        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public System.DateTime CreateDate { get; set; }

        public System.DateTime UpdateDate { get; set; }

        public int Status { get; set; }

        public virtual ICollection<Diary> Diaries { get; set; }

        public virtual ICollection<User_Roles> User_Roles { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }

    public class UserInfo : BaseEntity
    {
        public int UserId { get; set; }
    }

    public class User_Roles:BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }

    public class Diary : BaseEntity
    {
        public string Content { get; set; }
    }
}
