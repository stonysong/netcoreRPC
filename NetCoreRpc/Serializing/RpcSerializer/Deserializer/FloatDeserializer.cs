﻿using NetCoreRpc.Utils;

namespace NetCoreRpc.Serializing.RpcSerializer.Deserializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：FloatDeserializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 16:43:35
    /// </summary>
    public sealed class FloatDeserializer : BaseDeserializer
    {
        public override object GetObject(byte[] inputBytes, int startOffset, out int nextStartOffset)
        {
            return ByteUtil.DecodeFloat(inputBytes, startOffset, out nextStartOffset);
        }
    }
}