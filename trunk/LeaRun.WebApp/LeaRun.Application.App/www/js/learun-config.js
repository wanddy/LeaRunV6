/**
 * Created by cbb on 16/6/3.
 */
//接口地址信息
angular.module('starter.config', [])
.factory('ApiUrl', function () {
  //var rootUrl = "http://192.168.0.5:8801/learun/api";//192.168.0.101
    var rootUrl = "http://127.0.0.1:8078/appservice/learun/api";//192.168.0.5
  //var rootUrl = "http://www.learun.cn:8091/learun/api";
  var apiUrl = {
    loginApi: rootUrl + "/login/checkLogin",
    //退出
    outLoginApi: rootUrl + '/login/outLogin',
    //获取员工列表
    getUserListApi:rootUrl +'/user/getUserList',
    //商机列表
    chanceListApi: rootUrl + '/customerManage/chanceList',
    //客户列表
    customerListApi: rootUrl + '/customerManage/customerList',
    //数据字典列表接口
    dataItemListApi: rootUrl + '/dataItem/list',
    //商机添加
    saveChanceApi: rootUrl + '/customerManage/saveChance',
    //客户添加
    saveCustomerApi: rootUrl + '/customerManage/saveCustomer',
    //通知公告列表
    noticeListApi: rootUrl + '/publicInfoManage/noticeList',
    //区域列表接口
    areaListApi: rootUrl + '/area/list',
    //商机删除
    deleteChanceApi: rootUrl + '/customerManage/deleteChance',
    //客户删除
    deleteCustomerApi: rootUrl + '/customerManage/deleteCustomer',
  };
  return apiUrl;
});
