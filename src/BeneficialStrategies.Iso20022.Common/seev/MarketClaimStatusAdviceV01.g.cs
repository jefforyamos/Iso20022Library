﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarketClaimStatusAdviceV01.  ISO2002 ID# _W1npgNsFEeqmdMJWobugpw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MarketClaimStatusAdviceV01>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.052.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope and Usage|The MarketClaimStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MarketClaimStatusAdviceV01 : IOuterRecord<MarketClaimStatusAdviceV01,MarketClaimStatusAdviceV01Document>
    ,IIsoXmlSerilizable<MarketClaimStatusAdviceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.052.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MarketClaimStatusAdviceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("__v67INx2EeqESbVR5AloZQ")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="MktClmCreId")]
    [XmlElement(ElementName="MktClmCreId")]
    public DocumentIdentification9? MarketClaimCreationIdentification { get; init; }
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_LOMVRNx3EeqESbVR5AloZQ")]
    [Description(@"References of the transaction for which the securities settlement condition modification is requested.")]
    [DataMember(Name="TxRef")]
    [XmlElement(ElementName="TxRef")]
    [Required]
    public required References26 TransactionReference { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_LOM8UNx3EeqESbVR5AloZQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_B_PP4TDNEeunENYTWutRtQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    public AccountIdentification46? AccountDetails { get; init; }
    
    /// <summary>
    /// Status information about the processing of the market claim transaction.
    /// </summary>
    [IsoId("_VoUx0Nx3EeqESbVR5AloZQ")]
    [Description(@"Status information about the processing of the market claim transaction.")]
    [DataMember(Name="MktClmPrcgSts")]
    [XmlElement(ElementName="MktClmPrcgSts")]
    [Required]
    public required MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; init; }
    
    /// <summary>
    /// Details of the market claim transaction for which a status is provided.
    /// </summary>
    [IsoId("_LOM8Udx3EeqESbVR5AloZQ")]
    [Description(@"Details of the market claim transaction for which a status is provided.")]
    [DataMember(Name="MktClmDtls")]
    [XmlElement(ElementName="MktClmDtls")]
    public CorporateActionOption185? MarketClaimDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ODyf0SgaEeuYwc3diVMizA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarketClaimStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarketClaimStatusAdviceV01Document ToDocument()
    {
        return new MarketClaimStatusAdviceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MktClmStsAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (MarketClaimCreationIdentification is DocumentIdentification9 MarketClaimCreationIdentificationValue)
        {
            writer.WriteStartElement(null, "MktClmCreId", xmlNamespace );
            MarketClaimCreationIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxRef", xmlNamespace );
        TransactionReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountDetails is AccountIdentification46 AccountDetailsValue)
        {
            writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
            AccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MktClmPrcgSts", xmlNamespace );
        MarketClaimProcessingStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarketClaimDetails is CorporateActionOption185 MarketClaimDetailsValue)
        {
            writer.WriteStartElement(null, "MktClmDtls", xmlNamespace );
            MarketClaimDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MarketClaimStatusAdviceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarketClaimStatusAdviceV01"/>.
/// </summary>
[Serializable]
public partial record MarketClaimStatusAdviceV01Document : IOuterDocument<MarketClaimStatusAdviceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.052.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarketClaimStatusAdviceV01"/> is required.
    /// </summary>
    [DataMember(Name=MarketClaimStatusAdviceV01.XmlTag)]
    public required MarketClaimStatusAdviceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MarketClaimStatusAdviceV01.XmlTag);
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
