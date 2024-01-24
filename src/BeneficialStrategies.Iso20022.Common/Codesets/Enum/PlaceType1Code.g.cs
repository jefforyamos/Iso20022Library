﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PlaceType1Code.  ISO2002 ID# _aHWBcdp-Ed-ak6NoX_4Aeg_-1566893898.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHWBcdp-Ed-ak6NoX_4Aeg_-1566893898")]
[Description(@"Type of date.")]
[DerivedFrom(typeof(PlaceTypeCode))]
public enum PlaceType1Code
{
    /// <summary>
    /// The type of place is unknown.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aHWBctp-Ed-ak6NoX_4Aeg_-1566893880")]
    [Description(@"The type of place is unknown.")]
    Unknown = PlaceTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PlaceType1CodeMetadataExtensions
{
    private static readonly PlaceType1CodeDropdownSource _dropdownSource = new PlaceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPlaceType1CodeDropdownRow GetMetadata(this PlaceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


