﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCategory1Code.  ISO2002 ID# _TTQlUgEcEeCQm6a_G2yO_w_401559989.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Location category code of the place where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTQlUgEcEeCQm6a_G2yO_w_401559989")]
[Description(@"Location category code of the place where the merchant actually performed the transaction.")]
[DerivedFrom(typeof(LocationCategoryCode))]
public enum LocationCategory1Code
{
    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as "MOTO".
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_TTQlVgEcEeCQm6a_G2yO_w_121640327")]
    [Description(@"Mail order or telephone order.")]
    MailOrderTelephoneOrder = LocationCategoryCode.MailOrderTelephoneOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer home.
    /// Encoded/decoded by serializers as "HOME".
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_TTQlVwEcEeCQm6a_G2yO_w_-2133361507")]
    [Description(@"Customer home.")]
    Home = LocationCategoryCode.Home, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Aboard a bus, train, ship, airplane, taxi, etc.
    /// Encoded/decoded by serializers as "ABRD".
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_4fqPEVDhEeuJG-g6zrGRtg")]
    [Description(@"Aboard a bus, train, ship, airplane, taxi, etc.")]
    Aboard = LocationCategoryCode.Aboard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as "FIXD".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_4tFAAVDhEeuJG-g6zrGRtg")]
    [Description(@"Fixed location, for example in a shop.")]
    Fixed = LocationCategoryCode.Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Nomadic location.
    /// Encoded/decoded by serializers as "NMDC".
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_6UozsVDhEeuJG-g6zrGRtg")]
    [Description(@"Nomadic location.")]
    Nomadic = LocationCategoryCode.Nomadic, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCategory1CodeMetadataExtensions
{
    private static readonly LocationCategory1CodeDropdownSource _dropdownSource = new LocationCategory1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCategory1CodeDropdownRow GetMetadata(this LocationCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


