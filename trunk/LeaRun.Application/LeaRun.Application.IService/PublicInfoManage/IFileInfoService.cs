﻿using LeaRun.Application.Entity.PublicInfoManage;
using System.Collections.Generic;

namespace LeaRun.Application.IService.PublicInfoManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2015.12.15 10:56
    /// 描 述：文件信息
    /// </summary>
    public interface IFileInfoService
    {
        #region 获取数据
        /// <summary>
        /// 所有文件（夹）列表
        /// </summary>
        /// <param name="folderId">文件夹Id</param>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetList(string folderId, string userId);
        /// <summary>
        /// 文档列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetDocumentList(string userId);
        /// <summary>
        /// 图片列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetImageList(string userId);
        /// <summary>
        /// 回收站文件（夹）列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetRecycledList(string userId);
        /// <summary>
        /// 我的文件（夹）共享列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetMyShareList(string userId);
        /// <summary>
        /// 他人文件（夹）共享列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        IEnumerable<FileInfoEntity> GetOthersShareList(string userId);
        /// <summary>
        /// 文件信息实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        FileInfoEntity GetEntity(string keyValue);
        #endregion

        #region 提交数据
        /// <summary>
        /// 还原文件
        /// </summary>
        /// <param name="keyValue">主键</param>
        void RestoreFile(string keyValue);
        /// <summary>
        /// 删除文件信息
        /// </summary>
        /// <param name="keyValue">主键</param>
        void RemoveForm(string keyValue);
        /// <summary>
        /// 彻底删除文件信息
        /// </summary>
        /// <param name="keyValue">主键</param>
        void ThoroughRemoveForm(string keyValue);
        /// <summary>
        /// 保存文件信息表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="fileInfoEntity">文件信息实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, FileInfoEntity fileInfoEntity);
        /// <summary>
        /// 共享文件
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="IsShare">是否共享：1-共享 0取消共享</param>
        void ShareFile(string keyValue, int IsShare);
        #endregion
    }
}
