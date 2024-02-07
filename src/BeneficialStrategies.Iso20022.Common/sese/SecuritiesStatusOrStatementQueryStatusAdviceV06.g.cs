﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesStatusOrStatementQueryStatusAdviceV06.  ISO2002 ID# _yoyk4SgSEeym1_Zp1BTvEw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesStatusOrStatementQueryStatusAdviceV06>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.022.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesStatusOrStatementQueryStatusAdvice to an account owner to advise the status of a status query or statement query previously sent by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends a SecuritiesStatusOrStatementQueryStatusAdvice to an account owner to advise the status of a status query or statement query previously sent by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesStatusOrStatementQueryStatusAdviceV06 : IOuterRecord<SecuritiesStatusOrStatementQueryStatusAdviceV06,SecuritiesStatusOrStatementQueryStatusAdviceV06Document>
    ,IIsoXmlSerilizable<SecuritiesStatusOrStatementQueryStatusAdviceV06>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.022.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesStsOrStmtQryStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesStatusOrStatementQueryStatusAdviceV06Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the query as per the account owner.
    /// </summary>
    [IsoId("_yoyk6SgSEeym1_Zp1BTvEw")]
    [Description(@"Unambiguous identification of the query as per the account owner.")]
    [DataMember(Name="QryDtls")]
    [XmlElement(ElementName="QryDtls")]
    [Required]
    public required DocumentIdentification54 QueryDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_yoyk6ygSEeym1_Zp1BTvEw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_yoyk7SgSEeym1_Zp1BTvEw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_2EAcoyqFEeyR9JrVGfaMKw")]
    [Description(@"Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.")]
    [DataMember(Name="BlckChainAdrOrWllt")]
    [XmlElement(ElementName="BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
    
    /// <summary>
    /// Details of the request.
    /// </summary>
    [IsoId("_yoyk7ygSEeym1_Zp1BTvEw")]
    [Description(@"Details of the request.")]
    [DataMember(Name="StsOrStmtReqd")]
    [XmlElement(ElementName="StsOrStmtReqd")]
    public StatusOrStatement11Choice_? StatusOrStatementRequested { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_yoyk8SgSEeym1_Zp1BTvEw")]
    [Description(@"Provides details on the processing status of the request.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required ProcessingStatus89Choice_ ProcessingStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yoyk8ygSEeym1_Zp1BTvEw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesStatusOrStatementQueryStatusAdviceV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesStatusOrStatementQueryStatusAdviceV06Document ToDocument()
    {
        return new SecuritiesStatusOrStatementQueryStatusAdviceV06Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesStsOrStmtQryStsAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "QryDtls", xmlNamespace );
        QueryDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification144 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is BlockChainAddressWallet3 BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            BlockChainAddressOrWalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatusOrStatementRequested is StatusOrStatement11Choice_ StatusOrStatementRequestedValue)
        {
            writer.WriteStartElement(null, "StsOrStmtReqd", xmlNamespace );
            StatusOrStatementRequestedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
        ProcessingStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesStatusOrStatementQueryStatusAdviceV06 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesStatusOrStatementQueryStatusAdviceV06"/>.
/// </summary>
[Serializable]
public partial record SecuritiesStatusOrStatementQueryStatusAdviceV06Document : IOuterDocument<SecuritiesStatusOrStatementQueryStatusAdviceV06>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.022.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesStatusOrStatementQueryStatusAdviceV06"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesStatusOrStatementQueryStatusAdviceV06.XmlTag)]
    public required SecuritiesStatusOrStatementQueryStatusAdviceV06 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesStatusOrStatementQueryStatusAdviceV06.XmlTag);
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
