﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementInstructionReasonCode.  ISO2002 ID# _hNwd8CCsEeWJd9HF2tO7BA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementInstructionReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hNwd8CCsEeWJd9HF2tO7BA")]
public partial class SettlementInstructionReasonCodeDropdownSource : EnumMetadataManager<SettlementInstructionReasonCode,ISettlementInstructionReasonCodeDropdownRow,SettlementInstructionReasonCodeDropdownRow>
{
    public SettlementInstructionReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementInstructionReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
