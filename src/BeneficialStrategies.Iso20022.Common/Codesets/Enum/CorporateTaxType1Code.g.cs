﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateTaxType1Code.  ISO2002 ID# _YZOAkC7REemIy6A-26wnAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the corporate tax identification type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZOAkC7REemIy6A-26wnAg")]
[Description(@"Indicates the corporate tax identification type.")]
[DerivedFrom(typeof(CorporateTaxTypeCode))]
public enum CorporateTaxType1Code
{
    /// <summary>
    /// Small Business
    /// Encoded/decoded by serializers as "SMBS".
    /// </summary>
    [EnumMember(Value = "SMBS")]
    [IsoId("_aEAucS7REemIy6A-26wnAg")]
    [Description(@"Small Business")]
    SmallBusiness = CorporateTaxTypeCode.SmallBusiness, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aIZfMS7REemIy6A-26wnAg")]
    [Description(@"Other")]
    Other = CorporateTaxTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aMSgsS7REemIy6A-26wnAg")]
    [Description(@"Corporate")]
    Corporate = CorporateTaxTypeCode.Corporate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateTaxType1CodeMetadataExtensions
{
    private static readonly CorporateTaxType1CodeDropdownSource _dropdownSource = new CorporateTaxType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateTaxType1CodeDropdownRow GetMetadata(this CorporateTaxType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


