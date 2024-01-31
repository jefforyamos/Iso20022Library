﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionStyle4Code.  ISO2002 ID# __viXkNojEeC60axPepSq7g_1741520571.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__viXkNojEeC60axPepSq7g_1741520571")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle4Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as "AMER".
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("__viXkdojEeC60axPepSq7g_227459046")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as "EURO".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("__viXktojEeC60axPepSq7g_552576553")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as "BERM".
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("__viXk9ojEeC60axPepSq7g_438737487")]
    [Description(@"Option that can be exercised on multiple discrete dates prior to, or on expiry date.")]
    Bermudan = OptionStyleCode.Bermudan, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionStyle4CodeMetadataExtensions
{
    private static readonly OptionStyle4CodeDropdownSource _dropdownSource = new OptionStyle4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionStyle4CodeDropdownRow GetMetadata(this OptionStyle4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


