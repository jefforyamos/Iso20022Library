﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AddendumInitiationV02.  ISO2002 ID# _FqDuYYdJEeuBS50MFjViNw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.cain;


/// <summary>
/// This record is an implementation of the cain.025.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Provides supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. 
/// 
/// The supplemental data is associated with an authorization or financial message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Provides supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. ||The supplemental data is associated with an authorization or financial message.")]
public partial record AddendumInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.025.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdddmInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_FqDuY4dJEeuBS50MFjViNw")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header66 Header { get; init; }
    
    /// <summary>
    /// The AddendumInitiation is used to provide supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. The supplemental data is associated with an authorization or financial message.
    /// </summary>
    [IsoId("_FqDuZYdJEeuBS50MFjViNw")]
    [Description(@"The AddendumInitiation is used to provide supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. The supplemental data is associated with an authorization or financial message.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    public AddendumInitiation2? Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_FqDuZ4dJEeuBS50MFjViNw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AddendumInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AddendumInitiationV02Document ToDocument()
    {
        return new AddendumInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AddendumInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AddendumInitiationV02Document : IOuterDocument<AddendumInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.025.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AddendumInitiationV02"/> is required.
    /// </summary>
    public required AddendumInitiationV02 Message { get; init; }
}
