﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentIdentification7Choice.  ISO2002 ID# _K9o5cYG-EeaalK9UbuVGFw.
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
    /// Choice for identifying the underlying instruments that a derivative can consist of.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification7Choice.Single))]
    [KnownType(typeof(FinancialInstrumentIdentification7Choice.Basket))]
    [IsoId("_K9o5cYG-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument Identification 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentIdentification7Choice_
    #else
    public abstract partial class FinancialInstrumentIdentification7Choice_
    #endif
    {
    }
}
