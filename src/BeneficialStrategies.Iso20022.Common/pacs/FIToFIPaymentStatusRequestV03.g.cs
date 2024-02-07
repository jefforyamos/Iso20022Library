﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentStatusRequestV03.  ISO2002 ID# _x0JY4XL4EeidQ_AAdEzxQA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.pacs.FIToFIPaymentStatusRequestV03>;

namespace BeneficialStrategies.Iso20022.pacs;


/// <summary>
/// This record is an implementation of the pacs.028.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system. It is used to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction. 
/// Usage
/// The FIToFIPaymentStatusRequest message is exchanged between agents to request status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The FIToFIPaymentStatusRequest message can be used to request information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).
/// The FIToFIPaymentStatusRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentStatusRequest message can be used in domestic and cross-border scenarios.
/// 
/// 
/// </summary>
[Serializable]
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system. It is used to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction. |Usage|The FIToFIPaymentStatusRequest message is exchanged between agents to request status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.|The FIToFIPaymentStatusRequest message can be used to request information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).|The FIToFIPaymentStatusRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentStatusRequest message can be used in domestic and cross-border scenarios.||")]
public partial record FIToFIPaymentStatusRequestV03 : IOuterRecord<FIToFIPaymentStatusRequestV03,FIToFIPaymentStatusRequestV03Document>
    ,IIsoXmlSerilizable<FIToFIPaymentStatusRequestV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.028.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtStsReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FIToFIPaymentStatusRequestV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status request message.
    /// </summary>
    [IsoId("_x0JY63L4EeidQ_AAdEzxQA")]
    [Description(@"Set of characteristics shared by all individual transactions included in the status request message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader91 GroupHeader { get; init; }
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status request message refers to.
    /// </summary>
    [IsoId("_x0JY7XL4EeidQ_AAdEzxQA")]
    [Description(@"Original group information concerning the group of transactions, to which the status request message refers to.")]
    [DataMember(Name="OrgnlGrpInf")]
    [XmlElement(ElementName="OrgnlGrpInf")]
    public OriginalGroupInformation27? OriginalGroupInformation { get; init; }
    
    /// <summary>
    /// Information concerning the original transaction, to which the status request message refers.
    /// </summary>
    [IsoId("_x0JY73L4EeidQ_AAdEzxQA")]
    [Description(@"Information concerning the original transaction, to which the status request message refers.")]
    [DataMember(Name="TxInf")]
    [XmlElement(ElementName="TxInf")]
    public PaymentTransaction113? TransactionInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_x0JY8XL4EeidQ_AAdEzxQA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentStatusRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentStatusRequestV03Document ToDocument()
    {
        return new FIToFIPaymentStatusRequestV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FIToFIPmtStsReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
        GroupHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalGroupInformation is OriginalGroupInformation27 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionInformation is PaymentTransaction113 TransactionInformationValue)
        {
            writer.WriteStartElement(null, "TxInf", xmlNamespace );
            TransactionInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FIToFIPaymentStatusRequestV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentStatusRequestV03"/>.
/// </summary>
[Serializable]
public partial record FIToFIPaymentStatusRequestV03Document : IOuterDocument<FIToFIPaymentStatusRequestV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentStatusRequestV03"/> is required.
    /// </summary>
    [DataMember(Name=FIToFIPaymentStatusRequestV03.XmlTag)]
    public required FIToFIPaymentStatusRequestV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FIToFIPaymentStatusRequestV03.XmlTag);
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
