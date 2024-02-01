﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ShareholdersIdentificationDisclosureRequestV04.  ISO2002 ID# _n1QvATWfEe2OzdGcZrUAEQ.
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
/// This record is an implementation of the seev.045.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.")]
public partial record ShareholdersIdentificationDisclosureRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.045.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReq";
    
    #nullable enable
    /// <summary>
    /// Official and unique identification assigned to a shareholder identification disclosure request process by the issuer or third party nominated by it.
    /// </summary>
    [IsoId("_n1QvCzWfEe2OzdGcZrUAEQ")]
    [Description(@"Official and unique identification assigned to a shareholder identification disclosure request process by the issuer or third party nominated by it.")]
    [DataMember(Name="IssrDsclsrReqId")]
    [XmlElement(ElementName="IssrDsclsrReqId")]
    [Required]
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; }
    
    /// <summary>
    /// Specifies the type of disclosure request.
    /// </summary>
    [IsoId("_n1QvDTWfEe2OzdGcZrUAEQ")]
    [Description(@"Specifies the type of disclosure request.")]
    [DataMember(Name="DsclsrReqTp")]
    [XmlElement(ElementName="DsclsrReqTp")]
    [Required]
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; }
    
    /// <summary>
    /// Identification of a previously sent shareholder identification disclosure request message.
    /// </summary>
    [IsoId("_n1QvDzWfEe2OzdGcZrUAEQ")]
    [Description(@"Identification of a previously sent shareholder identification disclosure request message.")]
    [DataMember(Name="PrvsDsclsrReqId")]
    [XmlElement(ElementName="PrvsDsclsrReqId")]
    public IsoMax35Text? PreviousDisclosureRequestIdentification { get; init; }
    
    /// <summary>
    /// Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. If the request is not to be forwarded, the indicator may not be present.
    /// </summary>
    [IsoId("_n1QvETWfEe2OzdGcZrUAEQ")]
    [Description(@"Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. If the request is not to be forwarded, the indicator may not be present.")]
    [DataMember(Name="FwdReqInd")]
    [XmlElement(ElementName="FwdReqInd")]
    public IsoYesNoIndicator? ForwardRequestIndicator { get; init; }
    
    /// <summary>
    /// Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. 
    /// If "true" or "1", the response must be sent back through the chain of intermediaries.
    /// If "false" or "0" or if the indicator is not present, the response must be sent directly to the identified response recipient.
    /// </summary>
    [IsoId("_n1QvEzWfEe2OzdGcZrUAEQ")]
    [Description(@"Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. |If ""true"" or ""1"", the response must be sent back through the chain of intermediaries.|If ""false"" or ""0"" or if the indicator is not present, the response must be sent directly to the identified response recipient.")]
    [DataMember(Name="RspnThrghChainInd")]
    [XmlElement(ElementName="RspnThrghChainInd")]
    public IsoYesNoIndicator? ResponseThroughChainIndicator { get; init; }
    
    /// <summary>
    /// Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_n1QvFTWfEe2OzdGcZrUAEQ")]
    [Description(@"Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.")]
    [DataMember(Name="ShrhldrRghtsDrctvInd")]
    [XmlElement(ElementName="ShrhldrRghtsDrctvInd")]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }
    
    /// <summary>
    /// Governing law or place of jurisdiction where the disclosure request relates to. 
    /// </summary>
    [IsoId("_GcnS0DWgEe2OzdGcZrUAEQ")]
    [Description(@"Governing law or place of jurisdiction where the disclosure request relates to. ")]
    [DataMember(Name="PlcOfJursdctn")]
    [XmlElement(ElementName="PlcOfJursdctn")]
    public CountryCode? PlaceOfJurisdiction { get; init; }
    
    /// <summary>
    /// Identification of the law which relates to the disclosure request.
    /// </summary>
    [IsoId("_qJ2yYDWgEe2OzdGcZrUAEQ")]
    [Description(@"Identification of the law which relates to the disclosure request.")]
    [DataMember(Name="AplblLaw")]
    [XmlElement(ElementName="AplblLaw")]
    public IsoMax140Text? ApplicableLaw { get; init; }
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_n1QvFzWfEe2OzdGcZrUAEQ")]
    [Description(@"Identifies the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Date set by the issuer on which the shareholders identity is determined based on the settled positions struck in the books of the issuer CSD or any other first intermediary at the close of business day. 
    /// </summary>
    [IsoId("_n1QvGTWfEe2OzdGcZrUAEQ")]
    [Description(@"Date set by the issuer on which the shareholders identity is determined based on the settled positions struck in the books of the issuer CSD or any other first intermediary at the close of business day. ")]
    [DataMember(Name="ShrhldrsDsclsrRcrdDt")]
    [XmlElement(ElementName="ShrhldrsDsclsrRcrdDt")]
    [Required]
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; }
    
    /// <summary>
    /// Minimum number of shares held by a shareholder above which the identification must be disclosed.
    /// </summary>
    [IsoId("_n1QvGzWfEe2OzdGcZrUAEQ")]
    [Description(@"Minimum number of shares held by a shareholder above which the identification must be disclosed.")]
    [DataMember(Name="ShrsQtyThrshld")]
    [XmlElement(ElementName="ShrsQtyThrshld")]
    public IsoDecimalNumber? SharesQuantityThreshold { get; init; }
    
    /// <summary>
    /// Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated. The method can be provided either with a predefined code or via a textual description.
    /// </summary>
    [IsoId("_n1QvHTWfEe2OzdGcZrUAEQ")]
    [Description(@"Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated. The method can be provided either with a predefined code or via a textual description.")]
    [DataMember(Name="ReqShrHeldDt")]
    [XmlElement(ElementName="ReqShrHeldDt")]
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; init; }
    
    /// <summary>
    /// Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.
    /// </summary>
    [IsoId("_n1QvHzWfEe2OzdGcZrUAEQ")]
    [Description(@"Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.")]
    [DataMember(Name="DsclsrRspnRcpt")]
    [XmlElement(ElementName="DsclsrRspnRcpt")]
    [Required]
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; }
    
    /// <summary>
    /// Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  
    /// </summary>
    [IsoId("_n1QvITWfEe2OzdGcZrUAEQ")]
    [Description(@"Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  ")]
    [DataMember(Name="IssrDsclsrDdln")]
    [XmlElement(ElementName="IssrDsclsrDdln")]
    [Required]
    public required DateFormat46Choice_ IssuerDisclosureDeadline { get; init; }
    
    /// <summary>
    /// Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  
    /// </summary>
    [IsoId("_n1QvIzWfEe2OzdGcZrUAEQ")]
    [Description(@"Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  ")]
    [DataMember(Name="DsclsrRspnDdln")]
    [XmlElement(ElementName="DsclsrRspnDdln")]
    public DateFormat46Choice_? DisclosureResponseDeadline { get; init; }
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_n1QvJTWfEe2OzdGcZrUAEQ")]
    [Description(@"Issuer of the financial instrument.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_n1QvJzWfEe2OzdGcZrUAEQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ShareholdersIdentificationDisclosureRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ShareholdersIdentificationDisclosureRequestV04Document ToDocument()
    {
        return new ShareholdersIdentificationDisclosureRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ShareholdersIdentificationDisclosureRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ShareholdersIdentificationDisclosureRequestV04Document : IOuterDocument<ShareholdersIdentificationDisclosureRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.045.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ShareholdersIdentificationDisclosureRequestV04"/> is required.
    /// </summary>
    public required ShareholdersIdentificationDisclosureRequestV04 Message { get; init; }
}
