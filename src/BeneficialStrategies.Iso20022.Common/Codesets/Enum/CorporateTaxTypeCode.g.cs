﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateTaxTypeCode.  ISO2002 ID# _tIBiYP4zEeix6ug6HlF6IQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the corporate tax identification type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tIBiYP4zEeix6ug6HlF6IQ")]
[Description(@"Indicates the corporate tax identification type.")]
[Derivations(typeof(CorporateTaxType1Code))]
public enum CorporateTaxTypeCode
{
    /// <summary>
    /// Corporate
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_tID-oP4zEeix6ug6HlF6IQ")]
    [Description(@"Corporate")]
    Corporate,
    
    /// <summary>
    /// Small Business
    /// Encoded/decoded by serializers as "SMBS".
    /// </summary>
    [EnumMember(Value = "SMBS")]
    [IsoId("_tICJcv4zEeix6ug6HlF6IQ")]
    [Description(@"Small Business")]
    SmallBusiness,
    
    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tICJcP4zEeix6ug6HlF6IQ")]
    [Description(@"Other")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateTaxTypeCodeMetadataExtensions
{
    private static readonly CorporateTaxTypeCodeDropdownSource _dropdownSource = new CorporateTaxTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateTaxTypeCodeDropdownRow GetMetadata(this CorporateTaxTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


