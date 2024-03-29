﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity43Choice.  ISO2002 ID# _ptGAfzi7Eeydid5dcNPKvg.
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
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit))]
    [IsoId("_ptGAfzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity43Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity43Choice_
    #endif
    {
    }
}
