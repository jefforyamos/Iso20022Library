﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for KeyExchangeInitiationV02.  ISO2002 ID# _2CqhVVWVEeeiG_nL4vgKnQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.canm;


/// <summary>
/// The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|||")]
public partial record KeyExchangeInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "KeyXchgInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_2CqhVlWVEeeiG_nL4vgKnQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header44 Header { get; init; }
    
    /// <summary>
    /// Information related to a key exchange activity.
    /// </summary>
    [IsoId("_2CqhWVWVEeeiG_nL4vgKnQ")]
    [Description(@"Information related to a key exchange activity.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required KeyExchangeInitiation1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_2CqhWFWVEeeiG_nL4vgKnQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="KeyExchangeInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public KeyExchangeInitiationV02Document ToDocument()
    {
        return new KeyExchangeInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="KeyExchangeInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record KeyExchangeInitiationV02Document : IOuterDocument<KeyExchangeInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="KeyExchangeInitiationV02"/> is required.
    /// </summary>
    public required KeyExchangeInitiationV02 Message { get; init; }
}
