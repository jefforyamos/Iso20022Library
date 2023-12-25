﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorEnrolmentAmendmentReasonCode.  ISO2002 ID# _S1ANk_DCEemsS_0xy2XRug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S1ANk_DCEemsS_0xy2XRug")]
[Description(@"Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalCreditorEnrolmentAmendmentReasonCode
{
    /// <summary>
    /// Duplication.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuIUVvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    AM05,
    
    /// <summary>
    /// Reference is not unique.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uuIUWfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    RF01,
    
    /// <summary>
    /// Regulatory Reason.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uuSFUPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RR04,
    
    /// <summary>
    /// Technical rejection.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_E5wqofDWEemsS_0xy2XRug")]
    [Description(@"Technical rejection.")]
    TRJT,
    
    /// <summary>
    /// Unknown creditor.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_Ci0BYPDWEemsS_0xy2XRug")]
    [Description(@"Unknown creditor.")]
    UCRD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCreditorEnrolmentAmendmentReasonCodeMetadataExtensions
{
    private static readonly ExternalCreditorEnrolmentAmendmentReasonCodeDropdownSource _dropdownSource = new ExternalCreditorEnrolmentAmendmentReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCreditorEnrolmentAmendmentReasonCodeDropdownRow GetMetadata(this ExternalCreditorEnrolmentAmendmentReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


