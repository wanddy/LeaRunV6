using LeaRun.Application.Entity.BaseManage;
using LeaRun.Application.IService.BaseManage;
using LeaRun.Data.Repository;
using LeaRun.Util.WebControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeaRun.Application.Service.BaseManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2016-07-31 20:50
    /// 描 述：数据库备份
    /// </summary>
    public class Base_DatabaseBackupService : RepositoryFactory, Base_DatabaseBackupIService
    {
        #region 获取数据
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表</returns>
        public IEnumerable<Base_DatabaseBackupEntity> GetPageList(Pagination pagination, string queryJson)
        {
            return this.BaseRepository().FindList<Base_DatabaseBackupEntity>(pagination);
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public Base_DatabaseBackupEntity GetEntity(string keyValue)
        {
            return this.BaseRepository().FindEntity<Base_DatabaseBackupEntity>(keyValue);
        }
        /// <summary>
        /// 获取子表详细信息
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public IEnumerable<Base_AreaEntity> GetDetails(string keyValue)
        {
            return this.BaseRepository().FindList<Base_AreaEntity>("select * from Base_Area where AreaId='"+keyValue "'");        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RemoveForm(string keyValue)
        {
            IRepository db = new RepositoryFactory().BaseRepository().BeginTrans();
            try
            {
                db.Delete<Base_DatabaseBackupEntity>(keyValue);
                db.Delete<Base_AreaEntity>(t => t.F_OrderId.Equals(keyValue));
                db.Commit();
            }
            catch (Exception)
            {
                db.Rollback();
                throw;
            }
        }
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, Base_DatabaseBackupEntity entity,List<Base_AreaEntity> entryList)
        {
        IRepository db = this.BaseRepository().BeginTrans();
        try
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                //主表
                entity.Modify(keyValue);
                db.Update(entity);
                //明细
                db.Delete<Base_AreaEntity>(t => t.AreaId.Equals(keyValue));
                foreach (Base_AreaEntity item in entryList)
                {
                    item.Create();
                    item.AreaId = entity.DatabaseBackupId;
                    db.Insert(item);
                }
            }
            else
            {
                //主表
                entity.Create();
                db.Insert(entity);
                //明细
                foreach (Base_AreaEntity item in entryList)
                {
                    item.Create();
                    item.AreaId = entity.DatabaseBackupId;
                    db.Insert(item);
                }
            }
            db.Commit();
        }
        catch (Exception)
        {
            db.Rollback();
            throw;
        }
        }
        #endregion
    }
}
