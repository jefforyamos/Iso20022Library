﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PEPISA1Code.  ISO2002 ID# _zdTdcw93EeGeV5vP7Mvdig_1618918841.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Transfer, PEP or ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdTdcw93EeGeV5vP7Mvdig_1618918841")]
[Description(@"Specifies the type of Transfer, PEP or ISA.")]
[DerivedFrom(typeof(PEPISACode))]
public enum PEPISA1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PEP".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zdTddA93EeGeV5vP7Mvdig_-2054941291")]
    [Description(@"??")]
    PEP,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zdTddQ93EeGeV5vP7Mvdig_865100993")]
    [Description(@"??")]
    ISA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PEPISA1CodeMetadataExtensions
{
    private static readonly PEPISA1CodeDropdownSource _dropdownSource = new PEPISA1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPEPISA1CodeDropdownRow GetMetadata(this PEPISA1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


