﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentModificationRejectionCode.  ISO2002 ID# _VSTREYlzEeePr-EGJjGYzQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentModificationRejectionCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentModificationRejectionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VSTREYlzEeePr-EGJjGYzQ")]
public partial class ExternalPaymentModificationRejectionCodeDropdownRow : EnumMetadataItem<ExternalPaymentModificationRejectionCode>, IExternalPaymentModificationRejectionCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentModificationRejectionCodeDropdownRow(ExternalPaymentModificationRejectionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
