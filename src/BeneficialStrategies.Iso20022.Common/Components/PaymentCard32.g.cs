﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard32.  ISO2002 ID# _zazQQVFJEeyApZmLzm74zA.
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
/// Payment card performing the transaction.
/// </summary>
[IsoId("_zazQQVFJEeyApZmLzm74zA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Payment Card")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCard32
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_zhB0EVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected Card Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType32? ProtectedCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType32? ProtectedCardData { get; init; } 
    #else
    public ContentInformationType32? ProtectedCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a private envelope.
    /// </summary>
    [IsoId("_zhB0E1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Private Card Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? PrivateCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? PrivateCardData { get; init; } 
    #else
    public System.Byte[]? PrivateCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_zhB0FVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Plain Card Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData15? PlainCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData15? PlainCardData { get; init; } 
    #else
    public PlainCardData15? PlainCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    [IsoId("_zhB0F1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Account Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentAccountReference { get; init; } 
    #else
    public System.String? PaymentAccountReference { get; set; } 
    #endif
    
    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as '*'.
    /// </summary>
    [IsoId("_zhB0GVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Masked PAN")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 30 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? MaskedPAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaskedPAN { get; init; } 
    #else
    public System.String? MaskedPAN { get; set; } 
    #endif
    
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_zhB0G1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer BIN")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? IssuerBIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerBIN { get; init; } 
    #else
    public System.String? IssuerBIN { get; set; } 
    #endif
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_zhB0HVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Country Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? CardCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCountryCode { get; init; } 
    #else
    public System.String? CardCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_zhB0H1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Currency Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCurrencyCode { get; init; } 
    #else
    public System.String? CardCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_zhB0IVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Product Profile")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductProfile { get; init; } 
    #else
    public System.String? CardProductProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_zhB0I1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Brand")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardBrand { get; init; } 
    #else
    public System.String? CardBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_zhB0JVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Product Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProductType1Code? CardProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProductType1Code? CardProductType { get; init; } 
    #else
    public CardProductType1Code? CardProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to identify CardProduct.
    /// </summary>
    [IsoId("_zhB0J1FJEeyApZmLzm74zA")]
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
    /// True if the card may be used abroad.
    /// </summary>
    [IsoId("_zhB0KVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("International Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InternationalCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InternationalCard { get; init; } 
    #else
    public System.String? InternationalCard { get; set; } 
    #endif
    
    /// <summary>
    /// Product that can be purchased with the card.
    /// </summary>
    [IsoId("_zhB0K1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Allowed Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AllowedProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllowedProduct { get; init; } 
    #else
    public System.String? AllowedProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Options to the service provided by the card.
    /// </summary>
    [IsoId("_zhB0LVFJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Option")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceOption { get; init; } 
    #else
    public System.String? ServiceOption { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_zhB0L1FJEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Card Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCardData { get; init; } 
    #else
    public System.String? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
