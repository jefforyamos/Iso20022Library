﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ShareholdersIdentificationDisclosureRequestV02.  ISO2002 ID# _bt4YATkqEequeo9XmZe9AQ.
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
/// The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.")]
public partial record ShareholdersIdentificationDisclosureRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReq";
    
    #nullable enable
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it.
    /// </summary>
    [IsoId("_bt4YCTkqEequeo9XmZe9AQ")]
    [Description(@"Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it.")]
    [DataMember(Name="IssrDsclsrReqId")]
    [XmlElement(ElementName="IssrDsclsrReqId")]
    [Required]
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; }
    
    /// <summary>
    /// Specifies the type of disclosure request.
    /// </summary>
    [IsoId("_bt4YCzkqEequeo9XmZe9AQ")]
    [Description(@"Specifies the type of disclosure request.")]
    [DataMember(Name="DsclsrReqTp")]
    [XmlElement(ElementName="DsclsrReqTp")]
    [Required]
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; }
    
    /// <summary>
    /// Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. 
    /// If not to be forwarded, the indicator may not be present.
    /// </summary>
    [IsoId("_bt4YDTkqEequeo9XmZe9AQ")]
    [Description(@"Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. |If not to be forwarded, the indicator may not be present.")]
    [DataMember(Name="FwdReqInd")]
    [XmlElement(ElementName="FwdReqInd")]
    public IsoYesNoIndicator? ForwardRequestIndicator { get; init; }
    
    /// <summary>
    /// Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. 
    /// If "true" or "1", the response must be sent back through the chain of intermediaries.
    /// If "false" or "0", the response must be sent directly to the identified response recipient and the indicator may not be present.
    /// </summary>
    [IsoId("_bt4YDzkqEequeo9XmZe9AQ")]
    [Description(@"Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. |If ""true"" or ""1"", the response must be sent back through the chain of intermediaries.|If ""false"" or ""0"", the response must be sent directly to the identified response recipient and the indicator may not be present.")]
    [DataMember(Name="RspnThrghChainInd")]
    [XmlElement(ElementName="RspnThrghChainInd")]
    public IsoYesNoIndicator? ResponseThroughChainIndicator { get; init; }
    
    /// <summary>
    /// Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_xPh7kTkqEequeo9XmZe9AQ")]
    [Description(@"Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.")]
    [DataMember(Name="ShrhldrRghtsDrctvInd")]
    [XmlElement(ElementName="ShrhldrRghtsDrctvInd")]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_bt4YETkqEequeo9XmZe9AQ")]
    [Description(@"Identifies the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day. 
    /// </summary>
    [IsoId("_bt4YEzkqEequeo9XmZe9AQ")]
    [Description(@"Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day. ")]
    [DataMember(Name="ShrhldrsDsclsrRcrdDt")]
    [XmlElement(ElementName="ShrhldrsDsclsrRcrdDt")]
    [Required]
    public required IDateFormat46Choice ShareholdersDisclosureRecordDate { get; init; }
    
    /// <summary>
    /// Minimum number of shares held by a shareholder above which the identification must be disclosed.
    /// </summary>
    [IsoId("_bt4YFTkqEequeo9XmZe9AQ")]
    [Description(@"Minimum number of shares held by a shareholder above which the identification must be disclosed.")]
    [DataMember(Name="ShrsQtyThrshld")]
    [XmlElement(ElementName="ShrsQtyThrshld")]
    public IsoDecimalNumber? SharesQuantityThreshold { get; init; }
    
    /// <summary>
    /// Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated.
    /// </summary>
    [IsoId("_bt4YFzkqEequeo9XmZe9AQ")]
    [Description(@"Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated.")]
    [DataMember(Name="ReqShrHeldDt")]
    [XmlElement(ElementName="ReqShrHeldDt")]
    public IRequestShareHeldDate1Choice? RequestShareHeldDate { get; init; }
    
    /// <summary>
    /// Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.
    /// </summary>
    [IsoId("_bt4YGTkqEequeo9XmZe9AQ")]
    [Description(@"Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.")]
    [DataMember(Name="DsclsrRspnRcpt")]
    [XmlElement(ElementName="DsclsrRspnRcpt")]
    [Required]
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; }
    
    /// <summary>
    /// Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  
    /// </summary>
    [IsoId("_bt4YGzkqEequeo9XmZe9AQ")]
    [Description(@"Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  ")]
    [DataMember(Name="IssrDsclsrDdln")]
    [XmlElement(ElementName="IssrDsclsrDdln")]
    [Required]
    public required IDateFormat46Choice IssuerDisclosureDeadline { get; init; }
    
    /// <summary>
    /// Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  
    /// </summary>
    [IsoId("_bt4YHTkqEequeo9XmZe9AQ")]
    [Description(@"Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  ")]
    [DataMember(Name="DsclsrRspnDdln")]
    [XmlElement(ElementName="DsclsrRspnDdln")]
    public IDateFormat46Choice? DisclosureResponseDeadline { get; init; }
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_bt4YHzkqEequeo9XmZe9AQ")]
    [Description(@"Issuer of the financial instrument.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    public IPartyIdentification129Choice? Issuer { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_bt4YITkqEequeo9XmZe9AQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ShareholdersIdentificationDisclosureRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ShareholdersIdentificationDisclosureRequestV02Document ToDocument()
    {
        return new ShareholdersIdentificationDisclosureRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ShareholdersIdentificationDisclosureRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ShareholdersIdentificationDisclosureRequestV02Document : IOuterDocument<ShareholdersIdentificationDisclosureRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.045.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ShareholdersIdentificationDisclosureRequestV02"/> is required.
    /// </summary>
    public required ShareholdersIdentificationDisclosureRequestV02 Message { get; init; }
}
