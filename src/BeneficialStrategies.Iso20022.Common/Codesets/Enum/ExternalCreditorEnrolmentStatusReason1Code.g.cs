﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorEnrolmentStatusReason1Code.  ISO2002 ID# _gtemoeIwEeqbls7Gk4-ckA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gtemoeIwEeqbls7Gk4-ckA")]
[Description(@"Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalCreditorEnrolmentStatusReasonCode))]
public enum ExternalCreditorEnrolmentStatusReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AlreadyExistingCreditor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uvUnJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AlreadyExistingCreditor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uvUnKPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Duplication,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidFileFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uvUnK_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InvalidFileFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotUniqueReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uveYIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NotUniqueReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegulatoryReason".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uveYJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RegulatoryReason,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidCharacterSet".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uvoJIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InvalidCharacterSet,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TechnicalRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uvoJJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TechnicalRejection,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCreditorEnrolmentStatusReason1CodeMetadataExtensions
{
    private static readonly ExternalCreditorEnrolmentStatusReason1CodeDropdownSource _dropdownSource = new ExternalCreditorEnrolmentStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCreditorEnrolmentStatusReason1CodeDropdownRow GetMetadata(this ExternalCreditorEnrolmentStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


