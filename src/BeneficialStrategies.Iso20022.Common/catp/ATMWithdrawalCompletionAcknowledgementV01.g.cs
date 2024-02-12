﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMWithdrawalCompletionAcknowledgementV01.  ISO2002 ID# _P2qh4IqkEeS4a4abTJTSSw.
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


namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message.
/// </summary>
[Description(@"The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message.")]
[IsoId("_P2qh4IqkEeS4a4abTJTSSw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("ATM Withdrawal Completion Acknowledgement V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMWithdrawalCompletionAcknowledgementV01 : IOuterRecord<ATMWithdrawalCompletionAcknowledgementV01,ATMWithdrawalCompletionAcknowledgementV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlCmpltnAck";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ATMWithdrawalCompletionAcknowledgementV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMWithdrawalCompletionAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMWithdrawalCompletionAcknowledgementV01( Header21 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_aFDBcIqkEeS4a4abTJTSSw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header21 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Header21 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header21 Header { get; init; } 
    #else
    public Header21 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_fAp_0IqkEeS4a4abTJTSSw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected ATM Withdrawal Completion Acknowledgement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAcknowledgement { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM withdrawal transaction from the ATM manager.
    /// </summary>
    [IsoId("_yUgPEIqkEeS4a4abTJTSSw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ATM Withdrawal Completion Acknowledgement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMWithdrawalCompletionAcknowledgement1? ATMWithdrawalCompletionAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMWithdrawalCompletionAcknowledgement1? ATMWithdrawalCompletionAcknowledgement { get; init; } 
    #else
    public ATMWithdrawalCompletionAcknowledgement1? ATMWithdrawalCompletionAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_2jjpcIqkEeS4a4abTJTSSw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMWithdrawalCompletionAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMWithdrawalCompletionAcknowledgementV01Document ToDocument()
    {
        return new ATMWithdrawalCompletionAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMWithdrawalCompletionAcknowledgementV01"/>.
/// </summary>
[Serializable]
public partial record ATMWithdrawalCompletionAcknowledgementV01Document : IOuterDocument<ATMWithdrawalCompletionAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMWithdrawalCompletionAcknowledgementV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMWithdrawalCompletionAcknowledgementV01 Message { get; init; }
    #else
    public ATMWithdrawalCompletionAcknowledgementV01 Message { get; init; }
    #endif
}
