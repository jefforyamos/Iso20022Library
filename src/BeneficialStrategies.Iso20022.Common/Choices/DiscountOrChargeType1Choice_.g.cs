﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DiscountOrChargeType1Choice.  ISO2002 ID# _St2yMAEcEeCQm6a_G2yO_w_-1902647807.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a type of discount or a type of charge.
    /// </summary>
    [KnownType(typeof(DiscountOrChargeType1Choice.ChargeType))]
    [KnownType(typeof(DiscountOrChargeType1Choice.DiscountType))]
    [IsoId("_St2yMAEcEeCQm6a_G2yO_w_-1902647807")]
    [DisplayName("Discount Or Charge Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DiscountOrChargeType1Choice_
    #else
    public abstract partial class DiscountOrChargeType1Choice_
    #endif
    {
    }
}
