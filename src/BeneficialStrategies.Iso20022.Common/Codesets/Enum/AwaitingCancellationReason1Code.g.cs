﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AwaitingCancellationReason1Code.  ISO2002 ID# __0Ti0dojEeC60axPepSq7g_-1322175613.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Ti0dojEeC60axPepSq7g_-1322175613")]
[Description(@"Specifies the reason why the instruction has an awaiting cancellation status.")]
[DerivedFrom(typeof(AwaitingCancellationReasonCode))]
public enum AwaitingCancellationReason1Code
{
    /// <summary>
    /// Cancellation has not been received yet.
    /// Encoded/decoded by serializers as "WCAN".
    /// </summary>
    [EnumMember(Value = "WCAN")]
    [IsoId("__0Ti0tojEeC60axPepSq7g_323091822")]
    [Description(@"Cancellation has not been received yet.")]
    AwaitingCancellation = AwaitingCancellationReasonCode.AwaitingCancellation, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AwaitingCancellationReason1CodeMetadataExtensions
{
    private static readonly AwaitingCancellationReason1CodeDropdownSource _dropdownSource = new AwaitingCancellationReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAwaitingCancellationReason1CodeDropdownRow GetMetadata(this AwaitingCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


