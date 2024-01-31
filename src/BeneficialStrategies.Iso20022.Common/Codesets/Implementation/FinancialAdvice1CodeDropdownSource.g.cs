﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FinancialAdvice1Code.  ISO2002 ID# _an-pUNp-Ed-ak6NoX_4Aeg_126030159.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if advice has been received from an independent financial advisor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFinancialAdvice1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_an-pUNp-Ed-ak6NoX_4Aeg_126030159")]
public partial class FinancialAdvice1CodeDropdownSource : EnumMetadataManager<FinancialAdvice1Code,IFinancialAdvice1CodeDropdownRow,FinancialAdvice1CodeDropdownRow>
{
    public FinancialAdvice1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FinancialAdvice1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
