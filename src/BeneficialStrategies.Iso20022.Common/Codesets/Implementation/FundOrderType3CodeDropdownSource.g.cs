﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOrderType3Code.  ISO2002 ID# _atCvhdp-Ed-ak6NoX_4Aeg_1398779632.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOrderType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atCvhdp-Ed-ak6NoX_4Aeg_1398779632")]
public partial class FundOrderType3CodeDropdownSource : EnumMetadataManager<FundOrderType3Code,IFundOrderType3CodeDropdownRow,FundOrderType3CodeDropdownRow>
{
    public FundOrderType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOrderType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
