﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingDate1Code.  ISO2002 ID# __zj79dojEeC60axPepSq7g_1662306334.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Trading Date Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__zj79dojEeC60axPepSq7g_1662306334")]
[Description(@"Trading Date Code.")]
[DerivedFrom(typeof(TradingDateCode))]
public enum TradingDate1Code
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as "VARI".
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("__ztF4NojEeC60axPepSq7g_2007838442")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various = TradingDateCode.Various, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingDate1CodeMetadataExtensions
{
    private static readonly TradingDate1CodeDropdownSource _dropdownSource = new TradingDate1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingDate1CodeDropdownRow GetMetadata(this TradingDate1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


