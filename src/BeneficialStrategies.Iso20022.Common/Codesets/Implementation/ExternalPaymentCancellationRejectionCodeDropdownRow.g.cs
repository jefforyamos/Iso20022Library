﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentCancellationRejectionCode.  ISO2002 ID# _qcZCgYluEeePr-EGJjGYzQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentCancellationRejectionCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentCancellationRejectionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qcZCgYluEeePr-EGJjGYzQ")]
public partial class ExternalPaymentCancellationRejectionCodeDropdownRow : EnumMetadataItem<ExternalPaymentCancellationRejectionCode>, IExternalPaymentCancellationRejectionCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentCancellationRejectionCodeDropdownRow(ExternalPaymentCancellationRejectionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
