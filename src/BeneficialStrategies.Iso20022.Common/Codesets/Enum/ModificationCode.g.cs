﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModificationCode.  ISO2002 ID# _d9DQsA4SEeKGXqvMN6jpiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if an item is added, modified, deleted or unchanged.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d9DQsA4SEeKGXqvMN6jpiw")]
[Description(@"Specifies if an item is added, modified, deleted or unchanged.")]
public enum ModificationCode
{
    /// <summary>
    /// Specifies that the item is added.
    /// Encoded/decoded by serializers as "ADDD".
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_m-gDEA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is added.")]
    Addition,
    
    /// <summary>
    /// Specifies that the item is deleted.
    /// Encoded/decoded by serializers as "DELE".
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_sspRoA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is deleted.")]
    Deletion,
    
    /// <summary>
    /// Specifies that the item is modified.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_xaHGUA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is modified.")]
    Modification,
    
    /// <summary>
    /// Specifies that the item is not changed.
    /// Encoded/decoded by serializers as "NOCH".
    /// </summary>
    [EnumMember(Value = "NOCH")]
    [IsoId("_0_AwcA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is not changed.")]
    NoChange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ModificationCodeMetadataExtensions
{
    private static readonly ModificationCodeDropdownSource _dropdownSource = new ModificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IModificationCodeDropdownRow GetMetadata(this ModificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

