﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceQuantity4Choice.  ISO2002 ID# _QYeIatp-Ed-ak6NoX_4Aeg_-2105698154.
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
    [KnownType(typeof(BalanceQuantity4Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity4Choice.Proprietary))]
    [IsoId("_QYeIatp-Ed-ak6NoX_4Aeg_-2105698154")]
    [DisplayName("Balance Quantity 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity4Choice_
    #else
    public abstract partial class BalanceQuantity4Choice_
    #endif
    {
    }
}
