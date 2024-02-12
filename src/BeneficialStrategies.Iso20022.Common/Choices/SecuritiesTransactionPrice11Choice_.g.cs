﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionPrice11Choice.  ISO2002 ID# _MR5i6c1VEem4K5qLxnWwMA.
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
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.BasisPoints))]
    [IsoId("_MR5i6c1VEem4K5qLxnWwMA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Transaction Price 11 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice11Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice11Choice_
    #endif
    {
    }
}
