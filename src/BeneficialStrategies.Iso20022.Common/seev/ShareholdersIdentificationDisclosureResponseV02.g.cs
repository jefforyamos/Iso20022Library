﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ShareholdersIdentificationDisclosureResponseV02.  ISO2002 ID# _9U3hhfEkEeqRfth943bvEA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// The ShareholdersIdentificationDisclosureResponse message is sent in response to a shareholder identification disclosure request message by any intermediaries to the recipient designated by the issuer (such as an issuer's agent) in the disclosure request message in order to provide the requested information on the identity of the shareholders and their accounts holdings serviced by the intermediary for the requested financial instrument.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ShareholdersIdentificationDisclosureResponse message is sent in response to a shareholder identification disclosure request message by any intermediaries to the recipient designated by the issuer (such as an issuer's agent) in the disclosure request message in order to provide the requested information on the identity of the shareholders and their accounts holdings serviced by the intermediary for the requested financial instrument.")]
public partial record ShareholdersIdentificationDisclosureResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrRspn";
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the identification disclosure response, when split in several parts (messages), is to continue or that the message is the last page of the multi-part identification disclosure response.
    /// </summary>
    [IsoId("_9U3hjfEkEeqRfth943bvEA")]
    [Description(@"Page number of the message and continuation indicator to indicate that the identification disclosure response, when split in several parts (messages), is to continue or that the message is the last page of the multi-part identification disclosure response.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_9U3hj_EkEeqRfth943bvEA")]
    [Description(@"Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.")]
    [DataMember(Name="IssrDsclsrReqRef")]
    [XmlElement(ElementName="IssrDsclsrReqRef")]
    [Required]
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; }
    
    /// <summary>
    /// Unique identification of the disclosure response. The same disclosure response identification number is to be used when the response is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_9U3hkfEkEeqRfth943bvEA")]
    [Description(@"Unique identification of the disclosure response. The same disclosure response identification number is to be used when the response is split in multiple (paginated) messages.")]
    [DataMember(Name="DsclsrRspnId")]
    [XmlElement(ElementName="DsclsrRspnId")]
    [Required]
    public required IsoMax35Text DisclosureResponseIdentification { get; init; }
    
    /// <summary>
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_9U3hk_EkEeqRfth943bvEA")]
    [Description(@"Unique identification of the intermediary party responding to the shareholders identification disclosure request.")]
    [DataMember(Name="RspndgIntrmy")]
    [XmlElement(ElementName="RspndgIntrmy")]
    [Required]
    public required PartyIdentification219 RespondingIntermediary { get; init; }
    
    /// <summary>
    /// Specifies detailed shareholding disclosure information or specifies that disclosure information is not provided.
    /// </summary>
    [IsoId("_9U3hlfEkEeqRfth943bvEA")]
    [Description(@"Specifies detailed shareholding disclosure information or specifies that disclosure information is not provided.")]
    [DataMember(Name="DsclsrInf")]
    [XmlElement(ElementName="DsclsrInf")]
    [Required]
    public required IDisclosure2Choice DisclosureInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9U3hl_EkEeqRfth943bvEA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ShareholdersIdentificationDisclosureResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ShareholdersIdentificationDisclosureResponseV02Document ToDocument()
    {
        return new ShareholdersIdentificationDisclosureResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ShareholdersIdentificationDisclosureResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ShareholdersIdentificationDisclosureResponseV02Document : IOuterDocument<ShareholdersIdentificationDisclosureResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.047.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ShareholdersIdentificationDisclosureResponseV02"/> is required.
    /// </summary>
    public required ShareholdersIdentificationDisclosureResponseV02 Message { get; init; }
}
