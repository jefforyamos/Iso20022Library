﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionProcessingStatus3Code.  ISO2002 ID# _jWnSlO5NEeCisYr99QEiWA_732250051.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWnSlO5NEeCisYr99QEiWA_732250051")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jWxDkO5NEeCisYr99QEiWA_796529657")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jWxDke5NEeCisYr99QEiWA_-200542696")]
    [Description(@"??")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jWxDku5NEeCisYr99QEiWA_-1261894655")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jWxDk-5NEeCisYr99QEiWA_-1083775983")]
    [Description(@"??")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionProcessingStatus3CodeMetadataExtensions
{
    private static readonly TransactionProcessingStatus3CodeDropdownSource _dropdownSource = new TransactionProcessingStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionProcessingStatus3CodeDropdownRow GetMetadata(this TransactionProcessingStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

