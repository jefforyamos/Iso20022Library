﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeTransactionCondition1Choice.  ISO2002 ID# _QtCDINp-Ed-ak6NoX_4Aeg_-1725642447.
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
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition1Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition1Choice.Proprietary))]
    [IsoId("_QtCDINp-Ed-ak6NoX_4Aeg_-1725642447")]
    [DisplayName("Trade Transaction Condition 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeTransactionCondition1Choice_
    #else
    public abstract partial class TradeTransactionCondition1Choice_
    #endif
    {
    }
}
