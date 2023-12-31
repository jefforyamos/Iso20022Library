﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Payment1Code.  ISO2002 ID# _Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPayment1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707")]
public partial class Payment1CodeDropdownSource : EnumMetadataManager<Payment1Code,IPayment1CodeDropdownRow,Payment1CodeDropdownRow>
{
    public Payment1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Payment1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
