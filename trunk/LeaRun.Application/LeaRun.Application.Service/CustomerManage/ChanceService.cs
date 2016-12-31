using LeaRun.Application.Code;
using LeaRun.Application.Entity.CustomerManage;
using LeaRun.Application.IService.CustomerManage;
using LeaRun.Application.IService.SystemManage;
using LeaRun.Application.Service.SystemManage;
using LeaRun.Data.Repository;
using LeaRun.Util.Extension;
using LeaRun.Util.WebControl;
using LeaRun.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeaRun.Application.Service.CustomerManage
{
    /// <summary>
    /// �� �� 6.1
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-03-12 10:50
    /// �� �����̻���Ϣ
    /// </summary>
    public class ChanceService : RepositoryFactory<ChanceEntity>, IChanceService
    {
        private ICodeRuleService coderuleService = new CodeRuleService();
        private ITrailRecordService trailRecordService = new TrailRecordService();

        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="pagination">��ҳ</param>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>���ط�ҳ�б�</returns>
        public IEnumerable<ChanceEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<ChanceEntity>();
            var queryParam = queryJson.ToJObject();
            //��ѯ����
            if (!queryParam["condition"].IsEmpty() && !queryParam["keyword"].IsEmpty())
            {
                string condition = queryParam["condition"].ToString();
                string keyword = queryParam["keyword"].ToString();
                switch (condition)
                {
                    case "EnCode":              //�̻����
                        expression = expression.And(t => t.EnCode.Contains(keyword));
                        break;
                    case "FullName":            //�̻�����
                        expression = expression.And(t => t.FullName.Contains(keyword));
                        break;
                    case "Contacts":            //��ϵ��
                        expression = expression.And(t => t.Contacts.Contains(keyword));
                        break;
                    case "Mobile":              //�ֻ�
                        expression = expression.And(t => t.Mobile.Contains(keyword));
                        break;
                    case "Tel":                 //�绰
                        expression = expression.And(t => t.Tel.Contains(keyword));
                        break;
                    case "QQ":                  //QQ
                        expression = expression.And(t => t.QQ.Contains(keyword));
                        break;
                    case "Wechat":              //΢��
                        expression = expression.And(t => t.Wechat.Contains(keyword));
                        break;
                    case "All":
                        expression = expression.And(t => t.FullName.Contains(keyword) 
                            || t.Contacts.Contains(keyword)
                            || t.Mobile.Contains(keyword) 
                            || t.Tel.Contains(keyword)
                            || t.QQ.Contains(keyword)
                            || t.Wechat.Contains(keyword)
                            || t.CompanyName.Contains(keyword)
                            || t.Contacts.Contains(keyword)
                            || t.City.Contains(keyword)
                            );
                        break;
                    default:
                        break;
                }
            }
            //expression = expression.And(t => t.IsToCustom != 1);
            return this.BaseRepository().FindList(expression, pagination);
        } 
        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <returns></returns>
        public ChanceEntity GetEntity(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region ��֤����
        /// <summary>
        /// �̻����Ʋ����ظ�
        /// </summary>
        /// <param name="fullName">����</param>
        /// <param name="keyValue">����</param>
        /// <returns></returns>
        public bool ExistFullName(string fullName, string keyValue)
        {
            var expression = LinqExtensions.True<ChanceEntity>();
            expression = expression.And(t => t.FullName == fullName);
            if (!string.IsNullOrEmpty(keyValue))
            {
                expression = expression.And(t => t.ChanceId != keyValue);
            }
            return this.BaseRepository().IQueryable(expression).Count() == 0 ? true : false;
        }
        #endregion

        #region �ύ����
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="keyValue">����</param>
        public void RemoveForm(string keyValue)
        {
            IRepository db = new RepositoryFactory().BaseRepository().BeginTrans();
            try
            {
                db.Delete<ChanceEntity>(keyValue);
                db.Delete<TrailRecordEntity>(t => t.ObjectId.Equals(keyValue));
                db.Commit();
            }
            catch (Exception)
            {
                db.Rollback();
                throw;
            }
        }
        /// <summary>
        /// ��������������޸ģ�
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <param name="entity">ʵ�����</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, ChanceEntity entity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                this.BaseRepository().Update(entity);
            }
            else
            {
                IRepository db = new RepositoryFactory().BaseRepository().BeginTrans();
                try
                {
                    entity.Create();
                    db.Insert(entity);
                    //ռ�õ��ݺ�
                    coderuleService.UseRuleSeed(entity.CreateUserId, SystemInfo.CurrentModuleId, "", db);
                    db.Commit();
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw;
                }
            }
        }
        /// <summary>
        /// �̻�����
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        public void Invalid(string keyValue)
        {
            ChanceEntity entity = new ChanceEntity();
            entity.Modify(keyValue);
            entity.ChanceState = 0;
            this.BaseRepository().Update(entity);
        }
        /// <summary>
        /// �̻�ת���ͻ�
        /// </summary>
        /// <param name="keyValue">����</param>
        public void ToCustomer(string keyValue)
        {
            ChanceEntity chanceEntity = this.GetEntity(keyValue);
            IEnumerable<TrailRecordEntity> trailRecordList = trailRecordService.GetList(keyValue);
            IRepository db = new RepositoryFactory().BaseRepository().BeginTrans();
            try
            {
                chanceEntity.Modify(keyValue);
                chanceEntity.IsToCustom = 1;
                db.Update<ChanceEntity>(chanceEntity);

                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity.Create();
                customerEntity.EnCode = coderuleService.SetBillCode(customerEntity.CreateUserId, "", ((int)CodeRuleEnum.Customer_CustomerCode).ToString(), db);
                customerEntity.FullName = chanceEntity.CompanyName;
                customerEntity.TraceUserId = chanceEntity.TraceUserId;
                customerEntity.TraceUserName = chanceEntity.TraceUserName;
                customerEntity.CustIndustryId = chanceEntity.CompanyNatureId;
                customerEntity.CompanySite = chanceEntity.CompanySite;
                customerEntity.CompanyDesc = chanceEntity.CompanyDesc;
                customerEntity.CompanyAddress = chanceEntity.CompanyAddress;
                customerEntity.Province = chanceEntity.Province;
                customerEntity.City = chanceEntity.City;
                customerEntity.Contact = chanceEntity.Contacts;
                customerEntity.Mobile = chanceEntity.Mobile;
                customerEntity.Tel = chanceEntity.Tel;
                customerEntity.Fax = chanceEntity.Fax;
                customerEntity.QQ = chanceEntity.QQ;
                customerEntity.Email = chanceEntity.Email;
                customerEntity.Wechat = chanceEntity.Wechat;
                customerEntity.Hobby = chanceEntity.Hobby;
                customerEntity.Description = chanceEntity.Description;
                customerEntity.CustLevelId = "C";
                customerEntity.CustDegreeId = "�����ͻ�";
                db.Insert<CustomerEntity>(customerEntity);

                foreach (TrailRecordEntity item in trailRecordList)
                {
                    item.TrailId = Guid.NewGuid().ToString();
                    item.ObjectId = customerEntity.CustomerId;
                    item.ObjectSort = 2;
                    db.Insert<TrailRecordEntity>(item);
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
