﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType42Choice.  ISO2002 ID# _cslQ45KQEeWHWpTQn1FFVg.
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
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType42Choice.Code))]
    [KnownType(typeof(CorporateActionEventType42Choice.Proprietary))]
    [IsoId("_cslQ45KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Type 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType42Choice_
    #else
    public abstract partial class CorporateActionEventType42Choice_
    #endif
    {
    }
}
