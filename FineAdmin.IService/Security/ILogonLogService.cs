﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineAdmin.Model;

namespace FineAdmin.IService
{
    public interface ILogonLogService : IBaseService<LogonLogModel>
    {
        /// <summary>
        /// 写入登录日志
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int WriteDbLog(LogonLogModel model);
    }
}
