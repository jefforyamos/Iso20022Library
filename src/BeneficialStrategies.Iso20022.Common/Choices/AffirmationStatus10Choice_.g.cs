﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AffirmationStatus10Choice.  ISO2002 ID# _O8WS8Qd3Ee2fOITqoTnSLQ.
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
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus10Choice.Code))]
    [KnownType(typeof(AffirmationStatus10Choice.Proprietary))]
    [IsoId("_O8WS8Qd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus10Choice_
    #else
    public abstract partial class AffirmationStatus10Choice_
    #endif
    {
    }
}
