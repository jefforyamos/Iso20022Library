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
    /// Byte.
    /// Encoded/decoded by serializers as "Byte".
    /// </summary>
    [EnumMember(Value = "BYTE")]
    [IsoId("_1rmBMQxzEeKa_56Jbsi1RQ")]
    [Description(@"Byte.")]
    Byte,
    
    /// <summary>
    /// Exa byte.
    /// Encoded/decoded by serializers as "ExaByte".
    /// </summary>
    [EnumMember(Value = "EXAB")]
    [IsoId("_1yuj8wxzEeKa_56Jbsi1RQ")]
    [Description(@"Exa byte.")]
    ExaByte,
    
    /// <summary>
    /// Giga byte.
    /// Encoded/decoded by serializers as "GigaByte".
    /// </summary>
    [EnumMember(Value = "GIGA")]
    [IsoId("_17gsgwxzEeKa_56Jbsi1RQ")]
    [Description(@"Giga byte.")]
    GigaByte,
    
    /// <summary>
    /// Kilo byte.
    /// Encoded/decoded by serializers as "KiloByte".
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_2AkLowxzEeKa_56Jbsi1RQ")]
    [Description(@"Kilo byte.")]
    KiloByte,
    
    /// <summary>
    /// Mega byte.
    /// Encoded/decoded by serializers as "MegaByte".
    /// </summary>
    [EnumMember(Value = "MEGA")]
    [IsoId("_2HQpgQxzEeKa_56Jbsi1RQ")]
    [Description(@"Mega byte.")]
    MegaByte,
    
    /// <summary>
    /// Peta byte.
    /// Encoded/decoded by serializers as "PetaByte".
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_2O_pMQxzEeKa_56Jbsi1RQ")]
    [Description(@"Peta byte.")]
    PetaByte,
    
    /// <summary>
    /// Tera byte.
    /// Encoded/decoded by serializers as "TeraByte".
    /// </summary>
    [EnumMember(Value = "TERA")]
    [IsoId("_2fgxcQxzEeKa_56Jbsi1RQ")]
    [Description(@"Tera byte.")]
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


