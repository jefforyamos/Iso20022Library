﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMExceptionAcknowledgementV01.  ISO2002 ID# _YFLI0K5GEeWCgYcWSNgX5g.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caam;


/// <summary>
/// The ATMExceptionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMExceptionAdvice message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMExceptionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMExceptionAdvice message.")]
public partial record ATMExceptionAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMXcptnAck";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_fpPXMK5GEeWCgYcWSNgX5g")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header32 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_k_u6wK5GEeWCgYcWSNgX5g")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMXcptnAck")]
    [XmlElement(ElementName="PrtctdATMXcptnAck")]
    public ContentInformationType10? ProtectedATMExceptionAcknowledgement { get; init; }
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM exception.
    /// </summary>
    [IsoId("_ogUFkK5GEeWCgYcWSNgX5g")]
    [Description(@"Information related to the acknowledgement of an ATM exception.")]
    [DataMember(Name="ATMXcptnAck")]
    [XmlElement(ElementName="ATMXcptnAck")]
    public ATMExceptionAcknowledgement1? ATMExceptionAcknowledgement { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_kRgtYK5HEeWCgYcWSNgX5g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMExceptionAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMExceptionAcknowledgementV01Document ToDocument()
    {
        return new ATMExceptionAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMExceptionAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMExceptionAcknowledgementV01Document : IOuterDocument<ATMExceptionAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMExceptionAcknowledgementV01"/> is required.
    /// </summary>
    public required ATMExceptionAcknowledgementV01 Message { get; init; }
}
