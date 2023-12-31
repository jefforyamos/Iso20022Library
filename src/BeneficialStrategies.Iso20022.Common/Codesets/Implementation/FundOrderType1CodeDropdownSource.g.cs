﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOrderType1Code.  ISO2002 ID# _atCvgdp-Ed-ak6NoX_4Aeg_1585971671.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOrderType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atCvgdp-Ed-ak6NoX_4Aeg_1585971671")]
public partial class FundOrderType1CodeDropdownSource : EnumMetadataManager<FundOrderType1Code,IFundOrderType1CodeDropdownRow,FundOrderType1CodeDropdownRow>
{
    public FundOrderType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOrderType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
