﻿using LeaRun.Application.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.SystemManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2016.1.8 9:56
    /// 描 述：系统日志
    /// </summary>
    public class LogMap : EntityTypeConfiguration<LogEntity>
    {
        public LogMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_Log");
            //主键
            this.HasKey(t => t.LogId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
