using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.CustomerManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-04-20 11:23
    /// �� ��������֧��
    /// </summary>
    public class ExpensesEntity : BaseEntity
    {
        #region ʵ���Ա
        /// <summary>
        /// ֧������
        /// </summary>
        /// <returns></returns>
        public string ExpensesId { get; set; }
        /// <summary>
        /// ֧������
        /// </summary>
        /// <returns></returns>
        public DateTime? ExpensesDate { get; set; }
        /// <summary>
        /// ֧�����
        /// </summary>
        /// <returns></returns>
        public decimal? ExpensesPrice { get; set; }
        /// <summary>
        /// ֧���˻�
        /// </summary>
        /// <returns></returns>
        public string ExpensesAccount { get; set; }
        /// <summary>
        /// ֧������
        /// </summary>
        /// <returns></returns>
        public string ExpensesType { get; set; }
        /// <summary>
        /// ֧������1-��˾֧����2-���˵渶��
        /// </summary>
        /// <returns></returns>
        public int? ExpensesObject { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        /// <returns></returns>
        public string Managers { get; set; }
        /// <summary>
        /// ֧��ժҪ
        /// </summary>
        /// <returns></returns>
        public string ExpensesAbstract { get; set; }
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
            this.ExpensesId = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
            this.CreateUserId = OperatorProvider.Provider.Current().UserId;
            this.CreateUserName = OperatorProvider.Provider.Current().UserName;
            this.ExpensesObject = 1;
        }
        /// <summary>
        /// �༭����
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.ExpensesId = keyValue;
            this.ModifyDate = DateTime.Now;
            this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }
        #endregion
    }
}