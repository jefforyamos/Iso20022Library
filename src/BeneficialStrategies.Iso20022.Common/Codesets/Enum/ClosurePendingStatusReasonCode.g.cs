﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClosurePendingStatusReasonCode.  ISO2002 ID# _HkvJcGCMEeabZtzjEVWYCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the closure pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HkvJcGCMEeabZtzjEVWYCQ")]
[Description(@"Specifies the reason for the closure pending status.")]
public enum ClosurePendingStatusReasonCode
{
    /// <summary>
    /// Account will be closed when conditions are met.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_OTSsIGCMEeabZtzjEVWYCQ")]
    [Description(@"Account will be closed when conditions are met.")]
    PendingConditions,
    
    /// <summary>
    /// Account closing is in process.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_SQzDgGCMEeabZtzjEVWYCQ")]
    [Description(@"Account closing is in process.")]
    AccountClosingInProcess,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClosurePendingStatusReasonCodeMetadataExtensions
{
    private static readonly ClosurePendingStatusReasonCodeDropdownSource _dropdownSource = new ClosurePendingStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClosurePendingStatusReasonCodeDropdownRow GetMetadata(this ClosurePendingStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


