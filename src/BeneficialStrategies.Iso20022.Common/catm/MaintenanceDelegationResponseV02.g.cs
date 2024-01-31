﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationResponseV02.  ISO2002 ID# _FyShYY4HEeWrZqsymMFdfg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// This record is an implementation of the catm.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.")]
public partial record MaintenanceDelegationResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnRspn";
    
    #nullable enable
    /// <summary>
    /// Maintenance delegation response message management information.
    /// </summary>
    [IsoId("_FyShY44HEeWrZqsymMFdfg")]
    [Description(@"Maintenance delegation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header29 Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_FyShZY4HEeWrZqsymMFdfg")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnRspn")]
    [XmlElement(ElementName="MntncDlgtnRspn")]
    [Required]
    public required MaintenanceDelegationResponse2 MaintenanceDelegationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FyShZ44HEeWrZqsymMFdfg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType12? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationResponseV02Document ToDocument()
    {
        return new MaintenanceDelegationResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MaintenanceDelegationResponseV02Document : IOuterDocument<MaintenanceDelegationResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationResponseV02"/> is required.
    /// </summary>
    public required MaintenanceDelegationResponseV02 Message { get; init; }
}
