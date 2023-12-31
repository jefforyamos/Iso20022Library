﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementInstructionGenerationCode.  ISO2002 ID# __wuqYdojEeC60axPepSq7g_-1147396921.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the ETC service provider is to generate a settlement instruction or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementInstructionGenerationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__wuqYdojEeC60axPepSq7g_-1147396921")]
public partial class SettlementInstructionGenerationCodeDropdownSource : EnumMetadataManager<SettlementInstructionGenerationCode,ISettlementInstructionGenerationCodeDropdownRow,SettlementInstructionGenerationCodeDropdownRow>
{
    public SettlementInstructionGenerationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementInstructionGenerationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
