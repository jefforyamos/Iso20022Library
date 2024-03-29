﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity46Choice.  ISO2002 ID# _DcYV6DT5Ee2j2eQlcOSMKg.
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
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.DigitalTokenUnit))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.Code))]
    [IsoId("_DcYV6DT5Ee2j2eQlcOSMKg")]
    [DisplayName("Financial Instrument Quantity 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity46Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity46Choice_
    #endif
    {
    }
}
