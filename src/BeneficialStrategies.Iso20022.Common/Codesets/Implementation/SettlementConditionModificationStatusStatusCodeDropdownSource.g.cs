﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementConditionModificationStatusStatusCode.  ISO2002 ID# _ZK_t8Np-Ed-ak6NoX_4Aeg_502482396.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementConditionModificationStatusStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZK_t8Np-Ed-ak6NoX_4Aeg_502482396")]
public partial class SettlementConditionModificationStatusStatusCodeDropdownSource : EnumMetadataManager<SettlementConditionModificationStatusStatusCode,ISettlementConditionModificationStatusStatusCodeDropdownRow,SettlementConditionModificationStatusStatusCodeDropdownRow>
{
    public SettlementConditionModificationStatusStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementConditionModificationStatusStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
