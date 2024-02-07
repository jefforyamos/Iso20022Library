﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAuditTrailReport002V04.  ISO2002 ID# _ukeLF_fXEeiNZp_PtLohLw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.semt.SecuritiesSettlementTransactionAuditTrailReport002V04>;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// This record is an implementation of the semt.022.002.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.
/// 
/// Usage
/// The message may also be used to: 
/// - re-send a message sent by the market infrastructure to the direct participant,
/// - provide a third party with a copy of a message being sent by the market infrastructure for information,
/// - re-send to a third party a copy of a message being sent by the market infrastructure for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.||Usage|The message may also be used to: |- re-send a message sent by the market infrastructure to the direct participant,|- provide a third party with a copy of a message being sent by the market infrastructure for information,|- re-send to a third party a copy of a message being sent by the market infrastructure for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionAuditTrailReport002V04 : IOuterRecord<SecuritiesSettlementTransactionAuditTrailReport002V04,SecuritiesSettlementTransactionAuditTrailReport002V04Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementTransactionAuditTrailReport002V04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.022.002.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAudtTrlRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionAuditTrailReport002V04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_ukeLGffXEeiNZp_PtLohLw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// Identification of the SecuritiesStatusQuery message sent to request this report.
    /// </summary>
    [IsoId("_ukeLG_fXEeiNZp_PtLohLw")]
    [Description(@"Identification of the SecuritiesStatusQuery message sent to request this report.")]
    [DataMember(Name="QryRef")]
    [XmlElement(ElementName="QryRef")]
    public Identification16? QueryReference { get; init; }
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_ukeLHffXEeiNZp_PtLohLw")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public TransactionIdentifications34? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ukeLH_fXEeiNZp_PtLohLw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount37 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ukeLIffXEeiNZp_PtLohLw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }
    
    /// <summary>
    ///  Provides the history of status and reasons for a pending, posted or cancelled transaction.
    /// </summary>
    [IsoId("_ukeLI_fXEeiNZp_PtLohLw")]
    [Description(@" Provides the history of status and reasons for a pending, posted or cancelled transaction.")]
    [DataMember(Name="StsTrl")]
    [XmlElement(ElementName="StsTrl")]
    public StatusTrail9? StatusTrail { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionAuditTrailReport002V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAuditTrailReport002V04Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAuditTrailReport002V04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmTxAudtTrlRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Pgntn", xmlNamespace );
        Pagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (QueryReference is Identification16 QueryReferenceValue)
        {
            writer.WriteStartElement(null, "QryRef", xmlNamespace );
            QueryReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionIdentification is TransactionIdentifications34 TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            TransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification156 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatusTrail is StatusTrail9 StatusTrailValue)
        {
            writer.WriteStartElement(null, "StsTrl", xmlNamespace );
            StatusTrailValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSettlementTransactionAuditTrailReport002V04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionAuditTrailReport002V04"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionAuditTrailReport002V04Document : IOuterDocument<SecuritiesSettlementTransactionAuditTrailReport002V04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.022.002.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionAuditTrailReport002V04"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementTransactionAuditTrailReport002V04.XmlTag)]
    public required SecuritiesSettlementTransactionAuditTrailReport002V04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementTransactionAuditTrailReport002V04.XmlTag);
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
