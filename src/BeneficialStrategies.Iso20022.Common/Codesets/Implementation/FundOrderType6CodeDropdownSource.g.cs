﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOrderType6Code.  ISO2002 ID# _l7GIIBKuEeKj15WxqwlXPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOrderType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_l7GIIBKuEeKj15WxqwlXPw")]
public partial class FundOrderType6CodeDropdownSource : EnumMetadataManager<FundOrderType6Code,IFundOrderType6CodeDropdownRow,FundOrderType6CodeDropdownRow>
{
    public FundOrderType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOrderType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
