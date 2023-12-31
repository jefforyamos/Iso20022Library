﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ConfirmationCancellationReasonCode.  ISO2002 ID# _KSiJ8FM6EeaOrcVOcDJQkA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why a confirmation is cancelled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ConfirmationCancellationReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IConfirmationCancellationReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KSiJ8FM6EeaOrcVOcDJQkA")]
public partial class ConfirmationCancellationReasonCodeDropdownRow : EnumMetadataItem<ConfirmationCancellationReasonCode>, IConfirmationCancellationReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why a confirmation is cancelled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ConfirmationCancellationReasonCodeDropdownRow(ConfirmationCancellationReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
