﻿using System;

namespace LeaRun.Application.Entity.MessageManage
{
	/// <summary>
    /// 消息群组表
	/// <author>
    ///		<name>she</name>
    ///		<date>2015.08.01 14:00</date>
    /// </author>
    /// </summary>
    public class IMGroupEntity : BaseEntity
	{
		#region 获取/设置 字段值
      	/// <summary>
		/// 群组主键
        /// </summary>		
        public string GroupId { get; set; }    
		/// <summary>
		/// 群组名
        /// </summary>		
        public string FullName { get; set; }    
		/// <summary>
		/// 创建时间
        /// </summary>		
        public DateTime? CreateDate { get; set; }    
		/// <summary>
		/// 创建用户主键
        /// </summary>		
        public string CreateUserId { get; set; }    
		/// <summary>
		/// 创建用户
        /// </summary>		
        public string CreateUserName { get; set; }    
		   		#endregion
   		
   		#region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            this.GroupId = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.GroupId = keyValue;
        }
        #endregion
	}
}