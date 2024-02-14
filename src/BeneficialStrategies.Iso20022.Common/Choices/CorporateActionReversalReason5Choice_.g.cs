﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionReversalReason5Choice.  ISO2002 ID# _ryV6pzQVEe2o-K1dwNg8Gg.
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
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason5Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason5Choice.Proprietary))]
    [IsoId("_ryV6pzQVEe2o-K1dwNg8Gg")]
    [DisplayName("Corporate Action Reversal Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionReversalReason5Choice_
    #else
    public abstract partial class CorporateActionReversalReason5Choice_
    #endif
    {
    }
}
