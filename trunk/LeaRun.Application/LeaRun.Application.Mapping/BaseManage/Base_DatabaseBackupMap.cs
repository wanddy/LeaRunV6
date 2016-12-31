using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-31 20:50
    /// �� �������ݿⱸ��
    /// </summary>
    public class Base_DatabaseBackupMap : EntityTypeConfiguration<Base_DatabaseBackupEntity>
    {
        public Base_DatabaseBackupMap()
        {
            #region ������
            //��
            this.ToTable("Base_DatabaseBackup");
            //����
            this.HasKey(t => t.DatabaseBackupId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}
