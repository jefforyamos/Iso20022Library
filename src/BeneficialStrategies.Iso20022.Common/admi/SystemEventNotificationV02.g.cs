﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SystemEventNotificationV02.  ISO2002 ID# _pgC-EU7TEeSGH6dwL1uJcg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.admi;


/// <summary>
/// Scope
/// The SystemEventNotification message is sent by a central system to notify the occurrence of an event in a central system.
/// Usage
/// The message can be used by a central settlement system to inform its participants of an event that is going to occur in the system, for instance that the system will be down at a certain time, etc.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SystemEventNotification message is sent by a central system to notify the occurrence of an event in a central system.|Usage|The message can be used by a central settlement system to inform its participants of an event that is going to occur in the system, for instance that the system will be down at a certain time, etc.")]
public partial record SystemEventNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SysEvtNtfctn";
    
    #nullable enable
    /// <summary>
    /// Detailed information about a system event.
    /// </summary>
    [IsoId("_pgC-E07TEeSGH6dwL1uJcg")]
    [Description(@"Detailed information about a system event.")]
    [DataMember(Name="EvtInf")]
    [XmlElement(ElementName="EvtInf")]
    [Required]
    public required Event2 EventInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SystemEventNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SystemEventNotificationV02Document ToDocument()
    {
        return new SystemEventNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SystemEventNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
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
    /// The instance of <seealso cref="SystemEventNotificationV02"/> is required.
    /// </summary>
    public required SystemEventNotificationV02 Message { get; init; }
}
