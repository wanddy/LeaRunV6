using LeaRun.Application.Entity.PublicInfoManage;
using LeaRun.Application.IService.PublicInfoManage;
using LeaRun.Data.Repository;
using LeaRun.Util.WebControl;
using System.Collections.Generic;
using System.Linq;

namespace LeaRun.Application.Service.PublicInfoManage
{
    /// <summary>
    /// �� �� 6.1
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� �����ܴ���
    /// �� �ڣ�2016-04-25 10:45
    /// �� �����ճ̹���
    /// </summary>
    public class ScheduleService : RepositoryFactory<ScheduleEntity>, IScheduleService
    {
        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        public IEnumerable<ScheduleEntity> GetList(string queryJson)
        {
            return this.BaseRepository().IQueryable().ToList();
        }
        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <returns></returns>
        public ScheduleEntity GetEntity(string keyValue)
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
        /// ��������������޸ģ�
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <param name="entity">ʵ�����</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, ScheduleEntity entity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                this.BaseRepository().Update(entity);
            }
            else
            {
                entity.Create();
                this.BaseRepository().Insert(entity);
            }
        }
        #endregion
    }
}
