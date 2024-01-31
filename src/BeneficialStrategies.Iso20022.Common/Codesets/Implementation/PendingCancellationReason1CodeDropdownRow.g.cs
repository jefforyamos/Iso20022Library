﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingCancellationReason1Code.  ISO2002 ID# _Z-Gl4dp-Ed-ak6NoX_4Aeg_332106838.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingCancellationReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingCancellationReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z-Gl4dp-Ed-ak6NoX_4Aeg_332106838")]
public partial class PendingCancellationReason1CodeDropdownRow : EnumMetadataItem<PendingCancellationReason1Code>, IPendingCancellationReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingCancellationReason1CodeDropdownRow(PendingCancellationReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
