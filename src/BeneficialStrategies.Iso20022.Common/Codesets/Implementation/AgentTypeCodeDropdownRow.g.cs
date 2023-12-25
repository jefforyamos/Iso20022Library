﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AgentTypeCode.  ISO2002 ID# _1mchEjL3EeKU9IrkkToqcw_-1193321661.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function that the agent is performing (for example, event agent, information agent).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AgentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAgentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1mchEjL3EeKU9IrkkToqcw_-1193321661")]
public partial class AgentTypeCodeDropdownRow : EnumMetadataItem<AgentTypeCode>, IAgentTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the function that the agent is performing (for example, event agent, information agent).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AgentTypeCodeDropdownRow(AgentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
