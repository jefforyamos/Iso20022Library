﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AgentType1Code.  ISO2002 ID# _1sQOIzL3EeKU9IrkkToqcw_1983837671.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function the agent is performing (for example, event agent, information agent).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAgentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1sQOIzL3EeKU9IrkkToqcw_1983837671")]
public partial class AgentType1CodeDropdownSource : EnumMetadataManager<AgentType1Code,IAgentType1CodeDropdownRow,AgentType1CodeDropdownRow>
{
    public AgentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AgentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}