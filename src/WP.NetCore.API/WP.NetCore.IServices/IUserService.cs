﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WP.NetCore.Model;
using WP.NetCore.Model.Dto;
using WP.NetCore.Model.EntityModel;
using WP.NetCore.Model.ViewModel;

namespace WP.NetCore.IServices
{
    public interface IUserService:IBaseService<User>
    {

        Task AddUserAsync(User objUser, List<long> listRoles);

        Task<PageModel<UserViewModel>> GetUserListAsync(int pageIndex, int pageSize);
        Task EditUserAsync(User objUser, List<long> listRoles);
        Task<User> CheckUserAsync(string userName, string passWord);

    }
}
