﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferReasonCode.  ISO2002 ID# _le2Gw_r4EeCu2Z1WwxJVWA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the assets transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ITransferReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_le2Gw_r4EeCu2Z1WwxJVWA")]
public partial class TransferReasonCodeDropdownRow : EnumMetadataItem<TransferReasonCode>, ITransferReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferReasonCodeDropdownRow(TransferReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
