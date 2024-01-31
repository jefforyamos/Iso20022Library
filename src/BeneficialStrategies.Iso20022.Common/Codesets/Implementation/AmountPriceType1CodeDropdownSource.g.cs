﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AmountPriceType1Code.  ISO2002 ID# _begot9p-Ed-ak6NoX_4Aeg_150966910.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAmountPriceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_begot9p-Ed-ak6NoX_4Aeg_150966910")]
public partial class AmountPriceType1CodeDropdownSource : EnumMetadataManager<AmountPriceType1Code,IAmountPriceType1CodeDropdownRow,AmountPriceType1CodeDropdownRow>
{
    public AmountPriceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AmountPriceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
