using LeaRun.Application.Entity.CustomerManage;
using LeaRun.Application.IService.CustomerManage;
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
    /// �� �ڣ�2016-04-20 11:23
    /// �� ��������֧��
    /// </summary>
    public class ExpensesService : RepositoryFactory<ExpensesEntity>, IExpensesService
    {
        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="pagination">��ҳ</param>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>���ط�ҳ�б�</returns>
        public IEnumerable<ExpensesEntity> GetPageList(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<ExpensesEntity>();
            var queryParam = queryJson.ToJObject();
            //֧������
            if (!queryParam["StartTime"].IsEmpty() && !queryParam["EndTime"].IsEmpty())
            {
                DateTime startTime = queryParam["StartTime"].ToDate();
                DateTime endTime = queryParam["EndTime"].ToDate().AddDays(1);
                expression = expression.And(t => t.ExpensesDate >= startTime && t.ExpensesDate <= endTime);
            }
            //֧������
            if (!queryParam["ExpensesType"].IsEmpty())
            {
                string CustomerName = queryParam["ExpensesType"].ToString();
                expression = expression.And(t => t.ExpensesType.Equals(CustomerName));
            }
            //������
            if (!queryParam["Managers"].IsEmpty())
            {
                string SellerName = queryParam["Managers"].ToString();
                expression = expression.And(t => t.Managers.Contains(SellerName));
            }
            return this.BaseRepository().FindList(expression, pagination);
        }
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        public IEnumerable<ExpensesEntity> GetList(string queryJson)
        {
            return this.BaseRepository().IQueryable().ToList();
        }
        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <returns></returns>
        public ExpensesEntity GetEntity(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        #endregion

        #region �ύ����
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="keyValue">����</param>
        public void RemoveForm(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);
        }
        /// <summary>
        /// �������������
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <param name="entity">ʵ�����</param>
        /// <returns></returns>
        public void SaveForm(ExpensesEntity entity)
        {
            ICashBalanceService icashbalanceservice = new CashBalanceService();

            IRepository db = new RepositoryFactory().BaseRepository().BeginTrans();
            try
            {
                //֧��
                entity.Create();
                db.Insert(entity);


                //����˻����
                icashbalanceservice.AddBalance(db, new CashBalanceEntity
                {
                    ObjectId = entity.ExpensesId,
                    ExecutionDate = entity.ExpensesDate,
                    CashAccount = entity.ExpensesAccount,
                    Expenses = entity.ExpensesPrice,
                    Abstract = entity.ExpensesAbstract
                });

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
