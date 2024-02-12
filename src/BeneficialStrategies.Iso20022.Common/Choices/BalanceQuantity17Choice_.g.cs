﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceQuantity17Choice.  ISO2002 ID# _csW4Azi8Eeydid5dcNPKvg.
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
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity17Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity17Choice.Proprietary))]
    [IsoId("_csW4Azi8Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Quantity 17 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity17Choice_
    #else
    public abstract partial class BalanceQuantity17Choice_
    #endif
    {
    }
}
