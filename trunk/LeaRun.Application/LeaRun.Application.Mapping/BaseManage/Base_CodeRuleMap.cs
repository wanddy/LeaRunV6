using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-28 21:24
    /// �� ������Ź����
    /// </summary>
    public class Base_CodeRuleMap : EntityTypeConfiguration<Base_CodeRuleEntity>
    {
        public Base_CodeRuleMap()
        {
            #region ������
            //��
            this.ToTable("Base_CodeRule");
            //����
            this.HasKey(t => t.RuleId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}
