﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason3Code.  ISO2002 ID# _aBreUNp-Ed-ak6NoX_4Aeg_1193465665.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aBreUNp-Ed-ak6NoX_4Aeg_1193465665")]
public partial class PendingReason3CodeDropdownSource : EnumMetadataManager<PendingReason3Code,IPendingReason3CodeDropdownRow,PendingReason3CodeDropdownRow>
{
    public PendingReason3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
