﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionTypeCode.  ISO2002 ID# _Y94fBdp-Ed-ak6NoX_4Aeg_-1122710739.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y94fBdp-Ed-ak6NoX_4Aeg_-1122710739")]
[Description(@"Specifies the type of restriction.")]
[Derivations(typeof(RestrictionType1Code))]
public enum RestrictionTypeCode
{
    /// <summary>
    /// Selling restriction.
    /// Encoded/decoded by serializers as "SELR".
    /// </summary>
    [EnumMember(Value = "SELR")]
    [IsoId("_Y94fBtp-Ed-ak6NoX_4Aeg_-1008194444")]
    [Description(@"Selling restriction.")]
    Selling,
    
    /// <summary>
    /// Buying restriction.
    /// Encoded/decoded by serializers as "BUYR".
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_Y94fB9p-Ed-ak6NoX_4Aeg_-1007271038")]
    [Description(@"Buying restriction.")]
    Buying,
    
    /// <summary>
    /// Placing restriction.
    /// Encoded/decoded by serializers as "PLAR".
    /// </summary>
    [EnumMember(Value = "PLAR")]
    [IsoId("_Y94fCNp-Ed-ak6NoX_4Aeg_-1006348350")]
    [Description(@"Placing restriction.")]
    Placing,
    
    /// <summary>
    /// Holding restriction.
    /// Encoded/decoded by serializers as "HOLR".
    /// </summary>
    [EnumMember(Value = "HOLR")]
    [IsoId("_Y-Bo8Np-Ed-ak6NoX_4Aeg_-1005425344")]
    [Description(@"Holding restriction.")]
    Holding,
    
    /// <summary>
    /// Voting restriction.
    /// Encoded/decoded by serializers as "VOTR".
    /// </summary>
    [EnumMember(Value = "VOTR")]
    [IsoId("_Y-Bo8dp-Ed-ak6NoX_4Aeg_-1004502316")]
    [Description(@"Voting restriction.")]
    Voting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionTypeCodeMetadataExtensions
{
    private static readonly RestrictionTypeCodeDropdownSource _dropdownSource = new RestrictionTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionTypeCodeDropdownRow GetMetadata(this RestrictionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


