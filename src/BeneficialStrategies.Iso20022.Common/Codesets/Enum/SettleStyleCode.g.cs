﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettleStyleCode.  ISO2002 ID# _ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when the option contract settles.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218")]
[Description(@"Specifies when the option contract settles.")]
[Derivations(typeof(SettleStyle1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SettleStyleCode
{
    /// <summary>
    /// Settlement is only allowed on the opening of the future contract.
    /// Encoded/decoded by serializers as "SETO".
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_ZOa1Y9p-Ed-ak6NoX_4Aeg_1626303304")]
    [Description(@"Settlement is only allowed on the opening of the future contract.")]
    SettleOnOpen,
    
    /// <summary>
    /// Settlement is only allowed on the closing of the future contract.
    /// Encoded/decoded by serializers as "SETC".
    /// </summary>
    [EnumMember(Value = "SETC")]
    [IsoId("_ZOa1ZNp-Ed-ak6NoX_4Aeg_1627226825")]
    [Description(@"Settlement is only allowed on the closing of the future contract.")]
    SettleOnClose,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettleStyleCodeMetadataExtensions
{
    private static readonly SettleStyleCodeDropdownSource _dropdownSource = new SettleStyleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettleStyleCodeDropdownRow GetMetadata(this SettleStyleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


