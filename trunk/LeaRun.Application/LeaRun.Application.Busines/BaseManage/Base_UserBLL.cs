using LeaRun.Application.Entity.BaseManage;
using LeaRun.Application.IService.BaseManage;
using LeaRun.Application.Service.BaseManage;
using LeaRun.Util.WebControl;
using System.Collections.Generic;
using System;

namespace LeaRun.Application.Busines.BaseManage
{
    /// <summary>
    /// �� �� 6.1
    /// Copyright (c) 2013-2016 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2016-07-26 22:35
    /// �� �����û���Ϣ��
    /// </summary>
    public class Base_UserBLL
    {
        private Base_UserIService service = new Base_UserService();

        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        public IEnumerable<Base_UserEntity> GetList(string queryJson)
        {
            return service.GetList(queryJson);
        }
        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <returns></returns>
        public Base_UserEntity GetEntity(string keyValue)
        {
            return service.GetEntity(keyValue);
        }
        #endregion

        #region �ύ����
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="keyValue">����</param>
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
        /// ��������������޸ģ�
        /// </summary>
        /// <param name="keyValue">����ֵ</param>
        /// <param name="entity">ʵ�����</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, Base_UserEntity entity)
        {
            try
            {
                service.SaveForm(keyValue, entity);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
