﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModificationLevel1Code.  ISO2002 ID# _khDskA3mEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction or position level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_khDskA3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction or position level.")]
[DerivedFrom(typeof(ModificationLevelCode))]
public enum ModificationLevel1Code
{
    /// <summary>
    /// Modification applies to a position.
    /// Encoded/decoded by serializers as "PSTN".
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_YvcnEbSZEeeTnocDRx5mhw")]
    [Description(@"Modification applies to a position.")]
    Position = ModificationLevelCode.Position, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification applies to a transaction.
    /// Encoded/decoded by serializers as "TCTN".
    /// </summary>
    [EnumMember(Value = "TCTN")]
    [IsoId("_Y83YAbSZEeeTnocDRx5mhw")]
    [Description(@"Modification applies to a transaction.")]
    Transaction = ModificationLevelCode.Transaction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ModificationLevel1CodeMetadataExtensions
{
    private static readonly ModificationLevel1CodeDropdownSource _dropdownSource = new ModificationLevel1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IModificationLevel1CodeDropdownRow GetMetadata(this ModificationLevel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


