﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SwitchType1Code.  ISO2002 ID# _wQUvEA2YEeSNWNtJlXOAhg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wQUvEA2YEeSNWNtJlXOAhg")]
[Description(@"Specifies the status of the switch either full or part for a given account.")]
[DerivedFrom(typeof(SwitchTypeCode))]
public enum SwitchType1Code
{
    /// <summary>
    /// Indicates a full switch for an account.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_xBa00Q2YEeSNWNtJlXOAhg")]
    [Description(@"Indicates a full switch for an account.")]
    FullSwitch = SwitchTypeCode.FullSwitch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a partial switch for an account.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_xGBoAQ2YEeSNWNtJlXOAhg")]
    [Description(@"Indicates a partial switch for an account.")]
    PartSwitch = SwitchTypeCode.PartSwitch, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SwitchType1CodeMetadataExtensions
{
    private static readonly SwitchType1CodeDropdownSource _dropdownSource = new SwitchType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISwitchType1CodeDropdownRow GetMetadata(this SwitchType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


