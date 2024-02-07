﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionCounterpartyResponseV03.  ISO2002 ID# _dKoWoQyQEeuG8M5giQ2e0w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesSettlementTransactionCounterpartyResponseV03>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.040.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:
/// - the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)
/// - the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.
/// The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// The account owner may be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:|- the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)|- the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.|The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants|The account owner may be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionCounterpartyResponseV03 : IOuterRecord<SecuritiesSettlementTransactionCounterpartyResponseV03,SecuritiesSettlementTransactionCounterpartyResponseV03Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementTransactionCounterpartyResponseV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.040.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxCtrPtyRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionCounterpartyResponseV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_dKoWpwyQEeuG8M5giQ2e0w")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required TransactionIdentification6 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides the response status related to an allegement or a counterparty's instruction.
    /// </summary>
    [IsoId("_dKoWqQyQEeuG8M5giQ2e0w")]
    [Description(@"Provides the response status related to an allegement or a counterparty's instruction.")]
    [DataMember(Name="RspnSts")]
    [XmlElement(ElementName="RspnSts")]
    [Required]
    public required ResponseStatus6Choice_ ResponseStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_dKoWqwyQEeuG8M5giQ2e0w")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public TransactionDetails138? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dKoWrQyQEeuG8M5giQ2e0w")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionCounterpartyResponseV03Document ToDocument()
    {
        return new SecuritiesSettlementTransactionCounterpartyResponseV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmTxCtrPtyRspn");
    
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
        writer.WriteStartElement(null, "RspnSts", xmlNamespace );
        ResponseStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionDetails is TransactionDetails138 TransactionDetailsValue)
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
    public static SecuritiesSettlementTransactionCounterpartyResponseV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV03"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionCounterpartyResponseV03Document : IOuterDocument<SecuritiesSettlementTransactionCounterpartyResponseV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.040.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV03"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementTransactionCounterpartyResponseV03.XmlTag)]
    public required SecuritiesSettlementTransactionCounterpartyResponseV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementTransactionCounterpartyResponseV03.XmlTag);
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
