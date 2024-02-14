﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType57Choice.  ISO2002 ID# _sb-57ZwqEeazcsnODTksnQ.
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
    [KnownType(typeof(CorporateActionEventType57Choice.Code))]
    [KnownType(typeof(CorporateActionEventType57Choice.Proprietary))]
    [IsoId("_sb-57ZwqEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType57Choice_
    #else
    public abstract partial class CorporateActionEventType57Choice_
    #endif
    {
    }
}
