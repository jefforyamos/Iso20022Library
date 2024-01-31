﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AmendmentV02.  ISO2002 ID# _5FbJsRykEeyVgKPonV4SjQ.
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
/// The Amendment message can be initiated by any party and received by any party (acquirer, agent or issuer). 
/// This message is used to inform the originator that the original message has been corrected/amended and then forwarded to the destination on behalf of the originator. It contains a copy of the original message and any errors found. It may also contain any corrections and/or amendments that were made to the original message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The Amendment message can be initiated by any party and received by any party (acquirer, agent or issuer). ||This message is used to inform the originator that the original message has been corrected/amended and then forwarded to the destination on behalf of the originator. It contains a copy of the original message and any errors found. It may also contain any corrections and/or amendments that were made to the original message.|")]
public partial record AmendmentV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Amdmnt";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_5FbwwRykEeyVgKPonV4SjQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header65 Header { get; init; }
    
    /// <summary>
    /// Information related to the Amendment message.
    /// </summary>
    [IsoId("_5FbwwxykEeyVgKPonV4SjQ")]
    [Description(@"Information related to the Amendment message.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required Amendment11 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_5FbwxRykEeyVgKPonV4SjQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AmendmentV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AmendmentV02Document ToDocument()
    {
        return new AmendmentV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AmendmentV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AmendmentV02Document : IOuterDocument<AmendmentV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.020.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AmendmentV02"/> is required.
    /// </summary>
    public required AmendmentV02 Message { get; init; }
}
