using System;
using System.Collections.Generic;
using System.Text;

namespace AuthoritySystem.Model.Entity.DbModel
{
    /// <summary>
    /// 角色菜单
    /// </summary>
    public class TB_RoleMenu : BaseEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleID { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        public Guid MenuID { get; set; }
    }
}
