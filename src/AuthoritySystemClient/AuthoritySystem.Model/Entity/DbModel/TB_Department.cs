using System;
using System.Collections.Generic;
using System.Text;

namespace AuthoritySystem.Model.Entity.DbModel
{
    /// <summary>
    /// 部门实体
    /// </summary>
    public class TB_Department : BaseEntity
    {
        /// <summary>
        /// 上级部门ID
        /// </summary>
        public Guid? ParentID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
    }
}
