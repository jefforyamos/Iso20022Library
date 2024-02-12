﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat2Choice.  ISO2002 ID# _UM2Y9tp-Ed-ak6NoX_4Aeg_-319728264.
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
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat2Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_UM2Y9tp-Ed-ak6NoX_4Aeg_-319728264")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Dividend Rate Format 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat2Choice_
    #else
    public abstract partial class NetDividendRateFormat2Choice_
    #endif
    {
    }
}
