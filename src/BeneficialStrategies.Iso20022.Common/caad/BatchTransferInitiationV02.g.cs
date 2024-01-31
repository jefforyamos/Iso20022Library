﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchTransferInitiationV02.  ISO2002 ID# _oMldAZMrEeuleeHpFMMhmQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caad;


/// <summary>
/// The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.")]
public partial record BatchTransferInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchTrfInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_oMmEEZMrEeuleeHpFMMhmQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header60 Header { get; init; }
    
    /// <summary>
    /// Information related to the batch transfer.
    /// </summary>
    [IsoId("_oMmEE5MrEeuleeHpFMMhmQ")]
    [Description(@"Information related to the batch transfer.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required BatchTransferInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_oMmEFZMrEeuleeHpFMMhmQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchTransferInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchTransferInitiationV02Document ToDocument()
    {
        return new BatchTransferInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BatchTransferInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchTransferInitiationV02Document : IOuterDocument<BatchTransferInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchTransferInitiationV02"/> is required.
    /// </summary>
    public required BatchTransferInitiationV02 Message { get; init; }
}
