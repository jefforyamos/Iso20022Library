﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentInstrumentType1Code.  ISO2002 ID# _hi6RENxgEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of payment instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentInstrumentType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentInstrumentType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hi6RENxgEeioifFt1dhnJA")]
public partial class PaymentInstrumentType1CodeDropdownRow : EnumMetadataItem<PaymentInstrumentType1Code>, IPaymentInstrumentType1CodeDropdownRow
{
    /// <summary>
    /// Type of payment instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentInstrumentType1CodeDropdownRow(PaymentInstrumentType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
