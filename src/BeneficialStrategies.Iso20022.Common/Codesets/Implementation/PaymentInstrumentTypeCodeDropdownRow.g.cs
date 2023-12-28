﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentInstrumentTypeCode.  ISO2002 ID# _MoMKoNxgEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of payment instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentInstrumentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentInstrumentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MoMKoNxgEeioifFt1dhnJA")]
public partial class PaymentInstrumentTypeCodeDropdownRow : EnumMetadataItem<PaymentInstrumentTypeCode>, IPaymentInstrumentTypeCodeDropdownRow
{
    /// <summary>
    /// Type of payment instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentInstrumentTypeCodeDropdownRow(PaymentInstrumentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}