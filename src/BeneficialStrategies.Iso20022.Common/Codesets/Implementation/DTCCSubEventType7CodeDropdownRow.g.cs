﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCCSubEventType7Code.  ISO2002 ID# _8FNzoe2OEeiWtrflKsFqHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCCSubEventType7CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCCSubEventType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8FNzoe2OEeiWtrflKsFqHg")]
public partial class DTCCSubEventType7CodeDropdownRow : EnumMetadataItem<DTCCSubEventType7Code>, IDTCCSubEventType7CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCCSubEventType7CodeDropdownRow(DTCCSubEventType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
