﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQChannelFramework.Models.Forum
{
    /// <summary>
    /// 富文本 - 段落结构
    /// </summary>
    public class Paragraph
    {
        /// <summary>
        /// 元素列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("elem")]
        public Elem Elem { get; set; }

        /// <summary>
        /// 段落属性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("props")]
        public ParagraphProps Props { get; set; }
    }
}
