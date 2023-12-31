﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TrackerPaymentStatus1Code.  ISO2002 ID# _Y4-AIPpPEemXaqBx8S4XSg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates a status of a payment transaction as defined for the tracker.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TrackerPaymentStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ITrackerPaymentStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y4-AIPpPEemXaqBx8S4XSg")]
public partial class TrackerPaymentStatus1CodeDropdownRow : EnumMetadataItem<TrackerPaymentStatus1Code>, ITrackerPaymentStatus1CodeDropdownRow
{
    /// <summary>
    /// Indicates a status of a payment transaction as defined for the tracker.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TrackerPaymentStatus1CodeDropdownRow(TrackerPaymentStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
