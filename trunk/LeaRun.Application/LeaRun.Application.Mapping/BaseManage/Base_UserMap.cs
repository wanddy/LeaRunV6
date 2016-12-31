using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-26 22:35
    /// �� �����û���Ϣ��
    /// </summary>
    public class Base_UserMap : EntityTypeConfiguration<Base_UserEntity>
    {
        public Base_UserMap()
        {
            #region ������
            //��
            this.ToTable("Base_User");
            //����
            this.HasKey(t => t.UserId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}
