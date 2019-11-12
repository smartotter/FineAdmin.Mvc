﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineAdmin.Common;
using FineAdmin.Model;

namespace FineAdmin.IService
{
    public interface IButtonService : IBaseService<ButtonModel>
    {
        /// <summary>
        /// 根据角色菜单获得按钮列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="moduleId"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        IEnumerable<ButtonModel> GetButtonListByRoleIdModuleId(int roleId, int moduleId, PositionEnum position);
    }
}
