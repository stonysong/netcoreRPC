﻿using NRpc.Utils;
using System;

namespace NRpc.Serializing.RpcSerializer.Serializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：ShortSerializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 15:55:46
    /// </summary>
    public sealed class ShortSerializer : BaseSerializer
    {
        public override byte[] GeteObjectBytes(object obj)
        {
            if (obj == null)
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_Short, ByteUtil.ZeroLengthBytes, ByteUtil.EmptyBytes);
            }
            else
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_Short, BitConverter.GetBytes((short)obj));
            }
        }
    }
}