﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateType12Code.  ISO2002 ID# _ZZJesNp-Ed-ak6NoX_4Aeg_-1551942195.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateType12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZJesNp-Ed-ak6NoX_4Aeg_-1551942195")]
public partial class RateType12CodeDropdownSource : EnumMetadataManager<RateType12Code,IRateType12CodeDropdownRow,RateType12CodeDropdownRow>
{
    public RateType12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateType12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
