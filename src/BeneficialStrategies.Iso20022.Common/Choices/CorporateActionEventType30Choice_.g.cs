﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType30Choice.  ISO2002 ID# _9_IywTqDEeWVrPy0StzzSg.
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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType30Choice.Code))]
    [KnownType(typeof(CorporateActionEventType30Choice.Proprietary))]
    [IsoId("_9_IywTqDEeWVrPy0StzzSg")]
    [DisplayName("Corporate Action Event Type 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType30Choice_
    #else
    public abstract partial class CorporateActionEventType30Choice_
    #endif
    {
    }
}
