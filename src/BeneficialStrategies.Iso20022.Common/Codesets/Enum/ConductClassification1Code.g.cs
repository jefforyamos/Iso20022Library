﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConductClassification1Code.  ISO2002 ID# _nP6msBjoEeKxeog5DTmtgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the classification of the conduct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nP6msBjoEeKxeog5DTmtgg")]
[Description(@"Specifies the classification of the conduct.")]
[DerivedFrom(typeof(ConductClassificationCode))]
public enum ConductClassification1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonStandard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rUP-0RjoEeKxeog5DTmtgg")]
    [Description(@"??")]
    NonStandard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reluctant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rfkeARjoEeKxeog5DTmtgg")]
    [Description(@"??")]
    Reluctant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Standard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_roqIkRjoEeKxeog5DTmtgg")]
    [Description(@"??")]
    Standard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConductClassification1CodeMetadataExtensions
{
    private static readonly ConductClassification1CodeDropdownSource _dropdownSource = new ConductClassification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConductClassification1CodeDropdownRow GetMetadata(this ConductClassification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


