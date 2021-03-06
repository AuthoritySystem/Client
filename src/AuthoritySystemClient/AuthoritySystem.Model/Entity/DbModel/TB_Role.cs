using System;
using System.Collections.Generic;
using System.Text;

namespace AuthoritySystem.Model.Entity.DbModel
{
    /// <summary>
    /// 角色实体
    /// </summary>
    public class TB_Role : BaseEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
    }
}
