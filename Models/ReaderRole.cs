
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 读者角色
    /// </summary>
    [Serializable]
    public class ReaderRole
    {

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int AllowDay { get; set; }

        public int AllowCounts { get; set; }

    }
}
