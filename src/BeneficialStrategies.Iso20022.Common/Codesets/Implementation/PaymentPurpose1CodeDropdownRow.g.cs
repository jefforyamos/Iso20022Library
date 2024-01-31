﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentPurpose1Code.  ISO2002 ID# _Z5CfuNp-Ed-ak6NoX_4Aeg_148233450.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in a payment initiation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentPurpose1CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentPurpose1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z5CfuNp-Ed-ak6NoX_4Aeg_148233450")]
public partial class PaymentPurpose1CodeDropdownRow : EnumMetadataItem<PaymentPurpose1Code>, IPaymentPurpose1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of transaction that resulted in a payment initiation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentPurpose1CodeDropdownRow(PaymentPurpose1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
