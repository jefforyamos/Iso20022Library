﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionProcessingStatus4Code.  ISO2002 ID# _j3smZe5NEeCisYr99QEiWA_1984710351.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j3smZe5NEeCisYr99QEiWA_1984710351")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j3smZu5NEeCisYr99QEiWA_1509485244")]
    [Description(@"??")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingProcessing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j3smZ-5NEeCisYr99QEiWA_405378159")]
    [Description(@"??")]
    PendingProcessing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XYO5NEeCisYr99QEiWA_87601498")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XYe5NEeCisYr99QEiWA_-398456535")]
    [Description(@"??")]
    InRepair,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XYu5NEeCisYr99QEiWA_563889893")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingCancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XY-5NEeCisYr99QEiWA_826912670")]
    [Description(@"??")]
    PendingCancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XZO5NEeCisYr99QEiWA_1615433270")]
    [Description(@"??")]
    CancellationRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ModificationRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j32XZe5NEeCisYr99QEiWA_1449930477")]
    [Description(@"??")]
    ModificationRequested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionProcessingStatus4CodeMetadataExtensions
{
    private static readonly TransactionProcessingStatus4CodeDropdownSource _dropdownSource = new TransactionProcessingStatus4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionProcessingStatus4CodeDropdownRow GetMetadata(this TransactionProcessingStatus4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


