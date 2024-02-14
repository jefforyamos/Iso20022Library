﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeParty4.  ISO2002 ID# _N3SQQeWlEeevU7McUP3D1w.
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
/// Specifies an entity involved in a trade activity.
/// </summary>
[IsoId("_N3SQQeWlEeevU7McUP3D1w")]
[DisplayName("Trade Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeParty4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeParty4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeParty4( PartyIdentification129 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_OAVekeWlEeevU7McUP3D1w")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification129 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification129 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129 PartyIdentification { get; init; } 
    #else
    public PartyIdentification129 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_OAVek-WlEeevU7McUP3D1w")]
    [DisplayName("Legal Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglOrg")]
    #endif
    [IsoXmlTag("LglOrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    #else
    public LegalOrganisation1? LegalOrganisation { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_OAVeleWlEeevU7McUP3D1w")]
    [DisplayName("Tax Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPty")]
    #endif
    [IsoXmlTag("TaxPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxParty3? TaxParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxParty3? TaxParty { get; init; } 
    #else
    public TaxParty3? TaxParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
