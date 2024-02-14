﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ConsentOrRejectionReason2Choice.  ISO2002 ID# _0fpplAlIEeGATtfOBToyew_1694942243.
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
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(ConsentOrRejectionReason2Choice.Code))]
    [KnownType(typeof(ConsentOrRejectionReason2Choice.Proprietary))]
    [IsoId("_0fpplAlIEeGATtfOBToyew_1694942243")]
    [DisplayName("Consent Or Rejection Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConsentOrRejectionReason2Choice_
    #else
    public abstract partial class ConsentOrRejectionReason2Choice_
    #endif
    {
    }
}
