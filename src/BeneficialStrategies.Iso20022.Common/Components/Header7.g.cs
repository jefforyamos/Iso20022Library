﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header7.  ISO2002 ID# _UNSh8S9IEeOlZIh7PImd0A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Set of characteristics related to the protocol.
/// </summary>
[IsoId("_UNSh8S9IEeOlZIh7PImd0A")]
[DisplayName("Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Header7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Header7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Header7( MessageFunction4Code reqMessageFunction,System.String reqProtocolVersion,System.String reqExchangeIdentification,System.DateTime reqCreationDateTime,GenericIdentification32 reqInitiatingParty )
    {
        MessageFunction = reqMessageFunction;
        ProtocolVersion = reqProtocolVersion;
        ExchangeIdentification = reqExchangeIdentification;
        CreationDateTime = reqCreationDateTime;
        InitiatingParty = reqInitiatingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_UdzDIS9IEeOlZIh7PImd0A")]
    [DisplayName("Message Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgFctn")]
    #endif
    [IsoXmlTag("MsgFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageFunction4Code MessageFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageFunction4Code MessageFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction4Code MessageFunction { get; init; } 
    #else
    public MessageFunction4Code MessageFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_UdzDIy9IEeOlZIh7PImd0A")]
    [DisplayName("Protocol Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtcolVrsn")]
    #endif
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax6Text ProtocolVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProtocolVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtocolVersion { get; init; } 
    #else
    public System.String ProtocolVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_UdzDJS9IEeOlZIh7PImd0A")]
    [DisplayName("Exchange Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgId")]
    #endif
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_UdzDJy9IEeOlZIh7PImd0A")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_UdzDKS9IEeOlZIh7PImd0A")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 InitiatingParty { get; init; } 
    #else
    public GenericIdentification32 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_UdzDKy9IEeOlZIh7PImd0A")]
    [DisplayName("Recipient Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptPty")]
    #endif
    [IsoXmlTag("RcptPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? RecipientParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? RecipientParty { get; init; } 
    #else
    public GenericIdentification32? RecipientParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_UdzDLS9IEeOlZIh7PImd0A")]
    [DisplayName("Traceability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tracblt")]
    #endif
    [IsoXmlTag("Tracblt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability1? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability1? Traceability { get; init; } 
    #else
    public Traceability1? Traceability { get; set; } 
    #endif
    
    
    #nullable disable
    
}
