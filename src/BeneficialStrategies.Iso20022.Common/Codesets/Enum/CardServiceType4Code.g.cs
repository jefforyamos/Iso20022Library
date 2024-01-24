﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardServiceType4Code.  ISO2002 ID# _B1inEE-DEeePXdaAO32Uew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_B1inEE-DEeePXdaAO32Uew")]
[Description(@"Type of reconciliation.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
public enum CardServiceType4Code
{
    /// <summary>
    /// Partial reconciliation of the day.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_GQgWgU-DEeePXdaAO32Uew")]
    [Description(@"Partial reconciliation of the day.")]
    CheckPoint = CardServiceTypeCode.CheckPoint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final reconciliation.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_HStaYk-DEeePXdaAO32Uew")]
    [Description(@"Final reconciliation.")]
    Final = CardServiceTypeCode.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National defined code.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_H7LIkk-DEeePXdaAO32Uew")]
    [Description(@"National defined code.")]
    OtherNational = CardServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private defined code.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_IH-Ock-DEeePXdaAO32Uew")]
    [Description(@"Private defined code.")]
    OtherPrivate = CardServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardServiceType4CodeMetadataExtensions
{
    private static readonly CardServiceType4CodeDropdownSource _dropdownSource = new CardServiceType4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardServiceType4CodeDropdownRow GetMetadata(this CardServiceType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


