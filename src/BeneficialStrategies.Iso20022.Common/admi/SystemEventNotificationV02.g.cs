﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SystemEventNotificationV02.  ISO2002 ID# _pgC-EU7TEeSGH6dwL1uJcg.
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


namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SystemEventNotification message is sent by a central system to notify the occurrence of an event in a central system.
/// Usage
/// The message can be used by a central settlement system to inform its participants of an event that is going to occur in the system, for instance that the system will be down at a certain time, etc.
/// </summary>
[Description(@"Scope|The SystemEventNotification message is sent by a central system to notify the occurrence of an event in a central system.|Usage|The message can be used by a central settlement system to inform its participants of an event that is going to occur in the system, for instance that the system will be down at a certain time, etc.")]
[IsoId("_pgC-EU7TEeSGH6dwL1uJcg")]
[DisplayName("System Event Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemEventNotificationV02 : IOuterRecord<SystemEventNotificationV02,SystemEventNotificationV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SysEvtNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SystemEventNotificationV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemEventNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemEventNotificationV02( Event2 reqEventInformation )
    {
        EventInformation = reqEventInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed information about a system event.
    /// </summary>
    [IsoId("_pgC-E07TEeSGH6dwL1uJcg")]
    [DisplayName("Event Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtInf")]
    #endif
    [IsoXmlTag("EvtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Event2 EventInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Event2 EventInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Event2 EventInformation { get; init; } 
    #else
    public Event2 EventInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SystemEventNotificationV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SystemEventNotificationV02Document ToDocument()
    {
        return new SystemEventNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SystemEventNotificationV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SystemEventNotificationV02Document : IOuterDocument<SystemEventNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SystemEventNotificationV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventNotificationV02 Message { get; init; }
    #else
    public SystemEventNotificationV02 Message { get; init; }
    #endif
}
