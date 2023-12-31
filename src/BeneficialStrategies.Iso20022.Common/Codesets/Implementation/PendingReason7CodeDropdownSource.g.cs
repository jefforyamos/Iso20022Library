﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason7Code.  ISO2002 ID# _aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619")]
public partial class PendingReason7CodeDropdownSource : EnumMetadataManager<PendingReason7Code,IPendingReason7CodeDropdownRow,PendingReason7CodeDropdownRow>
{
    public PendingReason7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
