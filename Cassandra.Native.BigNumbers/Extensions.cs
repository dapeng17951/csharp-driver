﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Cassandra.Native
{
    public static class Extensions
    {
        public static BigInteger ToBigInteger(this VarintBuffer varint)
        {
            return new BigInteger(varint.BigIntegerBytes);
        }

        public static VarintBuffer ToVarintBuffer(this BigInteger varint, BigInteger value)
        {
            return new VarintBuffer() { BigIntegerBytes = value.ToByteArray() };
        }



        public static BigDecimal ToDecimal(this DecimalBuffer decim)
        {
            return new BigDecimal(decim.BigIntegerBytes);
        }

        public static DecimalBuffer ToDecimalBuffer(this BigDecimal decim, BigDecimal value)
        {
            return new DecimalBuffer() { BigIntegerBytes = value.ToByteArray()};            
        }

    }
}