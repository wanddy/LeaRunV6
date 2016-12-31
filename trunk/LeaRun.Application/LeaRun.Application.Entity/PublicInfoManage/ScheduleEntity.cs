using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.PublicInfoManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-04-25 10:45
    /// �� �����ճ̹���
    /// </summary>
    public class ScheduleEntity : BaseEntity
    {
        #region ʵ���Ա
        /// <summary>
        /// �ճ�����
        /// </summary>
        /// <returns></returns>
        public string ScheduleId { get; set; }
        /// <summary>
        /// �ճ�����
        /// </summary>
        /// <returns></returns>
        public string ScheduleName { get; set; }
        /// <summary>
        /// �ճ�����
        /// </summary>
        /// <returns></returns>
        public string ScheduleContent { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        /// <returns></returns>
        public string Category { get; set; }
        /// <summary>
        /// ��ʼ����
        /// </summary>
        /// <returns></returns>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        /// <returns></returns>
        public string StartTime { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        /// <returns></returns>
        public string EndTime { get; set; }
        /// <summary>
        /// ��ǰ����
        /// </summary>
        /// <returns></returns>
        public int? Early { get; set; }
        /// <summary>
        /// �ʼ�����
        /// </summary>
        /// <returns></returns>
        public int? IsMailAlert { get; set; }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        /// <returns></returns>
        public int? IsMobileAlert { get; set; }
        /// <summary>
        /// ΢������
        /// </summary>
        /// <returns></returns>
        public int? IsWeChatAlert { get; set; }
        /// <summary>
        /// �ճ�״̬
        /// </summary>
        /// <returns></returns>
        public int? ScheduleState { get; set; }
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
            this.ScheduleId = Guid.NewGuid().ToString();
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
            this.ScheduleId = keyValue;
            this.ModifyDate = DateTime.Now;
            this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }
        #endregion
    }
}