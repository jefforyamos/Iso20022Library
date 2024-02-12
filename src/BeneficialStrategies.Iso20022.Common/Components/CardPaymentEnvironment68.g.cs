﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment68.  ISO2002 ID# _jouAsds7Eee9e6xduATmQg.
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
/// Environment of the transaction.
/// </summary>
[IsoId("_jouAsds7Eee9e6xduATmQg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment68
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_jy4CQds7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer4? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer4? Acquirer { get; init; } 
    #else
    public Acquirer4? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_jy4CQ9s7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Merchant")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation32? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation32? Merchant { get; init; } 
    #else
    public Organisation32? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_jy4CRds7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction8? POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction8? POI { get; init; } 
    #else
    public PointOfInteraction8? POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_jy4CR9s7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard28? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard28? Card { get; init; } 
    #else
    public PaymentCard28? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_jy4CSds7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Customer Device")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? CustomerDevice { get; init; } 
    #else
    public CustomerDevice1? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_jy4CS9s7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Wallet")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? Wallet { get; init; } 
    #else
    public CustomerDevice1? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_jy4CTds7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Token")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken4? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken4? PaymentToken { get; init; } 
    #else
    public CardPaymentToken4? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_jy4CT9s7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder13? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder13? Cardholder { get; init; } 
    #else
    public Cardholder13? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_jy4CUds7Eee9e6xduATmQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected Cardholder Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType17? ProtectedCardholderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType17? ProtectedCardholderData { get; init; } 
    #else
    public ContentInformationType17? ProtectedCardholderData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
