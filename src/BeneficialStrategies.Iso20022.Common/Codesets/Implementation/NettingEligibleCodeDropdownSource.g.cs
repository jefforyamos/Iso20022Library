﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NettingEligibleCode.  ISO2002 ID# _YZ0Ipdp-Ed-ak6NoX_4Aeg_-1067297210.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the trade is eligible for netting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INettingEligibleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZ0Ipdp-Ed-ak6NoX_4Aeg_-1067297210")]
public partial class NettingEligibleCodeDropdownSource : EnumMetadataManager<NettingEligibleCode,INettingEligibleCodeDropdownRow,NettingEligibleCodeDropdownRow>
{
    public NettingEligibleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NettingEligibleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
