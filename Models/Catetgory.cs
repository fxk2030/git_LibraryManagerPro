﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 图书分类
    /// </summary>
    [Serializable]
    public class Catetgory
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
