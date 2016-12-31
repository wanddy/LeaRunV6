﻿using LeaRun.Application.Entity.CustomerManage;
using LeaRun.Application.Entity.CustomerManage.ViewModel;
using LeaRun.Util.WebControl;
using System.Collections.Generic;

namespace LeaRun.Application.IService.CustomerManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创 建：佘赐雄
    /// 日 期：2016-04-19 17:40
    /// 描 述：应收账款报表
    /// </summary>
    public interface IReceivableReportService
    {
        /// <summary>
        /// 获取收款列表
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回列表</returns>
        IEnumerable<ReceivableReportModel> GetList(string queryJson);
    }
}