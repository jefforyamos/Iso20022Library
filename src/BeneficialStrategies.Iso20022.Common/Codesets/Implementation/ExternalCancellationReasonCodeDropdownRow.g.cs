﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalCancellationReasonCode.  ISO2002 ID# _6EBKgJF4EeeMPMycDdDCGw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation reason, as published in an external cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalCancellationReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalCancellationReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6EBKgJF4EeeMPMycDdDCGw")]
public partial class ExternalCancellationReasonCodeDropdownRow : EnumMetadataItem<ExternalCancellationReasonCode>, IExternalCancellationReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the cancellation reason, as published in an external cancellation reason code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalCancellationReasonCodeDropdownRow(ExternalCancellationReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
