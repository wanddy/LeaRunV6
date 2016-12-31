using LeaRun.Application.Code;
using LeaRun.Application.Entity.AuthorizeManage;
using LeaRun.Application.Entity.AuthorizeManage.ViewModel;
using LeaRun.Application.Entity.BaseManage;
using LeaRun.Application.IService.AuthorizeManage;
using LeaRun.Data;
using LeaRun.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaRun.Application.Service.AuthorizeManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 上海力软信息技术有限公司
    /// 创建人：佘赐雄
    /// 日 期：2015.12.5 22:35
    /// 描 述：授权认证
    /// </summary>
    public class AuthorizeService : RepositoryFactory, IAuthorizeService
    {
        /// <summary>
        /// 获取授权功能
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<ModuleEntity> GetModuleList(string userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  *
                            FROM    Base_Module
                            WHERE   ModuleId IN (
                                    SELECT  ItemId
                                    FROM    Base_Authorize
                                    WHERE   ItemType = 1
                                            AND ( ObjectId IN (
                                                  SELECT    ObjectId
                                                  FROM      Base_UserRelation
                                                  WHERE     UserId = @UserId ) )
                                            OR ObjectId = @UserId )
                            AND EnabledMark = 1  AND DeleteMark = 0 Order By SortCode");
            DbParameter[] parameter = 
            {
                DbParameters.CreateDbParameter("@UserId",userId)
            };
            return this.BaseRepository().FindList<ModuleEntity>(strSql.ToString(), parameter);
        }
        /// <summary>
        /// 获取授权功能按钮
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<ModuleButtonEntity> GetModuleButtonList(string userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  *
                            FROM    Base_ModuleButton
                            WHERE   ModuleButtonId IN (
                                    SELECT  ItemId
                                    FROM    Base_Authorize
                                    WHERE   ItemType = 2
                                            AND ( ObjectId IN (
                                                  SELECT    ObjectId
                                                  FROM      Base_UserRelation
                                                  WHERE     UserId = @UserId ) )
                                            OR ObjectId = @UserId ) Order By SortCode");
            DbParameter[] parameter = 
            {
                DbParameters.CreateDbParameter("@UserId",userId)
            };
            return this.BaseRepository().FindList<ModuleButtonEntity>(strSql.ToString(), parameter);
        }
        /// <summary>
        /// 获取授权功能视图
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<ModuleColumnEntity> GetModuleColumnList(string userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  *
                            FROM    Base_ModuleColumn
                            WHERE   ModuleColumnId IN (
                                    SELECT  ItemId
                                    FROM    Base_Authorize
                                    WHERE   ItemType = 3
                                            AND ( ObjectId IN (
                                                  SELECT    ObjectId
                                                  FROM      Base_UserRelation
                                                  WHERE     UserId = @UserId ) )
                                            OR ObjectId = @UserId )  Order By SortCode");
            DbParameter[] parameter = 
            {
                DbParameters.CreateDbParameter("@UserId",userId)
            };
            return this.BaseRepository().FindList<ModuleColumnEntity>(strSql.ToString(), parameter);
        }
        /// <summary>
        /// 获取授权功能Url、操作Url
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<AuthorizeUrlModel> GetUrlList(string userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  ModuleId AS AuthorizeId ,
                                    ModuleId ,
                                    UrlAddress ,
                                    FullName
                            FROM    Base_Module
                            WHERE   ModuleId IN (
                                    SELECT  ItemId
                                    FROM    Base_Authorize
                                    WHERE   ItemType = 1
                                            AND ( ObjectId IN (
                                                  SELECT    ObjectId
                                                  FROM      Base_UserRelation
                                                  WHERE     UserId = @UserId ) )
                                            OR ObjectId = @UserId )
                                    AND EnabledMark = 1
                                    AND DeleteMark = 0
                                    AND IsMenu = 1
                                    AND UrlAddress IS NOT NULL
                            UNION
                            SELECT  ModuleButtonId AS AuthorizeId ,
                                    ModuleId ,
                                    ActionAddress AS UrlAddress ,
                                    FullName
                            FROM    Base_ModuleButton
                            WHERE   ModuleButtonId IN (
                                    SELECT  ItemId
                                    FROM    Base_Authorize
                                    WHERE   ItemType = 2
                                            AND ( ObjectId IN (
                                                  SELECT    ObjectId
                                                  FROM      Base_UserRelation
                                                  WHERE     UserId = @UserId ) )
                                            OR ObjectId = @UserId )
                                    AND ActionAddress IS NOT NULL");
            DbParameter[] parameter = 
            {
                DbParameters.CreateDbParameter("@UserId",userId)
            };
            return this.BaseRepository().FindList<AuthorizeUrlModel>(strSql.ToString(), parameter);
        }
        /// <summary>
        /// 获取关联用户关系
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<UserRelationEntity> GetUserRelationList(string userId)
        {
            return this.BaseRepository().IQueryable<UserRelationEntity>(t => t.UserId == userId);
        }
        /// <summary>
        /// 获得权限范围用户ID
        /// </summary>
        /// <param name="operators">当前登陆用户信息</param>
        /// <param name="isWrite">可写入</param>
        /// <returns></returns>
        public string GetDataAuthorUserId(Operator operators, bool isWrite = false)
        {
            string userIdList = GetDataAuthor(operators, isWrite);
            if (userIdList == "")
            {
                return "";
            }
            IRepository db = new RepositoryFactory().BaseRepository();
            string userId = operators.UserId;
            List<UserEntity> userList = db.FindList<UserEntity>(userIdList).ToList();
            StringBuilder userSb = new StringBuilder("");
            if (userList != null)
            {
                foreach (var item in userList)
                {
                    userSb.Append(item.UserId);
                    userSb.Append(",");
                }
            }
            return userSb.ToString();
        }
        /// <summary>
        /// 获得可读数据权限范围SQL
        /// </summary>
        /// <param name="operators">当前登陆用户信息</param>
        /// <param name="isWrite">可写入</param>
        /// <returns></returns>
        public string GetDataAuthor(Operator operators, bool isWrite = false)
        {
            //如果是系统管理员直接给所有数据权限
            if (operators.IsSystem)
            {
                return "";
            }
            IRepository db = new RepositoryFactory().BaseRepository();
            string userId = operators.UserId;
            StringBuilder whereSb = new StringBuilder(" select UserId from Base_user where 1=1 ");
            string strAuthorData = "";
            if (isWrite)
            {
                strAuthorData = @"   SELECT    *
                                        FROM      Base_AuthorizeData
                                        WHERE     IsRead=0 AND
                                        ObjectId IN (
                                                SELECT  ObjectId
                                                FROM    Base_UserRelation
                                                WHERE   UserId =@UserId)";
            }
            else
            {
                strAuthorData = @"   SELECT    *
                                        FROM      Base_AuthorizeData
                                        WHERE     
                                        ObjectId IN (
                                                SELECT  ObjectId
                                                FROM    Base_UserRelation
                                                WHERE   UserId =@UserId)";
            }
            DbParameter[] parameter = 
            {
                DbParameters.CreateDbParameter("@UserId",userId),
            };
            whereSb.Append(string.Format("AND( UserId ='{0}'", userId));
            IEnumerable<AuthorizeDataEntity> listAuthorizeData = db.FindList<AuthorizeDataEntity>(strAuthorData, parameter);
            foreach (AuthorizeDataEntity item in listAuthorizeData)
            {
                switch (item.AuthorizeType)
                {
                    //0代表最大权限
                    case 0://
                        return "";
                    //本人及下属
                    case -2://
                        whereSb.Append("  OR ManagerId ='{0}'");
                        break;
                    case -3:
                        whereSb.Append(@"  OR DepartmentId = (  SELECT  DepartmentId
                                                                    FROM    Base_User
                                                                    WHERE   UserId ='{0}'
                                                                  )");
                        break;
                    case -4:
                        whereSb.Append(@"  OR OrganizeId = (    SELECT  OrganizeId
                                                                    FROM    Base_User
                                                                    WHERE   UserId ='{0}'
                                                                  )");
                        break;
                    case -5:
                        whereSb.Append(string.Format(@"  OR DepartmentId='{1}' OR OrganizeId='{1}'", userId, item.ResourceId));
                        break;
                }
            }
            whereSb.Append(")");
            return whereSb.ToString();
        }

    }
}
