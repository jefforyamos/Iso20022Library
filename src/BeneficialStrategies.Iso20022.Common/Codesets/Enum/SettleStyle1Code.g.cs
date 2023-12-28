﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettleStyle1Code.  ISO2002 ID# _ZOREZNp-Ed-ak6NoX_4Aeg_-1482938751.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when the option contract settles.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOREZNp-Ed-ak6NoX_4Aeg_-1482938751")]
[Description(@"Specifies when the option contract settles.")]
[DerivedFrom(typeof(SettleStyleCode))]
public enum SettleStyle1Code
{
    /// <summary>
    /// Settlement is only allowed on the closing of the future contract.
    /// Encoded/decoded by serializers as "SettleOnClose".
    /// </summary>
    [EnumMember(Value = "SETC")]
    [IsoId("_ZOa1YNp-Ed-ak6NoX_4Aeg_-1439531144")]
    [Description(@"Settlement is only allowed on the closing of the future contract.")]
    SettleOnClose,
    
    /// <summary>
    /// Settlement is only allowed on the opening of the future contract.
    /// Encoded/decoded by serializers as "SettleOnOpen".
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_ZOa1Ydp-Ed-ak6NoX_4Aeg_-1439531109")]
    [Description(@"Settlement is only allowed on the opening of the future contract.")]
    SettleOnOpen,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettleStyle1CodeMetadataExtensions
{
    private static readonly SettleStyle1CodeDropdownSource _dropdownSource = new SettleStyle1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettleStyle1CodeDropdownRow GetMetadata(this SettleStyle1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


