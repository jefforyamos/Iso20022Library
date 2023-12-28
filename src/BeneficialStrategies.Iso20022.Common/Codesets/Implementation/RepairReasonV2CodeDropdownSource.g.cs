﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepairReasonV2Code.  ISO2002 ID# _ZvpTINp-Ed-ak6NoX_4Aeg_663303244.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepairReasonV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZvpTINp-Ed-ak6NoX_4Aeg_663303244")]
public partial class RepairReasonV2CodeDropdownSource : EnumMetadataManager<RepairReasonV2Code,IRepairReasonV2CodeDropdownRow,RepairReasonV2CodeDropdownRow>
{
    public RepairReasonV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepairReasonV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}