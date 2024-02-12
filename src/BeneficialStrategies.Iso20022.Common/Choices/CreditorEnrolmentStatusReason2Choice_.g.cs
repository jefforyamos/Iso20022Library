﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CreditorEnrolmentStatusReason2Choice.  ISO2002 ID# _fW_fY-IxEeqbls7Gk4-ckA.
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
    /// Specifies the reason for the status of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Proprietary))]
    [IsoId("_fW_fY-IxEeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Enrolment Status Reason 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditorEnrolmentStatusReason2Choice_
    #else
    public abstract partial class CreditorEnrolmentStatusReason2Choice_
    #endif
    {
    }
}
