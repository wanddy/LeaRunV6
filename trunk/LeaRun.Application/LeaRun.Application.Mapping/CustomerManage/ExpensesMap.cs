using LeaRun.Application.Entity.CustomerManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.CustomerManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-04-20 11:23
    /// �� ��������֧��
    /// </summary>
    public class ExpensesMap : EntityTypeConfiguration<ExpensesEntity>
    {
        public ExpensesMap()
        {
            #region ������
            //��
            this.ToTable("Client_Expenses");
            //����
            this.HasKey(t => t.ExpensesId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}
