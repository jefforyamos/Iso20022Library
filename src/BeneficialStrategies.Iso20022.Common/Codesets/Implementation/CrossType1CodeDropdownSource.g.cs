﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CrossType1Code.  ISO2002 ID# _bUYcVNp-Ed-ak6NoX_4Aeg_2017715514.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cross being submitted to a market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICrossType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bUYcVNp-Ed-ak6NoX_4Aeg_2017715514")]
public partial class CrossType1CodeDropdownSource : EnumMetadataManager<CrossType1Code,ICrossType1CodeDropdownRow,CrossType1CodeDropdownRow>
{
    public CrossType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CrossType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}