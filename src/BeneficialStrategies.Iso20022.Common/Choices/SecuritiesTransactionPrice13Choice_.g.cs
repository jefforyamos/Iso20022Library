﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionPrice13Choice.  ISO2002 ID# _k-0NsQFMEeqUa4noT3P56A.
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
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.BasisPointSpread))]
    [IsoId("_k-0NsQFMEeqUa4noT3P56A")]
    [DisplayName("Securities Transaction Price 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice13Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice13Choice_
    #endif
    {
    }
}
