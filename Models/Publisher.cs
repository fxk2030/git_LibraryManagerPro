﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 出版社实体类
    /// </summary>
    [Serializable]
    public class Publisher
    {

        public int PublisherId { get; set; }

        public string PublisherName { get; set; }

    }
}
