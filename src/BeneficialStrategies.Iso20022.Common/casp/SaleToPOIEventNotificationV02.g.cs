﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIEventNotificationV02.  ISO2002 ID# _3PF2AQ1TEeqjM-rxn3HuXQ.
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


namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIEventNotification message is sent by a POI or a sale terminal to inform the other about the happening of an event.
/// </summary>
[Description(@"The SaleToPOIEventNotification message is sent by a POI or a sale terminal to inform the other about the happening of an event.")]
[IsoId("_3PF2AQ1TEeqjM-rxn3HuXQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Sale To POI Event Notification V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleToPOIEventNotificationV02 : IOuterRecord<SaleToPOIEventNotificationV02,SaleToPOIEventNotificationV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.012.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIEvtNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SaleToPOIEventNotificationV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SaleToPOIEventNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleToPOIEventNotificationV02( Header41 reqHeader,SystemEventNotification3 reqEventNotification )
    {
        Header = reqHeader;
        EventNotification = reqEventNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_3PF2Aw1TEeqjM-rxn3HuXQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header41 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Header41 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header41 Header { get; init; } 
    #else
    public Header41 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the notification of an event.
    /// </summary>
    [IsoId("_3PF2BQ1TEeqjM-rxn3HuXQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Notification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventNotification3 EventNotification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SystemEventNotification3 EventNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventNotification3 EventNotification { get; init; } 
    #else
    public SystemEventNotification3 EventNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_3PF2Bw1TEeqjM-rxn3HuXQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType21? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType21? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType21? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIEventNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIEventNotificationV02Document ToDocument()
    {
        return new SaleToPOIEventNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIEventNotificationV02"/>.
/// </summary>
[Serializable]
public partial record SaleToPOIEventNotificationV02Document : IOuterDocument<SaleToPOIEventNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIEventNotificationV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SaleToPOIEventNotificationV02 Message { get; init; }
    #else
    public SaleToPOIEventNotificationV02 Message { get; init; }
    #endif
}
