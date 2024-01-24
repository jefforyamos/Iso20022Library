﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConductClassificationCode.  ISO2002 ID# _ecbaIBdvEeKYM7Bc71nDlA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the classification of the conduct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ecbaIBdvEeKYM7Bc71nDlA")]
[Description(@"Specifies the classification of the conduct.")]
[Derivations(typeof(ConductClassification1Code))]
public enum ConductClassificationCode
{
    /// <summary>
    /// Standard.
    /// Encoded/decoded by serializers as "STAN".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_kd8QoBdvEeKYM7Bc71nDlA")]
    [Description(@"Standard.")]
    Standard,
    
    /// <summary>
    /// Non standard or unusual.
    /// Encoded/decoded by serializers as "NSTA".
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_kmuZMBdvEeKYM7Bc71nDlA")]
    [Description(@"Non standard or unusual.")]
    NonStandard,
    
    /// <summary>
    /// Reluctant.
    /// Encoded/decoded by serializers as "RCLT".
    /// </summary>
    [EnumMember(Value = "RCLT")]
    [IsoId("_kvhI0BdvEeKYM7Bc71nDlA")]
    [Description(@"Reluctant.")]
    Reluctant,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConductClassificationCodeMetadataExtensions
{
    private static readonly ConductClassificationCodeDropdownSource _dropdownSource = new ConductClassificationCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConductClassificationCodeDropdownRow GetMetadata(this ConductClassificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


