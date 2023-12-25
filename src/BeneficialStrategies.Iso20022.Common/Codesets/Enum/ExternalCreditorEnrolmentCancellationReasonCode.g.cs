﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorEnrolmentCancellationReasonCode.  ISO2002 ID# _EvdPM_DCEemsS_0xy2XRug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EvdPM_DCEemsS_0xy2XRug")]
[Description(@"Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalCreditorEnrolmentCancellationReasonCode
{
    /// <summary>
    /// Duplication.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuuxQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    AM05,
    
    /// <summary>
    /// Reference is not unique.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uu37MPRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    RF01,
    
    /// <summary>
    /// Regulatory Reason.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uu37M_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RR04,
    
    /// <summary>
    /// Technical rejection.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uu37NvRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TRJT,
    
    /// <summary>
    /// Unknown creditor.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uu37OfRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UCRD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCreditorEnrolmentCancellationReasonCodeMetadataExtensions
{
    private static readonly ExternalCreditorEnrolmentCancellationReasonCodeDropdownSource _dropdownSource = new ExternalCreditorEnrolmentCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCreditorEnrolmentCancellationReasonCodeDropdownRow GetMetadata(this ExternalCreditorEnrolmentCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


