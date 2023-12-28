﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AgentTypeCode.  ISO2002 ID# _1mchEjL3EeKU9IrkkToqcw_-1193321661.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function that the agent is performing (for example, event agent, information agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mchEjL3EeKU9IrkkToqcw_-1193321661")]
[Description(@"Specifies the function that the agent is performing (for example, event agent, information agent).")]
public enum AgentTypeCode
{
    /// <summary>
    /// Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities.
    /// Encoded/decoded by serializers as "DAGB".
    /// </summary>
    [EnumMember(Value = "DAGB")]
    [IsoId("_1mchEzL3EeKU9IrkkToqcw_-898443522")]
    [Description(@"Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities.")]
    DropAgentBearer,
    
    /// <summary>
    /// Agent that cannot be classified as any listed type of agent.
    /// Encoded/decoded by serializers as "OTAG".
    /// </summary>
    [EnumMember(Value = "OTAG")]
    [IsoId("_1mchFDL3EeKU9IrkkToqcw_1288946460")]
    [Description(@"Agent that cannot be classified as any listed type of agent.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AgentTypeCodeMetadataExtensions
{
    private static readonly AgentTypeCodeDropdownSource _dropdownSource = new AgentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAgentTypeCodeDropdownRow GetMetadata(this AgentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


