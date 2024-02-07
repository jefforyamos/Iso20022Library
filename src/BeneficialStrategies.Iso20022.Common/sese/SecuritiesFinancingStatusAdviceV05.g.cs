﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingStatusAdviceV05.  ISO2002 ID# _h59nEU3OEeS1yPC0JC-FvQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesFinancingStatusAdviceV05>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.034.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[Description(@"Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesFinancingStatusAdviceV05 : IOuterRecord<SecuritiesFinancingStatusAdviceV05,SecuritiesFinancingStatusAdviceV05Document>
    ,IIsoXmlSerilizable<SecuritiesFinancingStatusAdviceV05>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.034.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesFinancingStatusAdviceV05Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_h59nGU3OEeS1yPC0JC-FvQ")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required TransactionIdentifications1 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Processing status of the transaction.
    /// </summary>
    [IsoId("_h59nG03OEeS1yPC0JC-FvQ")]
    [Description(@"Processing status of the transaction.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    public ProcessingStatus38Choice_? ProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_h59nHU3OEeS1yPC0JC-FvQ")]
    [Description(@"Provides the matching status of the instruction.")]
    [DataMember(Name="MtchgSts")]
    [XmlElement(ElementName="MtchgSts")]
    public MatchingStatus20Choice_? MatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_h59nH03OEeS1yPC0JC-FvQ")]
    [Description(@"Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).")]
    [DataMember(Name="IfrrdMtchgSts")]
    [XmlElement(ElementName="IfrrdMtchgSts")]
    public MatchingStatus20Choice_? InferredMatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_h59nIU3OEeS1yPC0JC-FvQ")]
    [Description(@"Provides the status of settlement of a transaction.")]
    [DataMember(Name="SttlmSts")]
    [XmlElement(ElementName="SttlmSts")]
    public SettlementStatus10Choice_? SettlementStatus { get; init; }
    
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_h59nI03OEeS1yPC0JC-FvQ")]
    [Description(@"Provides the status of the repurchase agreement call request.")]
    [DataMember(Name="RepoCallReqSts")]
    [XmlElement(ElementName="RepoCallReqSts")]
    public RepoCallRequestStatus5Choice_? RepoCallRequestStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_h59nJU3OEeS1yPC0JC-FvQ")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public SecuritiesFinancingTransactionDetails24? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_h59nJ03OEeS1yPC0JC-FvQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingStatusAdviceV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingStatusAdviceV05Document ToDocument()
    {
        return new SecuritiesFinancingStatusAdviceV05Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesFincgStsAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProcessingStatus is ProcessingStatus38Choice_ ProcessingStatusValue)
        {
            writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
            ProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MatchingStatus is MatchingStatus20Choice_ MatchingStatusValue)
        {
            writer.WriteStartElement(null, "MtchgSts", xmlNamespace );
            MatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InferredMatchingStatus is MatchingStatus20Choice_ InferredMatchingStatusValue)
        {
            writer.WriteStartElement(null, "IfrrdMtchgSts", xmlNamespace );
            InferredMatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementStatus is SettlementStatus10Choice_ SettlementStatusValue)
        {
            writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
            SettlementStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepoCallRequestStatus is RepoCallRequestStatus5Choice_ RepoCallRequestStatusValue)
        {
            writer.WriteStartElement(null, "RepoCallReqSts", xmlNamespace );
            RepoCallRequestStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionDetails is SecuritiesFinancingTransactionDetails24 TransactionDetailsValue)
        {
            writer.WriteStartElement(null, "TxDtls", xmlNamespace );
            TransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesFinancingStatusAdviceV05 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingStatusAdviceV05"/>.
/// </summary>
[Serializable]
public partial record SecuritiesFinancingStatusAdviceV05Document : IOuterDocument<SecuritiesFinancingStatusAdviceV05>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.034.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingStatusAdviceV05"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesFinancingStatusAdviceV05.XmlTag)]
    public required SecuritiesFinancingStatusAdviceV05 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesFinancingStatusAdviceV05.XmlTag);
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
