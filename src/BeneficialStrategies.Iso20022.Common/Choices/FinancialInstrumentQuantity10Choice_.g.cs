﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity10Choice.  ISO2002 ID# _RgmOF9p-Ed-ak6NoX_4Aeg_2104922749.
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
    /// Choice between ways to express the quantity of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.HoldingsRate))]
    [IsoId("_RgmOF9p-Ed-ak6NoX_4Aeg_2104922749")]
    [DisplayName("Financial Instrument Quantity 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity10Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity10Choice_
    #endif
    {
    }
}
