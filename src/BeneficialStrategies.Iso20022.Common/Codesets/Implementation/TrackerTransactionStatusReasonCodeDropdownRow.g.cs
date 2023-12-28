﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TrackerTransactionStatusReasonCode.  ISO2002 ID# _8RJ1sPpPEemXaqBx8S4XSg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason for a status of a payment transaction in the tracker.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TrackerTransactionStatusReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ITrackerTransactionStatusReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8RJ1sPpPEemXaqBx8S4XSg")]
public partial class TrackerTransactionStatusReasonCodeDropdownRow : EnumMetadataItem<TrackerTransactionStatusReasonCode>, ITrackerTransactionStatusReasonCodeDropdownRow
{
    /// <summary>
    /// Provides the reason for a status of a payment transaction in the tracker.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TrackerTransactionStatusReasonCodeDropdownRow(TrackerTransactionStatusReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}