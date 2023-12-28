﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargePaymentMethod1Code.  ISO2002 ID# _ZFE3gBXyEeOBE-jZfcm4KQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how expenses are paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargePaymentMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZFE3gBXyEeOBE-jZfcm4KQ")]
public partial class ChargePaymentMethod1CodeDropdownSource : EnumMetadataManager<ChargePaymentMethod1Code,IChargePaymentMethod1CodeDropdownRow,ChargePaymentMethod1CodeDropdownRow>
{
    public ChargePaymentMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargePaymentMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}