﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOrderType2Code.  ISO2002 ID# _VkUiNtp-Ed-ak6NoX_4Aeg_281815183.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOrderType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VkUiNtp-Ed-ak6NoX_4Aeg_281815183")]
public partial class FundOrderType2CodeDropdownSource : EnumMetadataManager<FundOrderType2Code,IFundOrderType2CodeDropdownRow,FundOrderType2CodeDropdownRow>
{
    public FundOrderType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOrderType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
