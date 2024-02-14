﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceRateOrAmountOrUnknown3Choice.  ISO2002 ID# _gdOxl833Eee5nJBZsW8MFQ.
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
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.UnknownIndicator))]
    [IsoId("_gdOxl833Eee5nJBZsW8MFQ")]
    [DisplayName("Price Rate Or Amount Or Unknown 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmountOrUnknown3Choice_
    #else
    public abstract partial class PriceRateOrAmountOrUnknown3Choice_
    #endif
    {
    }
}
