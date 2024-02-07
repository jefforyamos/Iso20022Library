﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionModificationRequestV05.  ISO2002 ID# _cCQpsYvSEea5B-LIompvYg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesSettlementTransactionModificationRequestV05>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.038.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an account owner to an account servicer. 
/// 
/// The account owner will generally be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an investment manager which has an account with a custodian acting as accounting and/or settlement agent.
/// 
/// It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.
/// 
/// Usage
/// The modification must only contain the data to be modified.
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionModificationRequestV05 : IOuterRecord<SecuritiesSettlementTransactionModificationRequestV05,SecuritiesSettlementTransactionModificationRequestV05Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementTransactionModificationRequestV05>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.038.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionModificationRequestV05Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the details of the transaction that is being modified.
    /// </summary>
    [IsoId("_cCQpuYvSEea5B-LIompvYg")]
    [Description(@"Identifies the details of the transaction that is being modified.")]
    [DataMember(Name="ModfdTxDtls")]
    [XmlElement(ElementName="ModfdTxDtls")]
    [Required]
    public required TransactionDetails76 ModifiedTransactionDetails { get; init; }
    
    /// <summary>
    /// Specifies the type of update requested.
    /// </summary>
    [IsoId("_cCQpu4vSEea5B-LIompvYg")]
    [Description(@"Specifies the type of update requested.")]
    [DataMember(Name="UpdTp")]
    [XmlElement(ElementName="UpdTp")]
    public required ValueList<UpdateType25Choice_> UpdateType { get; init; } = []; // Min=1, Max=3
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionModificationRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestV05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionModificationRequestV05Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmTxModReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "ModfdTxDtls", xmlNamespace );
        ModifiedTransactionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UpdTp", xmlNamespace );
        UpdateType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SecuritiesSettlementTransactionModificationRequestV05 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionModificationRequestV05"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionModificationRequestV05Document : IOuterDocument<SecuritiesSettlementTransactionModificationRequestV05>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.038.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionModificationRequestV05"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementTransactionModificationRequestV05.XmlTag)]
    public required SecuritiesSettlementTransactionModificationRequestV05 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementTransactionModificationRequestV05.XmlTag);
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
