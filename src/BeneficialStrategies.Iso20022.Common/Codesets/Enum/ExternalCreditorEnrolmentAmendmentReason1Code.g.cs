﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorEnrolmentAmendmentReason1Code.  ISO2002 ID# _S1ANkvDCEemsS_0xy2XRug.
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
[IsoId("_S1ANkvDCEemsS_0xy2XRug")]
[Description(@"Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalCreditorEnrolmentAmendmentReasonCode))]
public enum ExternalCreditorEnrolmentAmendmentReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as "AM05".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuIUWPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalCreditorEnrolmentAmendmentReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as "RF01".
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uuIUW_RYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalCreditorEnrolmentAmendmentReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as "RR04".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uuSFUvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalCreditorEnrolmentAmendmentReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as "TRJT".
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uuSFVfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalCreditorEnrolmentAmendmentReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as "UCRD".
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uuSFWPRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalCreditorEnrolmentAmendmentReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCreditorEnrolmentAmendmentReason1CodeMetadataExtensions
{
    private static readonly ExternalCreditorEnrolmentAmendmentReason1CodeDropdownSource _dropdownSource = new ExternalCreditorEnrolmentAmendmentReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCreditorEnrolmentAmendmentReason1CodeDropdownRow GetMetadata(this ExternalCreditorEnrolmentAmendmentReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


