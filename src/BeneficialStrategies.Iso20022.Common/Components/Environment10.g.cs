﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment10.  ISO2002 ID# _JYge4Xa3Eeef9c2nwgY9Xw.
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
/// Environment for a card transaction.
/// </summary>
[IsoId("_JYge4Xa3Eeef9c2nwgY9Xw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party in contract with an acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_JkHR8Xa3Eeef9c2nwgY9Xw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Acquirer { get; init; } 
    #else
    public PartyIdentification197? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_JkHR83a3Eeef9c2nwgY9Xw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sender")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Sender { get; init; } 
    #else
    public PartyIdentification197? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_JkHR9Xa3Eeef9c2nwgY9Xw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiver")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Receiver { get; init; } 
    #else
    public PartyIdentification197? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_JkHR_Xa3Eeef9c2nwgY9Xw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardData3? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData3? Card { get; init; } 
    #else
    public CardData3? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_FujtwZjGEeepepmc9PHSnw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder15? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder15? Cardholder { get; init; } 
    #else
    public Cardholder15? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_44yhYN0bEeil7LQldntseg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Token")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token1? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token1? Token { get; init; } 
    #else
    public Token1? Token { get; set; } 
    #endif
    
    
    #nullable disable
    
}
