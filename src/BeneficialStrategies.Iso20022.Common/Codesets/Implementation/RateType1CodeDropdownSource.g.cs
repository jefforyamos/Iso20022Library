﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateType1Code.  ISO2002 ID# _ZZJetNp-Ed-ak6NoX_4Aeg_528600131.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the rate is fixed or variable or a forfeit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZJetNp-Ed-ak6NoX_4Aeg_528600131")]
public partial class RateType1CodeDropdownSource : EnumMetadataManager<RateType1Code,IRateType1CodeDropdownRow,RateType1CodeDropdownRow>
{
    public RateType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
