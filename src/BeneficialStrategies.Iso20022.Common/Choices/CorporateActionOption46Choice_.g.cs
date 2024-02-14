﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionOption46Choice.  ISO2002 ID# _ZHey_x9REeuFz_FaCzCLgQ.
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
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption46Choice.Code))]
    [KnownType(typeof(CorporateActionOption46Choice.Proprietary))]
    [IsoId("_ZHey_x9REeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Option 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption46Choice_
    #else
    public abstract partial class CorporateActionOption46Choice_
    #endif
    {
    }
}
