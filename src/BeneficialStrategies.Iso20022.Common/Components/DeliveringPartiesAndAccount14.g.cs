﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveringPartiesAndAccount14.  ISO2002 ID# _2SSjYSSsEeWEdM0tuoNJdg.
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
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_2SSjYSSsEeWEdM0tuoNJdg")]
[DisplayName("Delivering Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveringPartiesAndAccount14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveringPartiesAndAccount14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveringPartiesAndAccount14( PartyIdentificationAndAccount124 reqDeliveringAgentDetails )
    {
        DeliveringAgentDetails = reqDeliveringAgentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_2vdAhySsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsCtdnDtls")]
    #endif
    [IsoXmlTag("DlvrrsCtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? DeliverersCustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? DeliverersCustodianDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount124? DeliverersCustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_2vdAiSSsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Intermediary 1 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmy1Dtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? DeliverersIntermediary1Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? DeliverersIntermediary1Details { get; init; } 
    #else
    public PartyIdentificationAndAccount124? DeliverersIntermediary1Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the deliverer&apos;s intermediary.
    /// </summary>
    [IsoId("_2vdAiySsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Intermediary 2 Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrsIntrmy2Dtls")]
    #endif
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount124? DeliverersIntermediary2Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124? DeliverersIntermediary2Details { get; init; } 
    #else
    public PartyIdentificationAndAccount124? DeliverersIntermediary2Details { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_2vdAjSSsEeWEdM0tuoNJdg")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount124 DeliveringAgentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount124 DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount124 DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount124 DeliveringAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_2vdAjySsEeWEdM0tuoNJdg")]
    [DisplayName("Securities Settlement System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmSys")]
    #endif
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesSettlementSystem { get; init; } 
    #else
    public System.String? SecuritiesSettlementSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_2vdAkSSsEeWEdM0tuoNJdg")]
    [DisplayName("Place Of Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlmDtls")]
    #endif
    [IsoXmlTag("PlcOfSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; } 
    #else
    public PartyIdentification97? PlaceOfSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
