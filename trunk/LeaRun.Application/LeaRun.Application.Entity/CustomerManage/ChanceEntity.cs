using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.CustomerManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-03-12 10:50
    /// �� �����̻���Ϣ
    /// </summary>
    public class ChanceEntity : BaseEntity
    {
        #region ʵ���Ա
        /// <summary>
        /// �̻�����
        /// </summary>
        /// <returns></returns>
        public string ChanceId { get; set; }
        /// <summary>
        /// �̻����
        /// </summary>
        /// <returns></returns>
        public string EnCode { get; set; }
        /// <summary>
        /// �̻�����
        /// </summary>
        /// <returns></returns>
        public string FullName { get; set; }
        /// <summary>
        /// �̻����
        /// </summary>
        /// <returns></returns>
        public string ChanceTypeId { get; set; }
        /// <summary>
        /// �̻���Դ
        /// </summary>
        /// <returns></returns>
        public string SourceId { get; set; }
        /// <summary>
        /// �̻��׶�
        /// </summary>
        /// <returns></returns>
        public string StageId { get; set; }
        /// <summary>
        /// �ɹ���
        /// </summary>
        /// <returns></returns>
        public decimal? SuccessRate { get; set; }
        /// <summary>
        /// Ԥ�ƽ��
        /// </summary>
        /// <returns></returns>
        public decimal? Amount { get; set; }
        /// <summary>
        /// Ԥ������
        /// </summary>
        /// <returns></returns>
        public decimal? Profit { get; set; }
        /// <summary>
        /// ���۷���
        /// </summary>
        /// <returns></returns>
        public decimal? SaleCost { get; set; }
        /// <summary>
        /// Ԥ�Ƴɽ�ʱ��
        /// </summary>
        /// <returns></returns>
        public DateTime? DealDate { get; set; }
        /// <summary>
        /// ת���ͻ�
        /// </summary>
        /// <returns></returns>
        public int? IsToCustom { get; set; }
        /// <summary>
        /// ��˾����
        /// </summary>
        /// <returns></returns>
        public string CompanyName { get; set; }
        /// <summary>
        /// ��˾����
        /// </summary>
        /// <returns></returns>
        public string CompanyNatureId { get; set; }
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
        public string Contacts { get; set; }
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
        /// �̻�״̬���루0-���ϣ�
        /// </summary>
        /// <returns></returns>
        public int? ChanceState { get; set; }
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
            this.ChanceId = Guid.NewGuid().ToString();
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
            this.ChanceId = keyValue;
            this.ModifyDate = DateTime.Now;
            this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }
        #endregion
    }
}