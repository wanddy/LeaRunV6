﻿using LeaRun.Application.Entity.ReportManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2015.11.27
    /// 描 述：授权数据范围
    /// </summary>
    public class RptTempMap : EntityTypeConfiguration<RptTempEntity>
    {
        public RptTempMap()
        {
            #region 表、主键
            //表
            this.ToTable("Rpt_Temp");
            //主键
            this.HasKey(t => t.TempId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
