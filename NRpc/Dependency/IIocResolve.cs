﻿using System;

namespace NRpc.Dependency
{
    /// <summary>
    /// Copyright (C) 2017 yjq 版权所有。
    /// 类名：IIocResolve.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：IIocResolve接口
    /// 创建标识：yjq 2017/7/14 23:22:15
    /// </summary>
    public interface IIocResolve
    {
        #region 解析获取

        /// <summary>
        /// 取出注册的服务类型
        /// </summary>
        /// <typeparam name="TService">服务类型</typeparam>
        /// <returns>注册的服务类型</returns>
        TService Resolve<TService>() where TService : class;

        /// <summary>
        /// 取出注册的服务类型
        /// </summary>
        /// <param name="serviceType">服务类型</param>
        /// <returns>注册的服务类型</returns>
        object Resolve(Type serviceType);

        /// <summary>
        /// 尝试取出注册的服务类型
        /// </summary>
        /// <typeparam name="TService">服务类型</typeparam>
        /// <param name="instance">服务类型默认实例</param>
        /// <returns>成功 则返回true</returns>
        bool TryResolve<TService>(out TService instance) where TService : class;

        /// <summary>
        /// 尝试取出注册的服务类型
        /// </summary>
        /// <param name="serviceType">服务类型</param>
        /// <param name="instance"></param>
        /// <returns>成功 则返回true</returns>
        bool TryResolve(Type serviceType, out object instance);

        /// <summary>
        /// 取出注册的服务类型
        /// </summary>
        /// <typeparam name="TService">服务类型</typeparam>
        /// <param name="serviceName">服务名字</param>
        /// <returns>服务类型</returns>
        TService ResolveNamed<TService>(string serviceName) where TService : class;

        /// <summary>
        /// 取出注册的服务类型
        /// </summary>
        /// <param name="serviceName">服务名字</param>
        /// <param name="serviceType">服务类型</param>
        /// <returns>服务类型</returns>
        object ResolveNamed(string serviceName, Type serviceType);

        /// <summary>
        /// 尝试取出注册的服务类型
        /// </summary>
        /// <param name="serviceName">服务名字</param>
        /// <param name="serviceType">服务类型</param>
        /// <param name="instance">默认实例</param>
        /// <returns>成功 则返回true</returns>
        bool TryResolveNamed(string serviceName, Type serviceType, out object instance);

        #endregion 解析获取
    }
}