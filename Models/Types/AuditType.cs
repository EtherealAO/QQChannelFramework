﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQChannelFramework.Models.Types
{
    /// <summary>
    /// 帖子审核类型
    /// </summary>
    public enum AuditType
    {
        /// <summary>
        /// 帖子
        /// </summary>
        PUBLISH_THREAD = 1,
        /// <summary>
        /// 评论
        /// </summary>
        PUBLISH_POST = 2,
        /// <summary>
        /// 回复
        /// </summary>
        PUBLISH_REPLY = 3
    }
}
