﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardData7.  ISO2002 ID# _F9FjgY2pEeuPp4VyLQDHhg.
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
/// Non-protected sensitive data associated with the card or payment token performing the transaction.
/// </summary>
[IsoId("_F9FjgY2pEeuPp4VyLQDHhg")]
[DisplayName("Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_GDtI4Y2pEeuPp4VyLQDHhg")]
    [DisplayName("PAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PAN")]
    #endif
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax19NumericText? PAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PAN { get; init; } 
    #else
    public System.String? PAN { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// False: The PAN is used in plain text 
    /// True: The PAN is encrypted by using ProtectedData
    /// Default: False
    /// </summary>
    [IsoId("_GDtI442pEeuPp4VyLQDHhg")]
    [DisplayName("Protected PAN Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdPANInd")]
    #endif
    [IsoXmlTag("PrtctdPANInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectedPANIndicator { get; init; } 
    #else
    public System.String? ProtectedPANIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_GDtI5Y2pEeuPp4VyLQDHhg")]
    [DisplayName("Card Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSeqNb")]
    #endif
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSequenceNumber { get; init; } 
    #else
    public System.String? CardSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 &amp; ISO 8583:2003-1 bit 13
    /// </summary>
    [IsoId("_GDtI542pEeuPp4VyLQDHhg")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? EffectiveDate { get; init; } 
    #else
    public System.UInt16? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the card or payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_GDtI6Y2pEeuPp4VyLQDHhg")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? ExpiryDate { get; init; } 
    #else
    public System.UInt16? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_GDtI642pEeuPp4VyLQDHhg")]
    [DisplayName("Payment Account Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcctRef")]
    #endif
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentAccountReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentAccountReference { get; init; } 
    #else
    public System.String? PaymentAccountReference { get; set; } 
    #endif
    
    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio (for example, Issuer Identification Number). This data should not to be presented to the card acceptor or its environment. (for example, acquirer should not to send or make available to merchant).
    /// </summary>
    [IsoId("_GDtI742pEeuPp4VyLQDHhg")]
    [DisplayName("PAN Account Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PANAcctRg")]
    #endif
    [IsoXmlTag("PANAcctRg")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax19NumericText? PANAccountRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PANAccountRange { get; init; } 
    #else
    public System.String? PANAccountRange { get; set; } 
    #endif
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    [IsoId("_GDtI8Y2pEeuPp4VyLQDHhg")]
    [DisplayName("Card Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCtryCd")]
    #endif
    [IsoXmlTag("CardCtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? CardCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CardCountryCode { get; init; } 
    #else
    public string? CardCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_GDtI842pEeuPp4VyLQDHhg")]
    [DisplayName("Card Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctTp")]
    #endif
    [IsoXmlTag("CardPdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductType { get; init; } 
    #else
    public System.String? CardProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Sub type of card product.
    /// </summary>
    [IsoId("_GDtI9Y2pEeuPp4VyLQDHhg")]
    [DisplayName("Card Product Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctSubTp")]
    #endif
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductSubType { get; init; } 
    #else
    public System.String? CardProductSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the card portfolio. 
    /// </summary>
    [IsoId("_GDtI942pEeuPp4VyLQDHhg")]
    [DisplayName("Card Portfolio Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrtflIdr")]
    #endif
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardPortfolioIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardPortfolioIdentifier { get; init; } 
    #else
    public System.String? CardPortfolioIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_GDtI-Y2pEeuPp4VyLQDHhg")]
    [DisplayName("Additional Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCardData")]
    #endif
    [IsoXmlTag("AddtlCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalCardData { get; init; } 
    #else
    public AdditionalData1? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
