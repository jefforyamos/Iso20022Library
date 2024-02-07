﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ShareholdersIdentificationDisclosureRequestV01.  ISO2002 ID# _BGiKcDnYEemL_ewJY9QP1g.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.ShareholdersIdentificationDisclosureRequestV01>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.045.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.
/// </summary>
[Serializable]
[Description(@"The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.")]
public partial record ShareholdersIdentificationDisclosureRequestV01 : IOuterRecord<ShareholdersIdentificationDisclosureRequestV01,ShareholdersIdentificationDisclosureRequestV01Document>
    ,IIsoXmlSerilizable<ShareholdersIdentificationDisclosureRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.045.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ShareholdersIdentificationDisclosureRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it.
    /// </summary>
    [IsoId("_gqVyoDncEemL_ewJY9QP1g")]
    [Description(@"Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it.")]
    [DataMember(Name="IssrDsclsrReqId")]
    [XmlElement(ElementName="IssrDsclsrReqId")]
    [Required]
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; }
    
    /// <summary>
    /// Specifies the type of disclosure request.
    /// </summary>
    [IsoId("_oF6hcDneEemL_ewJY9QP1g")]
    [Description(@"Specifies the type of disclosure request.")]
    [DataMember(Name="DsclsrReqTp")]
    [XmlElement(ElementName="DsclsrReqTp")]
    [Required]
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; }
    
    /// <summary>
    /// Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. 
    /// If not to be forwarded, the indicator may not be present.
    /// </summary>
    [IsoId("_s9Uf0DnfEemL_ewJY9QP1g")]
    [Description(@"Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. |If not to be forwarded, the indicator may not be present.")]
    [DataMember(Name="FwdReqInd")]
    [XmlElement(ElementName="FwdReqInd")]
    public IsoYesNoIndicator? ForwardRequestIndicator { get; init; }
    
    /// <summary>
    /// Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. 
    /// If "true" or "1", the response must be sent back through the chain of intermediaries.
    /// If "false" or "0", the response must be sent directly to the identified response recipient and the indicator may not be present.
    /// </summary>
    [IsoId("_-1rLMHI3EemNhNOCZKENuw")]
    [Description(@"Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. |If ""true"" or ""1"", the response must be sent back through the chain of intermediaries.|If ""false"" or ""0"", the response must be sent directly to the identified response recipient and the indicator may not be present.")]
    [DataMember(Name="RspnThrghChainInd")]
    [XmlElement(ElementName="RspnThrghChainInd")]
    public IsoYesNoIndicator? ResponseThroughChainIndicator { get; init; }
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_NkV1UDngEemL_ewJY9QP1g")]
    [Description(@"Identifies the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day. 
    /// </summary>
    [IsoId("_cocRMDnhEemL_ewJY9QP1g")]
    [Description(@"Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day. ")]
    [DataMember(Name="ShrhldrsDsclsrRcrdDt")]
    [XmlElement(ElementName="ShrhldrsDsclsrRcrdDt")]
    [Required]
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; }
    
    /// <summary>
    /// Minimum number of shares held by a shareholder above which the identification must be disclosed.
    /// </summary>
    [IsoId("_9R7SkDnmEemL_ewJY9QP1g")]
    [Description(@"Minimum number of shares held by a shareholder above which the identification must be disclosed.")]
    [DataMember(Name="ShrsQtyThrshld")]
    [XmlElement(ElementName="ShrsQtyThrshld")]
    public IsoDecimalNumber? SharesQuantityThreshold { get; init; }
    
    /// <summary>
    /// Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated.
    /// </summary>
    [IsoId("_4xTVIDnoEemL_ewJY9QP1g")]
    [Description(@"Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated.")]
    [DataMember(Name="ReqShrHeldDt")]
    [XmlElement(ElementName="ReqShrHeldDt")]
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; init; }
    
    /// <summary>
    /// Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.
    /// </summary>
    [IsoId("_E0QJoDnpEemL_ewJY9QP1g")]
    [Description(@"Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.")]
    [DataMember(Name="DsclsrRspnRcpt")]
    [XmlElement(ElementName="DsclsrRspnRcpt")]
    [Required]
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; }
    
    /// <summary>
    /// Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  
    /// </summary>
    [IsoId("_InfZcDnjEemL_ewJY9QP1g")]
    [Description(@"Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  ")]
    [DataMember(Name="IssrDsclsrDdln")]
    [XmlElement(ElementName="IssrDsclsrDdln")]
    [Required]
    public required DateFormat46Choice_ IssuerDisclosureDeadline { get; init; }
    
    /// <summary>
    /// Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  
    /// </summary>
    [IsoId("_fD8ssHI8EemNhNOCZKENuw")]
    [Description(@"Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  ")]
    [DataMember(Name="DsclsrRspnDdln")]
    [XmlElement(ElementName="DsclsrRspnDdln")]
    public DateFormat46Choice_? DisclosureResponseDeadline { get; init; }
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_0GY5YTqREemL_ewJY9QP1g")]
    [Description(@"Issuer of the financial instrument.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-NwmYTtfEemIf7eyjCwinw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ShareholdersIdentificationDisclosureRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ShareholdersIdentificationDisclosureRequestV01Document ToDocument()
    {
        return new ShareholdersIdentificationDisclosureRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ShrhldrsIdDsclsrReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "IssrDsclsrReqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerDisclosureRequestIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DsclsrReqTp", xmlNamespace );
        writer.WriteValue(DisclosureRequestType.ToString()); // Enum value
        writer.WriteEndElement();
        if (ForwardRequestIndicator is IsoYesNoIndicator ForwardRequestIndicatorValue)
        {
            writer.WriteStartElement(null, "FwdReqInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ForwardRequestIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ResponseThroughChainIndicator is IsoYesNoIndicator ResponseThroughChainIndicatorValue)
        {
            writer.WriteStartElement(null, "RspnThrghChainInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ResponseThroughChainIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ShrhldrsDsclsrRcrdDt", xmlNamespace );
        ShareholdersDisclosureRecordDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SharesQuantityThreshold is IsoDecimalNumber SharesQuantityThresholdValue)
        {
            writer.WriteStartElement(null, "ShrsQtyThrshld", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(SharesQuantityThresholdValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (RequestShareHeldDate is RequestShareHeldDate1Choice_ RequestShareHeldDateValue)
        {
            writer.WriteStartElement(null, "ReqShrHeldDt", xmlNamespace );
            RequestShareHeldDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DsclsrRspnRcpt", xmlNamespace );
        DisclosureResponseRecipient.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IssrDsclsrDdln", xmlNamespace );
        IssuerDisclosureDeadline.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DisclosureResponseDeadline is DateFormat46Choice_ DisclosureResponseDeadlineValue)
        {
            writer.WriteStartElement(null, "DsclsrRspnDdln", xmlNamespace );
            DisclosureResponseDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Issuer is PartyIdentification129Choice_ IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            IssuerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ShareholdersIdentificationDisclosureRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ShareholdersIdentificationDisclosureRequestV01"/>.
/// </summary>
[Serializable]
public partial record ShareholdersIdentificationDisclosureRequestV01Document : IOuterDocument<ShareholdersIdentificationDisclosureRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.045.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ShareholdersIdentificationDisclosureRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=ShareholdersIdentificationDisclosureRequestV01.XmlTag)]
    public required ShareholdersIdentificationDisclosureRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ShareholdersIdentificationDisclosureRequestV01.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
