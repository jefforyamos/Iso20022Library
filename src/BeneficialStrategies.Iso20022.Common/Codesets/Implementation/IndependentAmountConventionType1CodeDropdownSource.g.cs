﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IndependentAmountConventionType1Code.  ISO2002 ID# _YczLNtp-Ed-ak6NoX_4Aeg_428105906.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the independent amount was applied in the margin calculation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIndependentAmountConventionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YczLNtp-Ed-ak6NoX_4Aeg_428105906")]
public partial class IndependentAmountConventionType1CodeDropdownSource : EnumMetadataManager<IndependentAmountConventionType1Code,IIndependentAmountConventionType1CodeDropdownRow,IndependentAmountConventionType1CodeDropdownRow>
{
    public IndependentAmountConventionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IndependentAmountConventionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
