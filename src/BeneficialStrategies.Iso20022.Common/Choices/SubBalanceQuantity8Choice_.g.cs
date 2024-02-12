﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SubBalanceQuantity8Choice.  ISO2002 ID# _kcwoQSp8EeyR9JrVGfaMKw.
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
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity8Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity8Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity8Choice.QuantityAndAvailability))]
    [IsoId("_kcwoQSp8EeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Balance Quantity 8 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity8Choice_
    #else
    public abstract partial class SubBalanceQuantity8Choice_
    #endif
    {
    }
}
