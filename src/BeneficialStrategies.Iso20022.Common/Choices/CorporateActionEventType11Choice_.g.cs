﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType11Choice.  ISO2002 ID# _SdmZwQ4xEeKVsZQr6J31Tg.
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
    [KnownType(typeof(CorporateActionEventType11Choice.Code))]
    [KnownType(typeof(CorporateActionEventType11Choice.Proprietary))]
    [IsoId("_SdmZwQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Corporate Action Event Type 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType11Choice_
    #else
    public abstract partial class CorporateActionEventType11Choice_
    #endif
    {
    }
}
