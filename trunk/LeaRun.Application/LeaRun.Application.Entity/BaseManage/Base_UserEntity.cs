using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.BaseManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2016-07-26 22:35
    /// 描 述：用户信息表
    /// </summary>
    public class Base_UserEntity : BaseEntity
    {
        #region 实体成员
        /// <summary>
        /// 用户主键
        /// </summary>
        /// <returns></returns>
        public string UserId { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>
        /// <returns></returns>
        public string EnCode { get; set; }
        /// <summary>
        /// 登录账户
        /// </summary>
        /// <returns></returns>
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        /// <returns></returns>
        public string Password { get; set; }
        /// <summary>
        /// 密码秘钥
        /// </summary>
        /// <returns></returns>
        public string Secretkey { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        /// <returns></returns>
        public string RealName { get; set; }
        /// <summary>
        /// 呢称
        /// </summary>
        /// <returns></returns>
        public string NickName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        /// <returns></returns>
        public string HeadIcon { get; set; }
        /// <summary>
        /// 快速查询
        /// </summary>
        /// <returns></returns>
        public string QuickQuery { get; set; }
        /// <summary>
        /// 简拼
        /// </summary>
        /// <returns></returns>
        public string SimpleSpelling { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        /// <returns></returns>
        public int? Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        /// <returns></returns>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        /// <returns></returns>
        public string Mobile { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        /// <returns></returns>
        public string Telephone { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        /// <returns></returns>
        public string Email { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        /// <returns></returns>
        public string OICQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        /// <returns></returns>
        public string WeChat { get; set; }
        /// <summary>
        /// MSN
        /// </summary>
        /// <returns></returns>
        public string MSN { get; set; }
        /// <summary>
        /// 主管主键
        /// </summary>
        /// <returns></returns>
        public string ManagerId { get; set; }
        /// <summary>
        /// 主管
        /// </summary>
        /// <returns></returns>
        public string Manager { get; set; }
        /// <summary>
        /// 机构主键
        /// </summary>
        /// <returns></returns>
        public string OrganizeId { get; set; }
        /// <summary>
        /// 部门主键
        /// </summary>
        /// <returns></returns>
        public string DepartmentId { get; set; }
        /// <summary>
        /// 角色主键
        /// </summary>
        /// <returns></returns>
        public string RoleId { get; set; }
        /// <summary>
        /// 岗位主键
        /// </summary>
        /// <returns></returns>
        public string DutyId { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        /// <returns></returns>
        public string DutyName { get; set; }
        /// <summary>
        /// 职位主键
        /// </summary>
        /// <returns></returns>
        public string PostId { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        /// <returns></returns>
        public string PostName { get; set; }
        /// <summary>
        /// 工作组主键
        /// </summary>
        /// <returns></returns>
        public string WorkGroupId { get; set; }
        /// <summary>
        /// 安全级别
        /// </summary>
        /// <returns></returns>
        public int? SecurityLevel { get; set; }
        /// <summary>
        /// 在线状态
        /// </summary>
        /// <returns></returns>
        public int? UserOnLine { get; set; }
        /// <summary>
        /// 单点登录标识
        /// </summary>
        /// <returns></returns>
        public int? OpenId { get; set; }
        /// <summary>
        /// 密码提示问题
        /// </summary>
        /// <returns></returns>
        public string Question { get; set; }
        /// <summary>
        /// 密码提示答案
        /// </summary>
        /// <returns></returns>
        public string AnswerQuestion { get; set; }
        /// <summary>
        /// 允许多用户同时登录
        /// </summary>
        /// <returns></returns>
        public int? CheckOnLine { get; set; }
        /// <summary>
        /// 允许登录时间开始
        /// </summary>
        /// <returns></returns>
        public DateTime? AllowStartTime { get; set; }
        /// <summary>
        /// 允许登录时间结束
        /// </summary>
        /// <returns></returns>
        public DateTime? AllowEndTime { get; set; }
        /// <summary>
        /// 暂停用户开始日期
        /// </summary>
        /// <returns></returns>
        public DateTime? LockStartDate { get; set; }
        /// <summary>
        /// 暂停用户结束日期
        /// </summary>
        /// <returns></returns>
        public DateTime? LockEndDate { get; set; }
        /// <summary>
        /// 第一次访问时间
        /// </summary>
        /// <returns></returns>
        public DateTime? FirstVisit { get; set; }
        /// <summary>
        /// 上一次访问时间
        /// </summary>
        /// <returns></returns>
        public DateTime? PreviousVisit { get; set; }
        /// <summary>
        /// 最后访问时间
        /// </summary>
        /// <returns></returns>
        public DateTime? LastVisit { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        /// <returns></returns>
        public int? LogOnCount { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        /// <returns></returns>
        public int? SortCode { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        /// <returns></returns>
        public int? DeleteMark { get; set; }
        /// <summary>
        /// 有效标志
        /// </summary>
        /// <returns></returns>
        public int? EnabledMark { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        /// <returns></returns>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        /// <returns></returns>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>
        /// <returns></returns>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
        public string ModifyUserName { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            this.UserId = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
            this.CreateUserId = OperatorProvider.Provider.Current().UserId;
            this.CreateUserName = OperatorProvider.Provider.Current().UserName;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.UserId = keyValue;
            this.ModifyDate = DateTime.Now;
            this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }
        #endregion
    }
}