﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment32.  ISO2002 ID# _3_n-wZx9EeuwYeL1lHu9zw.
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
/// Environment of a card transaction.
/// </summary>
[IsoId("_3_n-wZx9EeuwYeL1lHu9zw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment32
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Environment32 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Environment32( PartyIdentification263 reqAcquirer )
    {
        Acquirer = reqAcquirer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_4GD98Zx9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification263 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification263 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263 Acquirer { get; init; } 
    #else
    public PartyIdentification263 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_4GD985x9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Originator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Originator { get; init; } 
    #else
    public PartyIdentification263? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_4GD99Zx9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sender")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Sender { get; init; } 
    #else
    public PartyIdentification263? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    [IsoId("_4GD995x9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiver")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Receiver { get; init; } 
    #else
    public PartyIdentification263? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_4GD9-Zx9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acceptor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? Acceptor { get; init; } 
    #else
    public PartyIdentification258? Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_4GD9-5x9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Destination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Destination { get; init; } 
    #else
    public PartyIdentification263? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_4GD9_Zx9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Terminal")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Terminal6? Terminal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Terminal6? Terminal { get; init; } 
    #else
    public Terminal6? Terminal { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_etPwgUYvEeydPZbwOuqbJQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Issuer { get; init; } 
    #else
    public PartyIdentification263? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_4GD9_5x9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardData9? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData9? Card { get; init; } 
    #else
    public CardData9? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_4GD-AZx9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Wallet")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Wallet2? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Wallet2? Wallet { get; init; } 
    #else
    public Wallet2? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_4GD-A5x9EeuwYeL1lHu9zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Token")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token3? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token3? Token { get; init; } 
    #else
    public Token3? Token { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_b2wYASbUEeyhZIgCcGlTyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder19? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder19? Cardholder { get; init; } 
    #else
    public Cardholder19? Cardholder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
