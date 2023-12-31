﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementConditionModificationProcessingStatus1Code.  ISO2002 ID# _ZK188Np-Ed-ak6NoX_4Aeg_-1146323229.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementConditionModificationProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZK188Np-Ed-ak6NoX_4Aeg_-1146323229")]
public partial class SettlementConditionModificationProcessingStatus1CodeDropdownSource : EnumMetadataManager<SettlementConditionModificationProcessingStatus1Code,ISettlementConditionModificationProcessingStatus1CodeDropdownRow,SettlementConditionModificationProcessingStatus1CodeDropdownRow>
{
    public SettlementConditionModificationProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementConditionModificationProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
