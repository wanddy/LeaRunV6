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
    public class Base_AreaMap : EntityTypeConfiguration<Base_AreaEntity>
    {
        public Base_AreaMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_Area");
            //主键
            this.HasKey(t => t.);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
