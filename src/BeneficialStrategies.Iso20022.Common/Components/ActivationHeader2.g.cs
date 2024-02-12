﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActivationHeader2.  ISO2002 ID# _UUIee-H7Eeqbls7Gk4-ckA.
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
/// Specifies the identification and parties playing a role in a request to pay service management message.
/// </summary>
[IsoId("_UUIee-H7Eeqbls7Gk4-ckA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Activation Header")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivationHeader2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActivationHeader2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivationHeader2( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,RTPPartyIdentification1 reqInitiatingParty )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        InitiatingParty = reqInitiatingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The instructing party has to make sure that 'MessageIdentification' is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_UVRG4eH7Eeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_UVRG4-H7Eeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creation Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sends the message.
    /// </summary>
    [IsoId("_UVRG5eH7Eeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Originator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RTPPartyIdentification1? MessageOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1? MessageOriginator { get; init; } 
    #else
    public RTPPartyIdentification1? MessageOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the message.
    /// </summary>
    [IsoId("_UVRG5-H7Eeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Recipient")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RTPPartyIdentification1? MessageRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1? MessageRecipient { get; init; } 
    #else
    public RTPPartyIdentification1? MessageRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the message. This can either be the debtor himself or the party that initiates the request on behalf of the debtor.
    /// </summary>
    [IsoId("_UVRG6eH7Eeqbls7Gk4-ckA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initiating Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RTPPartyIdentification1 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RTPPartyIdentification1 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1 InitiatingParty { get; init; } 
    #else
    public RTPPartyIdentification1 InitiatingParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
