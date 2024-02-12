﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradePartyIdentification3.  ISO2002 ID# _PdKWsdp-Ed-ak6NoX_4Aeg_-1580495666.
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
/// Entity involved in an activity.
/// </summary>
[IsoId("_PdKWsdp-Ed-ak6NoX_4Aeg_-1580495666")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade Party Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyIdentification3( PartyIdentification8Choice_ reqSubmittingParty,PartyIdentification8Choice_ reqTradeParty )
    {
        SubmittingParty = reqSubmittingParty;
        TradeParty = reqTradeParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the fund which is one of the parties in a treasury trade.
    /// </summary>
    [IsoId("_PdKWstp-Ed-ak6NoX_4Aeg_2125581687")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fund Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundIdentification2? FundInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundIdentification2? FundInformation { get; init; } 
    #else
    public FundIdentification2? FundInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which submits a treasury trade to a matching system or to a settlement system or to a counterparty.
    /// </summary>
    [IsoId("_PdKWs9p-Ed-ak6NoX_4Aeg_-1580495262")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitting Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #else
    public PartyIdentification8Choice_ SubmittingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which originated a treasury trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_PdKWtNp-Ed-ak6NoX_4Aeg_-1580495304")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ TradeParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification8Choice_ TradeParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ TradeParty { get; init; } 
    #else
    public PartyIdentification8Choice_ TradeParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
