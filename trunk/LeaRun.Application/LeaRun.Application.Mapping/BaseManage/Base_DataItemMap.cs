using LeaRun.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.BaseManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2016-07-26 22:23
    /// 描 述：数据字典分类表
    /// </summary>
    public class Base_DataItemMap : EntityTypeConfiguration<Base_DataItemEntity>
    {
        public Base_DataItemMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_DataItem");
            //主键
            this.HasKey(t => t.ItemId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
