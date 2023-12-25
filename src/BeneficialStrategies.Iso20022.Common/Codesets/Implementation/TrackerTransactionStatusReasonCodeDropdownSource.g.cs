﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TrackerTransactionStatusReasonCode.  ISO2002 ID# _8RJ1sPpPEemXaqBx8S4XSg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason for a status of a payment transaction in the tracker.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITrackerTransactionStatusReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8RJ1sPpPEemXaqBx8S4XSg")]
public partial class TrackerTransactionStatusReasonCodeDropdownSource : EnumMetadataManager<TrackerTransactionStatusReasonCode,ITrackerTransactionStatusReasonCodeDropdownRow,TrackerTransactionStatusReasonCodeDropdownRow>
{
    public TrackerTransactionStatusReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TrackerTransactionStatusReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
