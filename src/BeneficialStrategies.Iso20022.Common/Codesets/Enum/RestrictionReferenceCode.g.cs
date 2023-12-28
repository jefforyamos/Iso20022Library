﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionReferenceCode.  ISO2002 ID# _s_iqUNarEei60tlze8Pqbw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Restriction References applied on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s_iqUNarEei60tlze8Pqbw")]
[Description(@"Restriction References applied on a transaction.")]
public enum RestrictionReferenceCode
{
    /// <summary>
    /// Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as "ADDS".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_zLkuwNarEei60tlze8Pqbw")]
    [Description(@"Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.")]
    AddSecuritiesRestrictionReference,
    
    /// <summary>
    /// Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. 
    /// Encoded/decoded by serializers as "REMS".
    /// </summary>
    [EnumMember(Value = "REMS")]
    [IsoId("_zR-RsNarEei60tlze8Pqbw")]
    [Description(@"Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. ")]
    RemoveSecuritiesRestrictionReference,
    
    /// <summary>
    /// Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as "ADDC".
    /// </summary>
    [EnumMember(Value = "ADDC")]
    [IsoId("_zYODoNarEei60tlze8Pqbw")]
    [Description(@"Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.")]
    AddCashRestrictionReference,
    
    /// <summary>
    /// Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as "REMC".
    /// </summary>
    [EnumMember(Value = "REMC")]
    [IsoId("_zdRiwNarEei60tlze8Pqbw")]
    [Description(@"Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.")]
    RemoveCashRestrictionReference,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionReferenceCodeMetadataExtensions
{
    private static readonly RestrictionReferenceCodeDropdownSource _dropdownSource = new RestrictionReferenceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionReferenceCodeDropdownRow GetMetadata(this RestrictionReferenceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


