﻿using Colorful.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Colorful.Web.CMS
{
    /// <summary>
    /// 全局配置类
    /// </summary>
    public static class WebConfig
    {
        //项目Id，用于前辍标识，如：Redis前辍
        public static string ProjectId = null;
        /// <summary>
        /// 后台路由前辍
        /// </summary>
        public static string AdminRoutePrefix = null;
        /// <summary>
        /// 网站语言
        /// </summary>
        public static List<JsonData<string>> Languages = null;
        /// <summary>
        /// 网站根目录
        /// </summary>
        public static string RootPath = "";
        //是否为开发环境
        public static bool IsDevelopment;
        /// <summary>
        /// LoggerFactory
        /// </summary>
        public static ILoggerFactory LoggerFactory;
        /// <summary>
        /// 缓存服务
        /// </summary>
        public static Cache.ICacheService CacheService;
        /// <summary>
        /// 系统设置
        /// </summary>
        public static SysSetting SysSetting;
        /// <summary>
        /// 网站设置
        /// </summary>
        public static WebSetting WebSetting;
        /// <summary>
        /// 网站静态目录
        /// </summary>
        public static List<string> WebStaticFolders = null;
        /// <summary>
        /// 数据库名称
        /// </summary>
        public static string Database;
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionString;
        /// <summary>
        /// IConfiguration
        /// </summary>
        public static IConfiguration Configuration;
        /// <summary>
        /// RazorRenderer服务
        /// </summary>
        public static RazorViewService RazorViewService;
        /// <summary>
        /// 资源路径
        /// </summary>
        public static string ResUrl;

        #region 获取数据库接口
        public static MongodbContext GetMongodb(string database = "")
        {
            if (string.IsNullOrEmpty(database))
                database = Database;
            return new MongodbContext(ConnectionString, database);
        }
        #endregion
    }
}
