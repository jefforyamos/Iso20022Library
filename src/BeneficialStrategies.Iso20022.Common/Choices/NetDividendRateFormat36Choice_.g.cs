﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat36Choice.  ISO2002 ID# _k9xM083xEee5nJBZsW8MFQ.
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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat36Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
    [IsoId("_k9xM083xEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat36Choice_
    #else
    public abstract partial class NetDividendRateFormat36Choice_
    #endif
    {
    }
}
