﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementInstructionGenerationCode.  ISO2002 ID# __wuqYdojEeC60axPepSq7g_-1147396921.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the ETC service provider is to generate a settlement instruction or not.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementInstructionGenerationCodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementInstructionGenerationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__wuqYdojEeC60axPepSq7g_-1147396921")]
public partial class SettlementInstructionGenerationCodeDropdownRow : EnumMetadataItem<SettlementInstructionGenerationCode>, ISettlementInstructionGenerationCodeDropdownRow
{
    /// <summary>
    /// Specifies if the ETC service provider is to generate a settlement instruction or not.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementInstructionGenerationCodeDropdownRow(SettlementInstructionGenerationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}