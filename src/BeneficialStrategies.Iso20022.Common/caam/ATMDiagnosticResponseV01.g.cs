﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDiagnosticResponseV01.  ISO2002 ID# _ImrQkItpEeSDLd7nI4Quzw.
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
/// This record is an implementation of the caam.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDiagnosticResponse message is sent by an acquirer to an ATM in response to an ATMDiagnosticRequest message ensuring the availability and the validity of the parameters.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDiagnosticResponse message is sent by an acquirer to an ATM in response to an ATMDiagnosticRequest message ensuring the availability and the validity of the parameters.")]
public partial record ATMDiagnosticResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDgnstcRspn";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_PMr7QItpEeSDLd7nI4Quzw")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header20 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_U4eZYItpEeSDLd7nI4Quzw")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDgnstcRspn")]
    [XmlElement(ElementName="PrtctdATMDgnstcRspn")]
    public ContentInformationType10? ProtectedATMDiagnosticResponse { get; init; }
    
    /// <summary>
    /// Information related to the response of a diagnostic from an ATM manager.
    /// </summary>
    [IsoId("_e_hh4ItpEeSDLd7nI4Quzw")]
    [Description(@"Information related to the response of a diagnostic from an ATM manager.")]
    [DataMember(Name="ATMDgnstcRspn")]
    [XmlElement(ElementName="ATMDgnstcRspn")]
    public ATMDiagnosticResponse1? ATMDiagnosticResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_itPJwItpEeSDLd7nI4Quzw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDiagnosticResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDiagnosticResponseV01Document ToDocument()
    {
        return new ATMDiagnosticResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDiagnosticResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDiagnosticResponseV01Document : IOuterDocument<ATMDiagnosticResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDiagnosticResponseV01"/> is required.
    /// </summary>
    public required ATMDiagnosticResponseV01 Message { get; init; }
}
