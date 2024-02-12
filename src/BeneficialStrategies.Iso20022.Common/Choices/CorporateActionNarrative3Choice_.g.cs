﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionNarrative3Choice.  ISO2002 ID# _7s0bd0GVEeWqy4niLuXETA.
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
    /// Choice between a standard code or a proprietary code to specify the narrative type of corporate action.
    /// </summary>
    [KnownType(typeof(CorporateActionNarrative3Choice.Code))]
    [KnownType(typeof(CorporateActionNarrative3Choice.Proprietary))]
    [IsoId("_7s0bd0GVEeWqy4niLuXETA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Narrative 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionNarrative3Choice_
    #else
    public abstract partial class CorporateActionNarrative3Choice_
    #endif
    {
    }
}
