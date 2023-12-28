﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationProcessingStatus3Code.  ISO2002 ID# _jQNIme5NEeCisYr99QEiWA_-1920216979.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQNIme5NEeCisYr99QEiWA_-1920216979")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(CancellationProcessingStatusCode))]
public enum CancellationProcessingStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingCancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQW5kO5NEeCisYr99QEiWA_1377677964")]
    [Description(@"??")]
    PendingCancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQW5ke5NEeCisYr99QEiWA_1441957570")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQW5ku5NEeCisYr99QEiWA_-653311621")]
    [Description(@"??")]
    InRepair,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQW5k-5NEeCisYr99QEiWA_1263838898")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Denied".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQW5lO5NEeCisYr99QEiWA_1555796636")]
    [Description(@"??")]
    Denied,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationCompleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQgqkO5NEeCisYr99QEiWA_-1855937373")]
    [Description(@"??")]
    CancellationCompleted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationProcessingStatus3CodeMetadataExtensions
{
    private static readonly CancellationProcessingStatus3CodeDropdownSource _dropdownSource = new CancellationProcessingStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationProcessingStatus3CodeDropdownRow GetMetadata(this CancellationProcessingStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


