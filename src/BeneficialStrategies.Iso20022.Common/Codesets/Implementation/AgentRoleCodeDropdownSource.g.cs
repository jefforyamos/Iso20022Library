﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AgentRoleCode.  ISO2002 ID# _bofrItp-Ed-ak6NoX_4Aeg_388156528.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the agent acting as main paying agent or sub paying agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAgentRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bofrItp-Ed-ak6NoX_4Aeg_388156528")]
public partial class AgentRoleCodeDropdownSource : EnumMetadataManager<AgentRoleCode,IAgentRoleCodeDropdownRow,AgentRoleCodeDropdownRow>
{
    public AgentRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AgentRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
