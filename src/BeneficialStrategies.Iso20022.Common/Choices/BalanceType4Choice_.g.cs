﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceType4Choice.  ISO2002 ID# _RcRuwNp-Ed-ak6NoX_4Aeg_-1171282176.
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
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType4Choice.Code))]
    [KnownType(typeof(BalanceType4Choice.Proprietary))]
    [IsoId("_RcRuwNp-Ed-ak6NoX_4Aeg_-1171282176")]
    [DisplayName("Balance Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType4Choice_
    #else
    public abstract partial class BalanceType4Choice_
    #endif
    {
    }
}
