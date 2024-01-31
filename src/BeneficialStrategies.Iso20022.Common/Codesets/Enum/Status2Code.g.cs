﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status2Code.  ISO2002 ID# _ZQWvF9p-Ed-ak6NoX_4Aeg_-539683866.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQWvF9p-Ed-ak6NoX_4Aeg_-539683866")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status2Code
{
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQggENp-Ed-ak6NoX_4Aeg_-539683848")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZQggEdp-Ed-ak6NoX_4Aeg_-475958869")]
    [Description(@"Instruction is pending.")]
    Pending = StatusCode.Pending, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Status2CodeMetadataExtensions
{
    private static readonly Status2CodeDropdownSource _dropdownSource = new Status2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatus2CodeDropdownRow GetMetadata(this Status2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


