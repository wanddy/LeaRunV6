using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaRun.CodeGenerator.Model
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2016.1.15 9:54
    /// 描 述：表单字段信息
    /// </summary>
    public class FormFieldModel
    {
        /// <summary>
        /// 字段标识
        /// </summary>
        public string ControlId { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string ControlName { get; set; }
        /// <summary>
        /// 字段验证
        /// </summary>
        public string ControlValidator { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string ControlType { get; set; }
        /// <summary>
        /// 合并列
        /// </summary>
        public int? ControlColspan { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string ControlDefault { get; set; }
    }
}
