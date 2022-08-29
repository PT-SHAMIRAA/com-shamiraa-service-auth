using Com.Shamiraa.Service.Auth.Lib.Models;
using Com.Shamiraa.Service.Auth.Lib.Utilities.BaseInterface;
using Com.Shamiraa.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IRoleService : IBaseService<Role>
    {
        bool CheckDuplicate(int id, string code);
    }
}
