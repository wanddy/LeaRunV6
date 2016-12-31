using LeaRun.Application.Entity.CustomerManage;
using LeaRun.Application.IService.CustomerManage;
using LeaRun.Data.Repository;
using LeaRun.Util.WebControl;
using LeaRun.Util.Extension;
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
    /// �� �ڣ�2016-04-28 16:48
    /// �� �����ֽ����
    /// </summary>
    public class CashBalanceService : RepositoryFactory<CashBalanceEntity>, ICashBalanceService
    {
        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        public IEnumerable<CashBalanceEntity> GetList(string queryJson)
        {
            var expression = LinqExtensions.True<CashBalanceEntity>();
            var queryParam = queryJson.ToJObject();
            //��������
            if (!queryParam["StartTime"].IsEmpty() && !queryParam["EndTime"].IsEmpty())
            {
                DateTime startTime = queryParam["StartTime"].ToDate();
                DateTime endTime = queryParam["EndTime"].ToDate().AddDays(1);
                expression = expression.And(t => t.ExecutionDate >= startTime && t.ExecutionDate <= endTime);
            }
            return this.BaseRepository().IQueryable(expression).OrderBy(t => t.CreateDate).ToList();
        }
        #endregion

        #region �ύ����
        /// <summary>
        /// �����֧���
        /// </summary>
        /// <param name="db"></param>
        /// <param name="cashBalanceEntity"></param>
        public void AddBalance(IRepository db, CashBalanceEntity cashBalanceEntity)
        {
            decimal balance = 0;
            var data = db.IQueryable<CashBalanceEntity>(t => t.CashAccount == cashBalanceEntity.CashAccount).OrderByDescending(t => t.CreateDate);
            if (data.Count() > 0)
            {
                balance = data.First().Balance.ToDecimal();
            }
            if (cashBalanceEntity.Receivable != null)
            {
                cashBalanceEntity.Balance = cashBalanceEntity.Receivable + balance;
            }
            if (cashBalanceEntity.Expenses != null)
            {
                cashBalanceEntity.Balance = balance - cashBalanceEntity.Expenses;
            }
            cashBalanceEntity.Create();
            db.Insert(cashBalanceEntity);
        }
        #endregion
    }
}
