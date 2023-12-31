﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateStatus1Code.  ISO2002 ID# _ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519")]
public partial class RateStatus1CodeDropdownSource : EnumMetadataManager<RateStatus1Code,IRateStatus1CodeDropdownRow,RateStatus1CodeDropdownRow>
{
    public RateStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
