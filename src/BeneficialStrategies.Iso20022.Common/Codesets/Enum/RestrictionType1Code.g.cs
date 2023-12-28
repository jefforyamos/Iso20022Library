﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionType1Code.  ISO2002 ID# _hbcArmliEeGaMcKyqKNRfQ_2033612003.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcArmliEeGaMcKyqKNRfQ_2033612003")]
[Description(@"Specifies the type of restriction.")]
[DerivedFrom(typeof(RestrictionTypeCode))]
public enum RestrictionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Selling".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbcAr2liEeGaMcKyqKNRfQ_-1297174021")]
    [Description(@"??")]
    Selling,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Buying".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbcAsGliEeGaMcKyqKNRfQ_-268302593")]
    [Description(@"??")]
    Buying,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Placing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbcAsWliEeGaMcKyqKNRfQ_809717745")]
    [Description(@"??")]
    Placing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Holding".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hblKkGliEeGaMcKyqKNRfQ_-1548024378")]
    [Description(@"??")]
    Holding,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Voting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hblKkWliEeGaMcKyqKNRfQ_798618968")]
    [Description(@"??")]
    Voting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionType1CodeMetadataExtensions
{
    private static readonly RestrictionType1CodeDropdownSource _dropdownSource = new RestrictionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionType1CodeDropdownRow GetMetadata(this RestrictionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


