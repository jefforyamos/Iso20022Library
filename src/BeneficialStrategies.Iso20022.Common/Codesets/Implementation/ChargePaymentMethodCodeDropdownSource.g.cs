﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargePaymentMethodCode.  ISO2002 ID# _H8wEoRXyEeOBE-jZfcm4KQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how expenses are paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargePaymentMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_H8wEoRXyEeOBE-jZfcm4KQ")]
public partial class ChargePaymentMethodCodeDropdownSource : EnumMetadataManager<ChargePaymentMethodCode,IChargePaymentMethodCodeDropdownRow,ChargePaymentMethodCodeDropdownRow>
{
    public ChargePaymentMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargePaymentMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}