﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ContractRegistrationConfirmationV03.  ISO2002 ID# _Nz8alx3pEeuiRvbpCaJe6A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.019.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ContractRegistrationConfirmation message is sent by the registration agent to the reporting party to register the contract subject to currency control.
/// </summary>
[Description(@"The ContractRegistrationConfirmation message is sent by the registration agent to the reporting party to register the contract subject to currency control.")]
[IsoId("_Nz8alx3pEeuiRvbpCaJe6A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Contract Registration Confirmation V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractRegistrationConfirmationV03 : IOuterRecord<ContractRegistrationConfirmationV03,ContractRegistrationConfirmationV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.019.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtrctRegnConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ContractRegistrationConfirmationV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractRegistrationConfirmationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractRegistrationConfirmationV03( CurrencyControlHeader6 reqGroupHeader,RegisteredContract11 reqRegisteredContract )
    {
        GroupHeader = reqGroupHeader;
        RegisteredContract = reqRegisteredContract;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8amR3pEeuiRvbpCaJe6A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlHeader6 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CurrencyControlHeader6 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlHeader6 GroupHeader { get; init; } 
    #else
    public CurrencyControlHeader6 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the contract details which is registered for currency control.
    /// </summary>
    [IsoId("_Nz8amx3pEeuiRvbpCaJe6A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registered Contract")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegisteredContract11 RegisteredContract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RegisteredContract11 RegisteredContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContract11 RegisteredContract { get; init; } 
    #else
    public RegisteredContract11 RegisteredContract { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8anR3pEeuiRvbpCaJe6A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ContractRegistrationConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ContractRegistrationConfirmationV03Document ToDocument()
    {
        return new ContractRegistrationConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ContractRegistrationConfirmationV03"/>.
/// </summary>
[Serializable]
public partial record ContractRegistrationConfirmationV03Document : IOuterDocument<ContractRegistrationConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.019.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ContractRegistrationConfirmationV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContractRegistrationConfirmationV03 Message { get; init; }
    #else
    public ContractRegistrationConfirmationV03 Message { get; init; }
    #endif
}
