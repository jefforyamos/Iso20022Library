﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties94.  ISO2002 ID# _27tMwQVMEeq4ZaI1b_-GPA.
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
/// Chain of parties involved in the settlement of a transaction.
/// </summary>
[IsoId("_27tMwQVMEeq4ZaI1b_-GPA")]
[DisplayName("Settlement Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementParties94
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments. This party may be a transfer agent.
    /// </summary>
    [IsoId("_3RIDMQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification141? Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification141? Depository { get; init; } 
    #else
    public PartyIdentification141? Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_3RIDOQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty1")]
    #endif
    [IsoXmlTag("Pty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount194? Party1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount194? Party1 { get; init; } 
    #else
    public PartyIdentificationAndAccount194? Party1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 1.
    /// </summary>
    [IsoId("_3RIDQQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty2")]
    #endif
    [IsoXmlTag("Pty2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount194? Party2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount194? Party2 { get; init; } 
    #else
    public PartyIdentificationAndAccount194? Party2 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 2.
    /// </summary>
    [IsoId("_3RIDWwVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty3")]
    #endif
    [IsoXmlTag("Pty3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount194? Party3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount194? Party3 { get; init; } 
    #else
    public PartyIdentificationAndAccount194? Party3 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 3.
    /// </summary>
    [IsoId("_3RIDbwVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty4")]
    #endif
    [IsoXmlTag("Pty4")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount194? Party4 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount194? Party4 { get; init; } 
    #else
    public PartyIdentificationAndAccount194? Party4 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 4.
    /// </summary>
    [IsoId("_3RIDfQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty5")]
    #endif
    [IsoXmlTag("Pty5")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount194? Party5 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount194? Party5 { get; init; } 
    #else
    public PartyIdentificationAndAccount194? Party5 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
