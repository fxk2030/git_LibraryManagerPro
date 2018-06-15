﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 借阅详细表
    /// </summary>
    [Serializable]
    public class BorrowDetail
    {
        public int BorrowDetailId { get; set; }

        public string BorrowId { get; set; }

        public int BookId { get; set; }

        public int BorrowCount { get; set; }

        public int NonReturnCount { get; set; }

        public int Expire { get; set; }

    }
}
