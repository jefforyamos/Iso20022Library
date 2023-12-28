﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MoveType1Code.  ISO2002 ID# _aMtCltp-Ed-ak6NoX_4Aeg_-1643565851.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes whether peg or discretion price is static/fixed or floats.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aMtCltp-Ed-ak6NoX_4Aeg_-1643565851")]
[Description(@"Describes whether peg or discretion price is static/fixed or floats.")]
[DerivedFrom(typeof(MoveTypeCode))]
public enum MoveType1Code
{
    /// <summary>
    /// Indicates that the peg is static/fixed.
    /// Encoded/decoded by serializers as "Static".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_aMtCl9p-Ed-ak6NoX_4Aeg_-1360046424")]
    [Description(@"Indicates that the peg is static/fixed.")]
    Static,
    
    /// <summary>
    /// Indicates that peg floats.
    /// Encoded/decoded by serializers as "Float".
    /// </summary>
    [EnumMember(Value = "FLOA")]
    [IsoId("_aM2zkNp-Ed-ak6NoX_4Aeg_-1360046141")]
    [Description(@"Indicates that peg floats.")]
    Float,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MoveType1CodeMetadataExtensions
{
    private static readonly MoveType1CodeDropdownSource _dropdownSource = new MoveType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMoveType1CodeDropdownRow GetMetadata(this MoveType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


