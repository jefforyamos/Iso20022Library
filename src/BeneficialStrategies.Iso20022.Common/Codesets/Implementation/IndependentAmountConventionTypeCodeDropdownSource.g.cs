﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IndependentAmountConventionTypeCode.  ISO2002 ID# _Yc8VItp-Ed-ak6NoX_4Aeg_-469659155.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the independent amount was applied in the margin calculation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIndependentAmountConventionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yc8VItp-Ed-ak6NoX_4Aeg_-469659155")]
public partial class IndependentAmountConventionTypeCodeDropdownSource : EnumMetadataManager<IndependentAmountConventionTypeCode,IIndependentAmountConventionTypeCodeDropdownRow,IndependentAmountConventionTypeCodeDropdownRow>
{
    public IndependentAmountConventionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new IndependentAmountConventionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
