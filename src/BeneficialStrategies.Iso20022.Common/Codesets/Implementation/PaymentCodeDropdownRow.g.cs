﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentCode.  ISO2002 ID# _Zzq3hNp-Ed-ak6NoX_4Aeg_-967340295.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentCodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zzq3hNp-Ed-ak6NoX_4Aeg_-967340295")]
public partial class PaymentCodeDropdownRow : EnumMetadataItem<PaymentCode>, IPaymentCodeDropdownRow
{
    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentCodeDropdownRow(PaymentCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
