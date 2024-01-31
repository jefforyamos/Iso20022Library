﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOrderType5Code.  ISO2002 ID# _atVqcdp-Ed-ak6NoX_4Aeg_-817683940.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOrderType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atVqcdp-Ed-ak6NoX_4Aeg_-817683940")]
public partial class FundOrderType5CodeDropdownSource : EnumMetadataManager<FundOrderType5Code,IFundOrderType5CodeDropdownRow,FundOrderType5CodeDropdownRow>
{
    public FundOrderType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOrderType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
