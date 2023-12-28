﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AwaitingCancellationReasonCode.  ISO2002 ID# __0Ti09ojEeC60axPepSq7g_-1282873817.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a awaiting cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Ti09ojEeC60axPepSq7g_-1282873817")]
[Description(@"Specifies the reason why the instruction has a awaiting cancellation status.")]
public enum AwaitingCancellationReasonCode
{
    /// <summary>
    /// Cancellation has not been received yet.
    /// Encoded/decoded by serializers as "WCAN".
    /// </summary>
    [EnumMember(Value = "WCAN")]
    [IsoId("__0Ti1NojEeC60axPepSq7g_-1396712883")]
    [Description(@"Cancellation has not been received yet.")]
    AwaitingCancellation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AwaitingCancellationReasonCodeMetadataExtensions
{
    private static readonly AwaitingCancellationReasonCodeDropdownSource _dropdownSource = new AwaitingCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAwaitingCancellationReasonCodeDropdownRow GetMetadata(this AwaitingCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


