﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AgentRoleCode.  ISO2002 ID# _bofrItp-Ed-ak6NoX_4Aeg_388156528.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the agent acting as main paying agent or sub paying agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bofrItp-Ed-ak6NoX_4Aeg_388156528")]
[Description(@"Identification of the agent acting as main paying agent or sub paying agent.")]
[Derivations(typeof(AgentRole1Code),typeof(AgentRole2Code))]
public enum AgentRoleCode
{
    /// <summary>
    /// The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties.
    /// Encoded/decoded by serializers as "SPAY".
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_bofrI9p-Ed-ak6NoX_4Aeg_388156530")]
    [Description(@"The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties.")]
    SystemPayingAgent,
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as "CODO".
    /// </summary>
    [EnumMember(Value = "CODO")]
    [IsoId("_bofrJNp-Ed-ak6NoX_4Aeg_388156683")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    CoDomicile,
    
    /// <summary>
    /// Identification of the agent acting as main agent.
    /// Encoded/decoded by serializers as "PRIN".
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_bofrJdp-Ed-ak6NoX_4Aeg_415864347")]
    [Description(@"Identification of the agent acting as main agent.")]
    PrincipalAgent,
    
    /// <summary>
    /// Identification of the agent acting as co-domicile or sub agent.
    /// Encoded/decoded by serializers as "SUBA".
    /// </summary>
    [EnumMember(Value = "SUBA")]
    [IsoId("_bofrJtp-Ed-ak6NoX_4Aeg_748333224")]
    [Description(@"Identification of the agent acting as co-domicile or sub agent.")]
    SubAgent,
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// Encoded/decoded by serializers as "ISAG".
    /// </summary>
    [EnumMember(Value = "ISAG")]
    [IsoId("_bofrJ9p-Ed-ak6NoX_4Aeg_1321061383")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    IssuerAgent,
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// Encoded/decoded by serializers as "REGR".
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_bofrKNp-Ed-ak6NoX_4Aeg_-1757482460")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    Registrar,
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as "PAYA".
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_bofrKdp-Ed-ak6NoX_4Aeg_-809026844")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    PayingAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AgentRoleCodeMetadataExtensions
{
    private static readonly AgentRoleCodeDropdownSource _dropdownSource = new AgentRoleCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAgentRoleCodeDropdownRow GetMetadata(this AgentRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


