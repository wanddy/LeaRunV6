using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-26 22:23
    /// �� ���������ֵ�����
    /// </summary>
    public class Base_DataItemMap : EntityTypeConfiguration<Base_DataItemEntity>
    {
        public Base_DataItemMap()
        {
            #region ������
            //��
            this.ToTable("Base_DataItem");
            //����
            this.HasKey(t => t.ItemId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}
