﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MemoryUnitCode.  ISO2002 ID# _CoXPEAxzEeKa_56Jbsi1RQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unit of the memory size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CoXPEAxzEeKa_56Jbsi1RQ")]
[Description(@"Unit of the memory size.")]
[Derivations(typeof(MemoryUnit1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MemoryUnitCode
{
    /// <summary>
    /// Exa byte.
    /// Encoded/decoded by serializers as "EXAB".
    /// </summary>
    [EnumMember(Value = "EXAB")]
    [IsoId("_Hr9EwAxzEeKa_56Jbsi1RQ")]
    [Description(@"Exa byte.")]
    ExaByte,
    
    /// <summary>
    /// Peta byte.
    /// Encoded/decoded by serializers as "PETA".
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_R05qsAxzEeKa_56Jbsi1RQ")]
    [Description(@"Peta byte.")]
    PetaByte,
    
    /// <summary>
    /// Tera byte.
    /// Encoded/decoded by serializers as "TERA".
    /// </summary>
    [EnumMember(Value = "TERA")]
    [IsoId("_cCdq4AxzEeKa_56Jbsi1RQ")]
    [Description(@"Tera byte.")]
    TeraByte,
    
    /// <summary>
    /// Giga byte.
    /// Encoded/decoded by serializers as "GIGA".
    /// </summary>
    [EnumMember(Value = "GIGA")]
    [IsoId("_hkizYAxzEeKa_56Jbsi1RQ")]
    [Description(@"Giga byte.")]
    GigaByte,
    
    /// <summary>
    /// Mega byte.
    /// Encoded/decoded by serializers as "MEGA".
    /// </summary>
    [EnumMember(Value = "MEGA")]
    [IsoId("_lTyFQAxzEeKa_56Jbsi1RQ")]
    [Description(@"Mega byte.")]
    MegaByte,
    
    /// <summary>
    /// Kilo byte.
    /// Encoded/decoded by serializers as "KILO".
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_qWw28AxzEeKa_56Jbsi1RQ")]
    [Description(@"Kilo byte.")]
    KiloByte,
    
    /// <summary>
    /// Byte.
    /// Encoded/decoded by serializers as "BYTE".
    /// </summary>
    [EnumMember(Value = "BYTE")]
    [IsoId("_up_msAxzEeKa_56Jbsi1RQ")]
    [Description(@"Byte.")]
    Byte,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MemoryUnitCodeMetadataExtensions
{
    private static readonly MemoryUnitCodeDropdownSource _dropdownSource = new MemoryUnitCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMemoryUnitCodeDropdownRow GetMetadata(this MemoryUnitCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


