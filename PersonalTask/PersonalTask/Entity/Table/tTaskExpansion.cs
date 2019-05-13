using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonalTask.Entity
{
    /// <summary> 个人任务扩展表
    /// 
    /// </summary>
    [Table("tTaskExpansion")]
    class tTaskExpansion
    {
        /// <summary> 主键ID
        /// 
        /// </summary>
        [Key]
        public int TaskExpensionID { get; set; }

        /// <summary> 任务ID
        /// 
        /// </summary>
        public int TaskID { get; set; }

        /// <summary> 任务状态
        /// 
        /// </summary>
        public byte TaskStatus { get; set; }

        /// <summary> 计划完成时间        
        /// 
        /// </summary>
        public DateTime PlanFinishDate { get; set; }

        /// <summary> 提醒时间
        /// 
        /// </summary>
        public DateTime RemindTime { get; set; }


    }
}