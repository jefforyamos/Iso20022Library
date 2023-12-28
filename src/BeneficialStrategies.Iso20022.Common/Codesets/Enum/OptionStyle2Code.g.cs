﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionStyle2Code.  ISO2002 ID# _aQIxFtp-Ed-ak6NoX_4Aeg_-1177091144.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQIxFtp-Ed-ak6NoX_4Aeg_-1177091144")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "American".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQIxF9p-Ed-ak6NoX_4Aeg_-1107826186")]
    [Description(@"??")]
    American,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "European".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQIxGNp-Ed-ak6NoX_4Aeg_-1107826168")]
    [Description(@"??")]
    European,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionStyle2CodeMetadataExtensions
{
    private static readonly OptionStyle2CodeDropdownSource _dropdownSource = new OptionStyle2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionStyle2CodeDropdownRow GetMetadata(this OptionStyle2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


