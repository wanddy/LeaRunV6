using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2016-07-31 20:50
    /// 描 述：数据库备份
    /// </summary>
    public class Base_DatabaseBackupMap : EntityTypeConfiguration<Base_DatabaseBackupEntity>
    {
        public Base_DatabaseBackupMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_DatabaseBackup");
            //主键
            this.HasKey(t => t.DatabaseBackupId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
