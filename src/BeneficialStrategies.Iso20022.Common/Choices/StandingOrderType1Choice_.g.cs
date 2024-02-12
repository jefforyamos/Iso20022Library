﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StandingOrderType1Choice.  ISO2002 ID# _73bb4KMgEeCJ6YNENx4h-w_-1191465666.
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
    /// Defines the type of liquidity transfer standing order.
    /// </summary>
    [KnownType(typeof(StandingOrderType1Choice.Code))]
    [KnownType(typeof(StandingOrderType1Choice.Proprietary))]
    [IsoId("_73bb4KMgEeCJ6YNENx4h-w_-1191465666")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Standing Order Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderType1Choice_
    #else
    public abstract partial class StandingOrderType1Choice_
    #endif
    {
    }
}
