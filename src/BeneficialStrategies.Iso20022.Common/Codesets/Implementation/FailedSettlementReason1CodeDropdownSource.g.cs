﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FailedSettlementReason1Code.  ISO2002 ID# _amoliNp-Ed-ak6NoX_4Aeg_-707965689.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a settlement failure.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFailedSettlementReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amoliNp-Ed-ak6NoX_4Aeg_-707965689")]
public partial class FailedSettlementReason1CodeDropdownSource : EnumMetadataManager<FailedSettlementReason1Code,IFailedSettlementReason1CodeDropdownRow,FailedSettlementReason1CodeDropdownRow>
{
    public FailedSettlementReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FailedSettlementReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
