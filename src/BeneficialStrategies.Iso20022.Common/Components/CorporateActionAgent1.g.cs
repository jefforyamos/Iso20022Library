﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAgent1.  ISO2002 ID# _Pc3bwNp-Ed-ak6NoX_4Aeg_-1605492911.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the agent.
/// </summary>
[IsoId("_Pc3bwNp-Ed-ak6NoX_4Aeg_-1605492911")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Agent")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAgent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionAgent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionAgent1( PartyIdentification2Choice_ reqAgentIdentification,AgentRole1FormatChoice_ reqAgentRole )
    {
        AgentIdentification = reqAgentIdentification;
        AgentRole = reqAgentRole;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the agent.
    /// </summary>
    [IsoId("_Pc3bwdp-Ed-ak6NoX_4Aeg_637142441")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ AgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Role played by the agent.
    /// </summary>
    [IsoId("_Pc3bwtp-Ed-ak6NoX_4Aeg_762741819")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent Role")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgentRole1FormatChoice_ AgentRole { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AgentRole1FormatChoice_ AgentRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgentRole1FormatChoice_ AgentRole { get; init; } 
    #else
    public AgentRole1FormatChoice_ AgentRole { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person at the agent.
    /// </summary>
    [IsoId("_Pc3bw9p-Ed-ak6NoX_4Aeg_518579733")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress5? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress5? ContactPerson { get; init; } 
    #else
    public NameAndAddress5? ContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}
