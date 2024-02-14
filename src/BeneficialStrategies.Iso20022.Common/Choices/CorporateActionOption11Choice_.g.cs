﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionOption11Choice.  ISO2002 ID# _onpwcQq_EeGFLZ_5tFfOnw.
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
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption11Choice.Code))]
    [KnownType(typeof(CorporateActionOption11Choice.Proprietary))]
    [IsoId("_onpwcQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Corporate Action Option 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption11Choice_
    #else
    public abstract partial class CorporateActionOption11Choice_
    #endif
    {
    }
}
