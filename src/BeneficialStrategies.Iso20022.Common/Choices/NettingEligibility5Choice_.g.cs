﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NettingEligibility5Choice.  ISO2002 ID# _5m6oEZNLEeWGlc8L7oPDIg.
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
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility5Choice.Indicator))]
    [KnownType(typeof(NettingEligibility5Choice.Proprietary))]
    [IsoId("_5m6oEZNLEeWGlc8L7oPDIg")]
    [DisplayName("Netting Eligibility 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NettingEligibility5Choice_
    #else
    public abstract partial class NettingEligibility5Choice_
    #endif
    {
    }
}
