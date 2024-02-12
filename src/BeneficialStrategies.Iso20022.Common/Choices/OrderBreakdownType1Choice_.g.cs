﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OrderBreakdownType1Choice.  ISO2002 ID# _uwnTwDhjEeamLZQeccJa7w.
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
    /// Choice of formats for order breakdown type.
    /// </summary>
    [KnownType(typeof(OrderBreakdownType1Choice.Code))]
    [KnownType(typeof(OrderBreakdownType1Choice.Proprietary))]
    [IsoId("_uwnTwDhjEeamLZQeccJa7w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Breakdown Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrderBreakdownType1Choice_
    #else
    public abstract partial class OrderBreakdownType1Choice_
    #endif
    {
    }
}
