﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.NetCore.Model.EntityModel
{
    public class Menu : EntityBase
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

 
        /// <summary>
        /// 页面路径
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public long? ParentId { get; set; } = 0;

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool IsHidden { get; set; } = false;

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 是否为按钮
        /// </summary>
        public bool IsButton { get; set; } = false;

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; } = 0;

        public ICollection<MenuRole> UserRoles { get; set; }
    }
}
