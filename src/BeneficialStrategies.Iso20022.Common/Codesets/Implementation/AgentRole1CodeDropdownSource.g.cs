﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AgentRole1Code.  ISO2002 ID# _bnmTRtp-Ed-ak6NoX_4Aeg_1217480497.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the Issuer agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAgentRole1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bnmTRtp-Ed-ak6NoX_4Aeg_1217480497")]
public partial class AgentRole1CodeDropdownSource : EnumMetadataManager<AgentRole1Code,IAgentRole1CodeDropdownRow,AgentRole1CodeDropdownRow>
{
    public AgentRole1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AgentRole1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
