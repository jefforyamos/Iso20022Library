﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusNotificationV02.  ISO2002 ID# _VgTq09E8Ed-BzquC8wXy7w_1259743081.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.trea;


/// <summary>
/// This record is an implementation of the trea.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage
/// This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.
/// 
/// 
/// This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage|This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.|||This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03")]
public partial record StatusNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "trea.008.001.02";
    
    #nullable enable
    /// <summary>
    /// Provides information on the status of a trade in a system.
    /// </summary>
    [IsoId("_VgTq1NE8Ed-BzquC8wXy7w_-575229954")]
    [Description(@"Provides information on the status of a trade in a system.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeData1 TradeData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusNotificationV02Document ToDocument()
    {
        return new StatusNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusNotificationV02Document : IOuterDocument<StatusNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.008.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusNotificationV02"/> is required.
    /// </summary>
    public required StatusNotificationV02 Message { get; init; }
}
