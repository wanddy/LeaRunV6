using LeaRun.Application.Busines;
using LeaRun.Application.Busines.SystemManage;
using LeaRun.Application.Entity.SystemManage.ViewModel;
using LeaRun.Cache.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaRun.Application.Cache
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2015.12.29 9:56
    /// 描 述：数据字典缓存
    /// </summary>
    public class DataItemCache
    {
        private DataItemDetailBLL busines = new DataItemDetailBLL();

        /// <summary>
        /// 数据字典列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataItemModel> GetDataItemList()
        {
            var cacheList = CacheFactory.Cache().GetCache<IEnumerable<DataItemModel>>(busines.cacheKey);
            if (cacheList == null)
            {
                var data = busines.GetDataItemList();
                CacheFactory.Cache().WriteCache(data, busines.cacheKey);
                return data;
            }
            else
            {
                return cacheList;
            }
        }
        /// <summary>
        /// 数据字典列表
        /// </summary>
        /// <param name="EnCode">分类代码</param>
        /// <returns></returns>
        public IEnumerable<DataItemModel> GetDataItemList(string EnCode)
        {
            return this.GetDataItemList().Where(t => t.EnCode == EnCode);
        }
        /// <summary>
        /// 数据字典列表
        /// </summary>
        /// <param name="EnCode">分类代码</param>
        /// <param name="ItemValue">项目值</param>
        /// <returns></returns>
        public IEnumerable<DataItemModel> GetSubDataItemList(string EnCode, string ItemValue)
        {
            var data = this.GetDataItemList().Where(t => t.EnCode == EnCode);
            string ItemDetailId = data.First(t => t.ItemValue == ItemValue).ItemDetailId;
            return data.Where(t => t.ParentId == ItemDetailId);
        }
        /// <summary>
        /// 项目值转换名称
        /// </summary>
        /// <param name="EnCode">分类代码</param>
        /// <param name="ItemValue">项目值</param>
        /// <returns></returns>
        public string ToItemName(string EnCode, string ItemValue)
        {
            var data = this.GetDataItemList().Where(t => t.EnCode == EnCode);
            return data.First(t => t.ItemValue == ItemValue).ItemName;
        }
    }
}
