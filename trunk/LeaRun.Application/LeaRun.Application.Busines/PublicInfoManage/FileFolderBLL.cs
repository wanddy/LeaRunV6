﻿using LeaRun.Application.Entity.PublicInfoManage;
using LeaRun.Application.IService.PublicInfoManage;
using LeaRun.Application.Service.PublicInfoManage;
using System;
using System.Collections.Generic;

namespace LeaRun.Application.Busines.PublicInfoManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2015.12.15 10:56
    /// 描 述：文件夹
    /// </summary>
    public class FileFolderBLL
    {
        private IFileFolderService service = new FileFolderService();

        #region 获取数据
        /// <summary>
        /// 文件夹列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<FileFolderEntity> GetList(string userId)
        {
            return service.GetList(userId);
        }
        /// <summary>
        /// 文件夹实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public FileFolderEntity GetEntity(string keyValue)
        {
            return service.GetEntity(keyValue);
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 还原文件夹
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RestoreFile(string keyValue)
        {
            try
            {
                service.RestoreFile(keyValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RemoveForm(string keyValue)
        {
            try
            {
                service.RemoveForm(keyValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 彻底删除文件夹
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void ThoroughRemoveForm(string keyValue)
        {
            try
            {
                service.ThoroughRemoveForm(keyValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 保存文件夹表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="fileFolderEntity">文件夹实体</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, FileFolderEntity fileFolderEntity)
        {
            try
            {
                service.SaveForm(keyValue, fileFolderEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 共享文件夹
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="IsShare">是否共享：1-共享 0取消共享</param>
        public void ShareFolder(string keyValue,int IsShare=1)
        {
            try
            {
                service.ShareFolder(keyValue, IsShare);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
