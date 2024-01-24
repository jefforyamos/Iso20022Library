﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionStyle3Code.  ISO2002 ID# _aQR7ANp-Ed-ak6NoX_4Aeg_-2146072718.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQR7ANp-Ed-ak6NoX_4Aeg_-2146072718")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle3Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as "AMER".
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_aQR7Adp-Ed-ak6NoX_4Aeg_-930718664")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as "EURO".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aQR7Atp-Ed-ak6NoX_4Aeg_1489236661")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.
    /// Encoded/decoded by serializers as "ASIA".
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_aQR7A9p-Ed-ak6NoX_4Aeg_1517866290")]
    [Description(@"Option where the payoff is not determined by the underlying price at maturity but by the average underlying price over some pre-set period of time.")]
    Asian = OptionStyleCode.Asian, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionStyle3CodeMetadataExtensions
{
    private static readonly OptionStyle3CodeDropdownSource _dropdownSource = new OptionStyle3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionStyle3CodeDropdownRow GetMetadata(this OptionStyle3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


