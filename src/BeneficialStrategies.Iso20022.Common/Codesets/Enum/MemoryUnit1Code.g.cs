﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MemoryUnit1Code.  ISO2002 ID# _0NRCAAxzEeKa_56Jbsi1RQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unit of the memory size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0NRCAAxzEeKa_56Jbsi1RQ")]
[Description(@"Unit of the memory size.")]
[DerivedFrom(typeof(MemoryUnitCode))]
public enum MemoryUnit1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Byte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1rmBMQxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    Byte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExaByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1yuj8wxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    ExaByte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GigaByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_17gsgwxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    GigaByte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "KiloByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2AkLowxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    KiloByte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MegaByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2HQpgQxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    MegaByte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PetaByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2O_pMQxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    PetaByte,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TeraByte".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2fgxcQxzEeKa_56Jbsi1RQ")]
    [Description(@"??")]
    TeraByte,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MemoryUnit1CodeMetadataExtensions
{
    private static readonly MemoryUnit1CodeDropdownSource _dropdownSource = new MemoryUnit1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMemoryUnit1CodeDropdownRow GetMetadata(this MemoryUnit1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

