﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorEnrolmentAmendmentReasonCode.  ISO2002 ID# _S1ANk_DCEemsS_0xy2XRug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S1ANk_DCEemsS_0xy2XRug")]
[Description(@"Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalCreditorEnrolmentAmendmentReason1Code))]
public enum ExternalCreditorEnrolmentAmendmentReasonCode
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as "AM05".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuIUVvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as "RF01".
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uuIUWfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as "RR04".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uuSFUPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as "TRJT".
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_E5wqofDWEemsS_0xy2XRug")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as "UCRD".
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_Ci0BYPDWEemsS_0xy2XRug")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
    
}
