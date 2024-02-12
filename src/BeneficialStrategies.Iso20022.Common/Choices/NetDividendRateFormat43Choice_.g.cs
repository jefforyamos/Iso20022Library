﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat43Choice.  ISO2002 ID# _bZ6BiwVTEeqjd8n6wD9JVw.
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
    [KnownType(typeof(NetDividendRateFormat43Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat43Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat43Choice.NotSpecifiedRate))]
    [IsoId("_bZ6BiwVTEeqjd8n6wD9JVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Dividend Rate Format 43 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat43Choice_
    #else
    public abstract partial class NetDividendRateFormat43Choice_
    #endif
    {
    }
}
