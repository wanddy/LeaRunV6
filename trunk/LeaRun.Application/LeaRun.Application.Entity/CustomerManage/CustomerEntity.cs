using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.CustomerManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-03-14 09:47
    /// �� �����ͻ���Ϣ
    /// </summary>
    public class CustomerEntity : BaseEntity
    {
        #region ʵ���Ա
        /// <summary>
        /// �ͻ�����
        /// </summary>
        /// <returns></returns>
        public string CustomerId { get; set; }
        /// <summary>
        /// �ͻ����
        /// </summary>
        /// <returns></returns>
        public string EnCode { get; set; }
        /// <summary>
        /// �ͻ�����
        /// </summary>
        /// <returns></returns>
        public string FullName { get; set; }
        /// <summary>
        /// �ͻ����
        /// </summary>
        /// <returns></returns>
        public string ShortName { get; set; }
        /// <summary>
        /// �ͻ���ҵ
        /// </summary>
        /// <returns></returns>
        public string CustIndustryId { get; set; }
        /// <summary>
        /// �ͻ�����
        /// </summary>
        /// <returns></returns>
        public string CustTypeId { get; set; }
        /// <summary>
        /// �ͻ�����
        /// </summary>
        /// <returns></returns>
        public string CustLevelId { get; set; }
        /// <summary>
        /// �ͻ��̶�
        /// </summary>
        /// <returns></returns>
        public string CustDegreeId { get; set; }
        /// <summary>
        /// ����ʡ��
        /// </summary>
        /// <returns></returns>
        public string Province { get; set; }
        /// <summary>
        /// ���ڳ���
        /// </summary>
        /// <returns></returns>
        public string City { get; set; }
        /// <summary>
        /// ��ϵ��
        /// </summary>
        /// <returns></returns>
        public string Contact { get; set; }
        /// <summary>
        /// �ֻ�
        /// </summary>
        /// <returns></returns>
        public string Mobile { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        /// <returns></returns>
        public string Tel { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        public string Fax { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        /// <returns></returns>
        public string QQ { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <returns></returns>
        public string Email { get; set; }
        /// <summary>
        /// ΢��
        /// </summary>
        /// <returns></returns>
        public string Wechat { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        public string Hobby { get; set; }
        /// <summary>
        /// ���˴���
        /// </summary>
        /// <returns></returns>
        public string LegalPerson { get; set; }
        /// <summary>
        /// ��˾��ַ
        /// </summary>
        /// <returns></returns>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// ��˾��վ
        /// </summary>
        /// <returns></returns>
        public string CompanySite { get; set; }
        /// <summary>
        /// ��˾���
        /// </summary>
        /// <returns></returns>
        public string CompanyDesc { get; set; }
        /// <summary>
        /// ������ԱId
        /// </summary>
        /// <returns></returns>
        public string TraceUserId { get; set; }
        /// <summary>
        /// ������Ա
        /// </summary>
        /// <returns></returns>
        public string TraceUserName { get; set; }
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
            this.CustomerId = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
            this.CreateUserId = OperatorProvider.Provider.Current().UserId;
            this.CreateUserName = OperatorProvider.Provider.Current().UserName;
            this.ModifyDate = DateTime.Now;
        }
        /// <summary>
        /// �༭����
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.CustomerId = keyValue;
            this.ModifyDate = DateTime.Now;
            this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }
        #endregion
    }
}