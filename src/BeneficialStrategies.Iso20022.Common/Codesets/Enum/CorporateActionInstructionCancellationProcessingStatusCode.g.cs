﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionInstructionCancellationProcessingStatusCode.  ISO2002 ID# _bKPo5Np-Ed-ak6NoX_4Aeg_1956200676.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a corporate action instruction cancellation process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKPo5Np-Ed-ak6NoX_4Aeg_1956200676")]
[Description(@"Specifies the status of a corporate action instruction cancellation process.")]
[Derivations(typeof(CorporateActionInstructionCancellationProcessingStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionInstructionCancellationProcessingStatusCode
{
    /// <summary>
    /// Cancellation request has been completed.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKZZ4Np-Ed-ak6NoX_4Aeg_110983323")]
    [Description(@"Cancellation request has been completed.")]
    CancellationCompleted,
    
    /// <summary>
    /// Cancellation request is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bKZZ4dp-Ed-ak6NoX_4Aeg_267505134")]
    [Description(@"Cancellation request is pending. It is not known at this time whether cancellation can be affected.")]
    PendingCancellation,
    
    /// <summary>
    /// Cancellation request has been accepted for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKZZ4tp-Ed-ak6NoX_4Aeg_-2125470476")]
    [Description(@"Cancellation request has been accepted for further processing.")]
    Accepted,
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKZZ49p-Ed-ak6NoX_4Aeg_499155660")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionInstructionCancellationProcessingStatusCodeMetadataExtensions
{
    private static readonly CorporateActionInstructionCancellationProcessingStatusCodeDropdownSource _dropdownSource = new CorporateActionInstructionCancellationProcessingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionInstructionCancellationProcessingStatusCodeDropdownRow GetMetadata(this CorporateActionInstructionCancellationProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


