﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ShareholderIdentificationDisclosureResponseStatusAdviceV01.  ISO2002 ID# _NCNMYHC5EemNhNOCZKENuw.
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
/// The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.
/// Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.|Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report.")]
public partial record ShareholderIdentificationDisclosureResponseStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrIdDsclsrRspnStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Unique identification of the disclosure response for which the status advice is sent.
    /// </summary>
    [IsoId("_9xsWBYd9EemJ1cSJJmVYRQ")]
    [Description(@"Unique identification of the disclosure response for which the status advice is sent.")]
    [DataMember(Name="DsclsrRspnId")]
    [XmlElement(ElementName="DsclsrRspnId")]
    [Required]
    public required IsoMax35Text DisclosureResponseIdentification { get; init; }
    
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_Eq5WgbRBEem2T48lBgJbww")]
    [Description(@"Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.")]
    [DataMember(Name="IssrDsclsrReqRef")]
    [XmlElement(ElementName="IssrDsclsrReqRef")]
    [Required]
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; }
    
    /// <summary>
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_9xsWB4d9EemJ1cSJJmVYRQ")]
    [Description(@"Unique identification of the intermediary party responding to the shareholders identification disclosure request.")]
    [DataMember(Name="RspndgIntrmy")]
    [XmlElement(ElementName="RspndgIntrmy")]
    [Required]
    public required PartyIdentification215 RespondingIntermediary { get; init; }
    
    /// <summary>
    /// Acceptance status of the shareholder disclosure Identification Response message/report.
    /// </summary>
    [IsoId("_lGAS0IeSEemJ1cSJJmVYRQ")]
    [Description(@"Acceptance status of the shareholder disclosure Identification Response message/report.")]
    [DataMember(Name="RspnRcptnSts")]
    [XmlElement(ElementName="RspnRcptnSts")]
    [Required]
    public required IResponseProcessingStatus1Choice ResponseReceptionStatus { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-bsZoYebEemJ1cSJJmVYRQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ShareholderIdentificationDisclosureResponseStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ShareholderIdentificationDisclosureResponseStatusAdviceV01Document ToDocument()
    {
        return new ShareholderIdentificationDisclosureResponseStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ShareholderIdentificationDisclosureResponseStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ShareholderIdentificationDisclosureResponseStatusAdviceV01Document : IOuterDocument<ShareholderIdentificationDisclosureResponseStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.049.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ShareholderIdentificationDisclosureResponseStatusAdviceV01"/> is required.
    /// </summary>
    public required ShareholderIdentificationDisclosureResponseStatusAdviceV01 Message { get; init; }
}
