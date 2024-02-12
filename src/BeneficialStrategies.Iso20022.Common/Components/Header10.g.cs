﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header10.  ISO2002 ID# _EXmNsWeeEeSh-d9-KfCEyA.
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
[IsoId("_EXmNsWeeEeSh-d9-KfCEyA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Header")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Header10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Header10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Header10( MessageFunction4Code reqMessageFunction,System.String reqProtocolVersion,System.String reqExchangeIdentification,System.DateTime reqCreationDateTime,GenericIdentification53 reqInitiatingParty )
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
    [IsoId("_EmBEMWeeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Function")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageFunction4Code MessageFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageFunction4Code MessageFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction4Code MessageFunction { get; init; } 
    #else
    public MessageFunction4Code MessageFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_EmBEM2eeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protocol Version")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax6Text ProtocolVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ProtocolVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtocolVersion { get; init; } 
    #else
    public System.String ProtocolVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_EmBENWeeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_EmBEN2eeEeSh-d9-KfCEyA")]
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
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_EmBEOWeeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initiating Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification53 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification53 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53 InitiatingParty { get; init; } 
    #else
    public GenericIdentification53 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_EmBEO2eeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Recipient Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? RecipientParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? RecipientParty { get; init; } 
    #else
    public GenericIdentification53? RecipientParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_EmBEPWeeEeSh-d9-KfCEyA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Traceability")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability2? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability2? Traceability { get; init; } 
    #else
    public Traceability2? Traceability { get; set; } 
    #endif
    
    
    #nullable disable
    
}
