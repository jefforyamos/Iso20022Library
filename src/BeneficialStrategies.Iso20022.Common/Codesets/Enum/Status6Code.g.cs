﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status6Code.  ISO2002 ID# _kpnylO5NEeCisYr99QEiWA_-1778832606.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kpnylO5NEeCisYr99QEiWA_-1778832606")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status6Code
{
    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_kpxjkO5NEeCisYr99QEiWA_-61748503")]
    [Description(@"Instruction has been rejected.")]
    Rejected = StatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_kpxjke5NEeCisYr99QEiWA_203121317")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is queued.
    /// Encoded/decoded by serializers as "QUED".
    /// </summary>
    [EnumMember(Value = "QUED")]
    [IsoId("_kpxjku5NEeCisYr99QEiWA_-1861474063")]
    [Description(@"Instruction is queued.")]
    Queued = StatusCode.Queued, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Status6CodeMetadataExtensions
{
    private static readonly Status6CodeDropdownSource _dropdownSource = new Status6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatus6CodeDropdownRow GetMetadata(this Status6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


