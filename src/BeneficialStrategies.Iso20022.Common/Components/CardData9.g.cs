﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardData9.  ISO2002 ID# _7N88cZF7EeukDPgU2BMkjQ.
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
[IsoId("_7N88cZF7EeukDPgU2BMkjQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardData9
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
    [IsoId("_7Ub-8ZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("PAN")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
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
    [IsoId("_7UcmAZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected PAN Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_7UcmA5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSequenceNumber { get; init; } 
    #else
    public System.String? CardSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 & ISO 8583:2003-1 bit 13
    /// </summary>
    [IsoId("_7UcmBZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Effective Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_7UcmB5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expiry Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? ExpiryDate { get; init; } 
    #else
    public System.UInt16? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 36
    /// </summary>
    [IsoId("_7UcmCZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Track")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 104 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax104Text? Track3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track3 { get; init; } 
    #else
    public System.String? Track3 { get; set; } 
    #endif
    
    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_7UcmC5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Account Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_7UcmDZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("PAN Account Range")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax19NumericText? PANAccountRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PANAccountRange { get; init; } 
    #else
    public System.String? PANAccountRange { get; set; } 
    #endif
    
    /// <summary>
    /// Last four digits of the PAN.
    /// </summary>
    [IsoId("_7UcmD5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("PAN Four Last Digits")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? PANFourLastDigits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PANFourLastDigits { get; init; } 
    #else
    public System.String? PANFourLastDigits { get; set; } 
    #endif
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    [IsoId("_7UcmEZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Country Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? CardCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CardCountryCode { get; init; } 
    #else
    public string? CardCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code assigned to the card by the card issuer.
    /// ISO 8583:2003 bit 6.
    /// </summary>
    [IsoId("_7UcmE5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Currency Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? CardCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CardCurrencyCode { get; init; } 
    #else
    public string? CardCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_7UcmFZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Product Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductType { get; init; } 
    #else
    public System.String? CardProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Subtype of card product.
    /// </summary>
    [IsoId("_7UcmF5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Product Sub Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_7UcmGZF7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Portfolio Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_7UcmG5F7EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Card Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalCardData { get; init; } 
    #else
    public AdditionalData1? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
