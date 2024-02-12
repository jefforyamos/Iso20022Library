﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentIdentification5Choice.  ISO2002 ID# _HH3GN35aEea2k7EBUopqxw.
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
    [KnownType(typeof(FinancialInstrumentIdentification5Choice.Single))]
    [KnownType(typeof(FinancialInstrumentIdentification5Choice.Basket))]
    [IsoId("_HH3GN35aEea2k7EBUopqxw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Identification 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentIdentification5Choice_
    #else
    public abstract partial class FinancialInstrumentIdentification5Choice_
    #endif
    {
    }
}
