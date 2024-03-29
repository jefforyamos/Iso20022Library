﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrument62Choice.  ISO2002 ID# _pv-M0Zy1Eem54rMzia0iag.
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
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument62Choice.Security))]
    [KnownType(typeof(FinancialInstrument62Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument62Choice.OtherAsset))]
    [IsoId("_pv-M0Zy1Eem54rMzia0iag")]
    [DisplayName("Financial Instrument 62 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument62Choice_
    #else
    public abstract partial class FinancialInstrument62Choice_
    #endif
    {
    }
}
