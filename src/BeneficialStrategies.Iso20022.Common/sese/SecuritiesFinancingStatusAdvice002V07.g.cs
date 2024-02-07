﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingStatusAdvice002V07.  ISO2002 ID# _F9OSA5w1EeazcsnODTksnQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesFinancingStatusAdvice002V07>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.034.002.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.
/// The status advice may be sent as a response to the request of the account owner or not.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants
/// - an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or
/// - a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesFinancingStatusAdvice002V07 : IOuterRecord<SecuritiesFinancingStatusAdvice002V07,SecuritiesFinancingStatusAdvice002V07Document>
    ,IIsoXmlSerilizable<SecuritiesFinancingStatusAdvice002V07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.034.002.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesFinancingStatusAdvice002V07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_F9OSB5w1EeazcsnODTksnQ")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required TransactionIdentifications35 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Processing status of the transaction.
    /// </summary>
    [IsoId("_F9OSCZw1EeazcsnODTksnQ")]
    [Description(@"Processing status of the transaction.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    public ProcessingStatus57Choice_? ProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_F9OSC5w1EeazcsnODTksnQ")]
    [Description(@"Provides the matching status of the instruction.")]
    [DataMember(Name="MtchgSts")]
    [XmlElement(ElementName="MtchgSts")]
    public MatchingStatus29Choice_? MatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_F9OSDZw1EeazcsnODTksnQ")]
    [Description(@"Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).")]
    [DataMember(Name="IfrrdMtchgSts")]
    [XmlElement(ElementName="IfrrdMtchgSts")]
    public MatchingStatus29Choice_? InferredMatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_F9OSD5w1EeazcsnODTksnQ")]
    [Description(@"Provides the status of settlement of a transaction.")]
    [DataMember(Name="SttlmSts")]
    [XmlElement(ElementName="SttlmSts")]
    public SettlementStatus21Choice_? SettlementStatus { get; init; }
    
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_F9OSEZw1EeazcsnODTksnQ")]
    [Description(@"Provides the status of the repurchase agreement call request.")]
    [DataMember(Name="RepoCallReqSts")]
    [XmlElement(ElementName="RepoCallReqSts")]
    public RepoCallRequestStatus9Choice_? RepoCallRequestStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_F9OSE5w1EeazcsnODTksnQ")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public SecuritiesFinancingTransactionDetails36? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_F9OSFZw1EeazcsnODTksnQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingStatusAdvice002V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingStatusAdvice002V07Document ToDocument()
    {
        return new SecuritiesFinancingStatusAdvice002V07Document { Message = this };
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
        if (ProcessingStatus is ProcessingStatus57Choice_ ProcessingStatusValue)
        {
            writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
            ProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MatchingStatus is MatchingStatus29Choice_ MatchingStatusValue)
        {
            writer.WriteStartElement(null, "MtchgSts", xmlNamespace );
            MatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InferredMatchingStatus is MatchingStatus29Choice_ InferredMatchingStatusValue)
        {
            writer.WriteStartElement(null, "IfrrdMtchgSts", xmlNamespace );
            InferredMatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementStatus is SettlementStatus21Choice_ SettlementStatusValue)
        {
            writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
            SettlementStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepoCallRequestStatus is RepoCallRequestStatus9Choice_ RepoCallRequestStatusValue)
        {
            writer.WriteStartElement(null, "RepoCallReqSts", xmlNamespace );
            RepoCallRequestStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionDetails is SecuritiesFinancingTransactionDetails36 TransactionDetailsValue)
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
    public static SecuritiesFinancingStatusAdvice002V07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingStatusAdvice002V07"/>.
/// </summary>
[Serializable]
public partial record SecuritiesFinancingStatusAdvice002V07Document : IOuterDocument<SecuritiesFinancingStatusAdvice002V07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.034.002.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingStatusAdvice002V07"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesFinancingStatusAdvice002V07.XmlTag)]
    public required SecuritiesFinancingStatusAdvice002V07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesFinancingStatusAdvice002V07.XmlTag);
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
