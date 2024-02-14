﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradingVenueAttributes1.  ISO2002 ID# _OjY1gBtGEeWhp-Wous5jzA.
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
/// Traded venue related fields.
/// </summary>
[IsoId("_OjY1gBtGEeWhp-Wous5jzA")]
[DisplayName("Trading Venue Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradingVenueAttributes1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradingVenueAttributes1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradingVenueAttributes1( System.String reqIdentification,System.String reqIssuerRequest )
    {
        Identification = reqIdentification;
        IssuerRequest = reqIssuerRequest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Segment MIC for the trading venue or systematic internaliser, where applicable, otherwise the operating MIC.
    /// </summary>
    [IsoId("_-W6iMc2BEeS6sY79p-9Zxw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer of the financial instrument has requested or approved the trading or admission to trading of their financial instruments on a trading venue.
    /// </summary>
    [IsoId("_i79mwAjzEeWQVudpMI8Aug")]
    [DisplayName("Issuer Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrReq")]
    #endif
    [IsoXmlTag("IssrReq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator IssuerRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerRequest { get; init; } 
    #else
    public System.String IssuerRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the issuer has approved the admission to trading or trading of its financial instruments on the trading venue.
    /// </summary>
    [IsoId("_suGEIRtHEeWhp-Wous5jzA")]
    [DisplayName("Admission Approval Date By Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmssnApprvlDtByIssr")]
    #endif
    [IsoXmlTag("AdmssnApprvlDtByIssr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AdmissionApprovalDateByIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AdmissionApprovalDateByIssuer { get; init; } 
    #else
    public System.DateTime? AdmissionApprovalDateByIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the request for admission on the trading venue was made for the instrument.
    /// </summary>
    [IsoId("_v43-ExtHEeWhp-Wous5jzA")]
    [DisplayName("Request For Admission Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForAdmssnDt")]
    #endif
    [IsoXmlTag("ReqForAdmssnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RequestForAdmissionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RequestForAdmissionDate { get; init; } 
    #else
    public System.DateTime? RequestForAdmissionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the admission to trading on the trading venue or the date and time when the instrument was first traded or an order or quote was first received by the trading venue.
    /// </summary>
    [IsoId("_v43-FBtHEeWhp-Wous5jzA")]
    [DisplayName("First Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstTradDt")]
    #endif
    [IsoXmlTag("FrstTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FirstTradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FirstTradeDate { get; init; } 
    #else
    public System.DateTime? FirstTradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the financial instrument ceases to be traded or to be admitted to trading on the trading venue. Where this date and time is unavailable, the field shall not be populated.
    /// </summary>
    [IsoId("_v43-FRtHEeWhp-Wous5jzA")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TerminationDate { get; init; } 
    #else
    public System.DateTime? TerminationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
