﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity31Choice.  ISO2002 ID# _CUJft89pEee4rfBIKt5cSg.
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
    [KnownType(typeof(FinancialInstrumentQuantity31Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity31Choice.FaceAmount))]
    [IsoId("_CUJft89pEee4rfBIKt5cSg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Quantity 31 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity31Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity31Choice_
    #endif
    {
    }
}
