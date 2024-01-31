﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SwitchTypeCode.  ISO2002 ID# _RQTCAQ2XEeStB9HSJRk0Qw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RQTCAQ2XEeStB9HSJRk0Qw")]
[Description(@"Specifies the status of the switch either full or part for a given account.")]
[Derivations(typeof(SwitchType1Code))]
public enum SwitchTypeCode
{
    /// <summary>
    /// Indicates a partial switch for an account.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Tt_zgA2XEeStB9HSJRk0Qw")]
    [Description(@"Indicates a partial switch for an account.")]
    PartSwitch,
    
    /// <summary>
    /// Indicates a full switch for an account.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_VwU3oA2XEeStB9HSJRk0Qw")]
    [Description(@"Indicates a full switch for an account.")]
    FullSwitch,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SwitchTypeCodeMetadataExtensions
{
    private static readonly SwitchTypeCodeDropdownSource _dropdownSource = new SwitchTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISwitchTypeCodeDropdownRow GetMetadata(this SwitchTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


