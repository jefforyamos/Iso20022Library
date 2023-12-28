﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPackagingTypeCode.  ISO2002 ID# _JdeN8PeZEee0h5ZXun0VTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the packaging type as published in an external packaging type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JdeN8PeZEee0h5ZXun0VTA")]
[Description(@"Specifies the packaging type as published in an external packaging type code list. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalPackagingTypeCode
{
    /// <summary>
    /// Packaging is high density polyethylene.
    /// Encoded/decoded by serializers as "HDPE".
    /// </summary>
    [EnumMember(Value = "HDPE")]
    [IsoId("_uIlXSfRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is high density polyethylene.")]
    HighDensityPolyethylene,
    
    /// <summary>
    /// Packaging is low density polyethylene.
    /// Encoded/decoded by serializers as "LDPE".
    /// </summary>
    [EnumMember(Value = "LDPE")]
    [IsoId("_uIlXTPRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is low density polyethylene.")]
    LowDensityPolyethylene,
    
    /// <summary>
    /// Packaging is linear low density polyethylene.
    /// Encoded/decoded by serializers as "LLDP".
    /// </summary>
    [EnumMember(Value = "LLDP")]
    [IsoId("_uIvIQPRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is linear low density polyethylene.")]
    LinearLowDensityPolyethylene,
    
    /// <summary>
    /// Other packaging type not otherwise specified.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIvIQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Other packaging type not otherwise specified.")]
    OtherPackagingType,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPackagingTypeCodeMetadataExtensions
{
    private static readonly ExternalPackagingTypeCodeDropdownSource _dropdownSource = new ExternalPackagingTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPackagingTypeCodeDropdownRow GetMetadata(this ExternalPackagingTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


