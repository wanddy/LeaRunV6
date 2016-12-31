using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.BaseManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-26 22:35
    /// �� �����û���Ϣ��
    /// </summary>
    public class Base_UserEntity : BaseEntity
    {
        #region ʵ���Ա
        /// <summary>
        /// �û�����
        /// </summary>
        /// <returns></returns>
        public string UserId { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        /// <returns></returns>
        public string EnCode { get; set; }
        /// <summary>
        /// ��¼�˻�
        /// </summary>
        /// <returns></returns>
        public string Account { get; set; }
        /// <summary>
        /// ��¼����
        /// </summary>
        /// <returns></returns>
        public string Password { get; set; }
        /// <summary>
        /// ������Կ
        /// </summary>
        /// <returns></returns>
        public string Secretkey { get; set; }
        /// <summary>
        /// ��ʵ����
        /// </summary>
        /// <returns></returns>
        public string RealName { get; set; }
        /// <summary>
        /// �س�
        /// </summary>
        /// <returns></returns>
        public string NickName { get; set; }
        /// <summary>
        /// ͷ��
        /// </summary>
        /// <returns></returns>
        public string HeadIcon { get; set; }
        /// <summary>
        /// ���ٲ�ѯ
        /// </summary>
        /// <returns></returns>
        public string QuickQuery { get; set; }
        /// <summary>
        /// ��ƴ
        /// </summary>
        /// <returns></returns>
        public string SimpleSpelling { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        /// <returns></returns>
        public int? Gender { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// �ֻ�
        /// </summary>
        /// <returns></returns>
        public string Mobile { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        /// <returns></returns>
        public string Telephone { get; set; }
        /// <summary>
        /// �����ʼ�
        /// </summary>
        /// <returns></returns>
        public string Email { get; set; }
        /// <summary>
        /// QQ��
        /// </summary>
        /// <returns></returns>
        public string OICQ { get; set; }
        /// <summary>
        /// ΢�ź�
        /// </summary>
        /// <returns></returns>
        public string WeChat { get; set; }
        /// <summary>
        /// MSN
        /// </summary>
        /// <returns></returns>
        public string MSN { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string ManagerId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        public string Manager { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string OrganizeId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string DepartmentId { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        /// <returns></returns>
        public string RoleId { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        /// <returns></returns>
        public string DutyId { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        /// <returns></returns>
        public string DutyName { get; set; }
        /// <summary>
        /// ְλ����
        /// </summary>
        /// <returns></returns>
        public string PostId { get; set; }
        /// <summary>
        /// ְλ����
        /// </summary>
        /// <returns></returns>
        public string PostName { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        /// <returns></returns>
        public string WorkGroupId { get; set; }
        /// <summary>
        /// ��ȫ����
        /// </summary>
        /// <returns></returns>
        public int? SecurityLevel { get; set; }
        /// <summary>
        /// ����״̬
        /// </summary>
        /// <returns></returns>
        public int? UserOnLine { get; set; }
        /// <summary>
        /// �����¼��ʶ
        /// </summary>
        /// <returns></returns>
        public int? OpenId { get; set; }
        /// <summary>
        /// ������ʾ����
        /// </summary>
        /// <returns></returns>
        public string Question { get; set; }
        /// <summary>
        /// ������ʾ��
        /// </summary>
        /// <returns></returns>
        public string AnswerQuestion { get; set; }
        /// <summary>
        /// ������û�ͬʱ��¼
        /// </summary>
        /// <returns></returns>
        public int? CheckOnLine { get; set; }
        /// <summary>
        /// �����¼ʱ�俪ʼ
        /// </summary>
        /// <returns></returns>
        public DateTime? AllowStartTime { get; set; }
        /// <summary>
        /// �����¼ʱ�����
        /// </summary>
        /// <returns></returns>
        public DateTime? AllowEndTime { get; set; }
        /// <summary>
        /// ��ͣ�û���ʼ����
        /// </summary>
        /// <returns></returns>
        public DateTime? LockStartDate { get; set; }
        /// <summary>
        /// ��ͣ�û���������
        /// </summary>
        /// <returns></returns>
        public DateTime? LockEndDate { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        /// <returns></returns>
        public DateTime? FirstVisit { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        /// <returns></returns>
        public DateTime? PreviousVisit { get; set; }
        /// <summary>
        /// ������ʱ��
        /// </summary>
        /// <returns></returns>
        public DateTime? LastVisit { get; set; }
        /// <summary>
        /// ��¼����
        /// </summary>
        /// <returns></returns>
        public int? LogOnCount { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        /// <returns></returns>
        public int? SortCode { get; set; }
        /// <summary>
        /// ɾ�����
        /// </summary>
        /// <returns></returns>
        public int? DeleteMark { get; set; }
        /// <summary>
        /// ��Ч��־
        /// </summary>
        /// <returns></returns>
        public int? EnabledMark { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// �����û�����
        /// </summary>
        /// <returns></returns>
        public string CreateUserId { get; set; }
        /// <summary>
        /// �����û�
        /// </summary>
        /// <returns></returns>
        public string CreateUserName { get; set; }
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <returns></returns>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// �޸��û�����
        /// </summary>
        /// <returns></returns>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// �޸��û�
        /// </summary>
        /// <returns></returns>
        public string ModifyUserName { get; set; }
        #endregion

        #region ��չ����
        /// <summary>
        /// ��������
        /// </summary>
        public override void Create()
        {
            this.UserId = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
            this.CreateUserId = OperatorProvider.Provider.Current().UserId;
            this.CreateUserName = OperatorProvider.Provider.Current().UserName;
        }
        /// <summary>
        /// �༭����
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