﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModificationLevelCode.  ISO2002 ID# _ZzzfsQ3mEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction or position level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzzfsQ3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction or position level.")]
[Derivations(typeof(ModificationLevel1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ModificationLevelCode
{
    /// <summary>
    /// Modification applies to a position.
    /// Encoded/decoded by serializers as "PSTN".
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_d8LDQA3mEeWc7_0KPiuk6w")]
    [Description(@"Modification applies to a position.")]
    Position,
    
    /// <summary>
    /// Modification applies to a transaction.
    /// Encoded/decoded by serializers as "TCTN".
    /// </summary>
    [EnumMember(Value = "TCTN")]
    [IsoId("_ea0uIA3mEeWc7_0KPiuk6w")]
    [Description(@"Modification applies to a transaction.")]
    Transaction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ModificationLevelCodeMetadataExtensions
{
    private static readonly ModificationLevelCodeDropdownSource _dropdownSource = new ModificationLevelCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IModificationLevelCodeDropdownRow GetMetadata(this ModificationLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


