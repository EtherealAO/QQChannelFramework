﻿using System;
namespace QQChannelFramework.Exceptions
{
    public class MissingAccessInfoException : Exception
    {
        public MissingAccessInfoException() : base("OpenApi信息未填写完整")
        {
        }
    }
}

