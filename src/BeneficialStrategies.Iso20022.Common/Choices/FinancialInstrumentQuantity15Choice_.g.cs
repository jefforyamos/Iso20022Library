﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity15Choice.  ISO2002 ID# _Wr_79dp-Ed-ak6NoX_4Aeg_695777575.
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
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.AmortisedValue))]
    [IsoId("_Wr_79dp-Ed-ak6NoX_4Aeg_695777575")]
    [DisplayName("Financial Instrument Quantity 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity15Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity15Choice_
    #endif
    {
    }
}
