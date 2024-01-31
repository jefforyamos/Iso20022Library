﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationResponseV03.  ISO2002 ID# _alRXYdqEEeearpaEPXv9UA.
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
/// The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.")]
public partial record MaintenanceDelegationResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnRspn";
    
    #nullable enable
    /// <summary>
    /// Maintenance delegation response message management information.
    /// </summary>
    [IsoId("_alRXY9qEEeearpaEPXv9UA")]
    [Description(@"Maintenance delegation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header29 Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_alRXZdqEEeearpaEPXv9UA")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnRspn")]
    [XmlElement(ElementName="MntncDlgtnRspn")]
    [Required]
    public required MaintenanceDelegationResponse3 MaintenanceDelegationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_alRXZ9qEEeearpaEPXv9UA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType18? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationResponseV03Document ToDocument()
    {
        return new MaintenanceDelegationResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MaintenanceDelegationResponseV03Document : IOuterDocument<MaintenanceDelegationResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationResponseV03"/> is required.
    /// </summary>
    public required MaintenanceDelegationResponseV03 Message { get; init; }
}
