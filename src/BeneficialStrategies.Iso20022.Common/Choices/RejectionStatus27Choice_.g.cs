﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionStatus27Choice.  ISO2002 ID# _Vl2wcZNSEeWGlc8L7oPDIg.
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
    /// Choice of rejection status.
    /// </summary>
    [KnownType(typeof(RejectionStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus27Choice.Reason))]
    [IsoId("_Vl2wcZNSEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus27Choice_
    #else
    public abstract partial class RejectionStatus27Choice_
    #endif
    {
    }
}
