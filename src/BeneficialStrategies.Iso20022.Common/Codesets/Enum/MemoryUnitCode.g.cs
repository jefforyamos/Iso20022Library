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
public enum MemoryUnitCode
{
    /// <summary>
    /// Exa byte.
    /// </summary>
    [EnumMember(Value = "EXAB")]
    [IsoId("_Hr9EwAxzEeKa_56Jbsi1RQ")]
    [Description(@"Exa byte.")]
    EXAB,
    
    /// <summary>
    /// Peta byte.
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_R05qsAxzEeKa_56Jbsi1RQ")]
    [Description(@"Peta byte.")]
    PETA,
    
    /// <summary>
    /// Tera byte.
    /// </summary>
    [EnumMember(Value = "TERA")]
    [IsoId("_cCdq4AxzEeKa_56Jbsi1RQ")]
    [Description(@"Tera byte.")]
    TERA,
    
    /// <summary>
    /// Giga byte.
    /// </summary>
    [EnumMember(Value = "GIGA")]
    [IsoId("_hkizYAxzEeKa_56Jbsi1RQ")]
    [Description(@"Giga byte.")]
    GIGA,
    
    /// <summary>
    /// Mega byte.
    /// </summary>
    [EnumMember(Value = "MEGA")]
    [IsoId("_lTyFQAxzEeKa_56Jbsi1RQ")]
    [Description(@"Mega byte.")]
    MEGA,
    
    /// <summary>
    /// Kilo byte.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_qWw28AxzEeKa_56Jbsi1RQ")]
    [Description(@"Kilo byte.")]
    KILO,
    
    /// <summary>
    /// Byte.
    /// </summary>
    [EnumMember(Value = "BYTE")]
    [IsoId("_up_msAxzEeKa_56Jbsi1RQ")]
    [Description(@"Byte.")]
    BYTE,
    
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


