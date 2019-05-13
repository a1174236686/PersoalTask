using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonalTask.Entity
{
    /// <summary> 任务表
    /// 
    /// </summary>
    [Table("tTask")]
    class tTask
    {
        /// <summary> 主键ID
        /// 
        /// </summary>
        [Key]
        public int TaskID { get; set; }

        /// <summary> 父任务ID
        /// 
        /// </summary>
        public int? ParentID { get; set; }

        /// <summary> 任务文本
        /// 
        /// </summary>
        public string TaskText { get; set; }

        /// <summary> 是否展开
        /// 
        /// </summary>
        public byte Expend { get; set; }

        /// <summary> 排序
        /// 
        /// </summary>
        public int SortNo { get; set; }

        /// <summary> 创建时间
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}