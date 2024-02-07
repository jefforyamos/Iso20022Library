﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerPaymentReversalV09.  ISO2002 ID# _eYI_x22PEei3KuUgpx7Xcw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.pain.CustomerPaymentReversalV09>;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// This record is an implementation of the pain.007.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[Description(@"Scope|The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.|The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.")]
public partial record CustomerPaymentReversalV09 : IOuterRecord<CustomerPaymentReversalV09,CustomerPaymentReversalV09Document>
    ,IIsoXmlSerilizable<CustomerPaymentReversalV09>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtRvsl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CustomerPaymentReversalV09Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eYI_022PEei3KuUgpx7Xcw")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader88 GroupHeader { get; init; }
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_eYI_1W2PEei3KuUgpx7Xcw")]
    [Description(@"Information concerning the original group of transactions, to which the message refers.")]
    [DataMember(Name="OrgnlGrpInf")]
    [XmlElement(ElementName="OrgnlGrpInf")]
    [Required]
    public required OriginalGroupHeader16 OriginalGroupInformation { get; init; }
    
    /// <summary>
    /// Information concerning the original payment information, to which the reversal message refers.
    /// </summary>
    [IsoId("_eYI_122PEei3KuUgpx7Xcw")]
    [Description(@"Information concerning the original payment information, to which the reversal message refers.")]
    [DataMember(Name="OrgnlPmtInfAndRvsl")]
    [XmlElement(ElementName="OrgnlPmtInfAndRvsl")]
    public OriginalPaymentInstruction33? OriginalPaymentInformationAndReversal { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_2W2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomerPaymentReversalV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerPaymentReversalV09Document ToDocument()
    {
        return new CustomerPaymentReversalV09Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CstmrPmtRvsl");
    
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
        writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
        OriginalGroupInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalPaymentInformationAndReversal is OriginalPaymentInstruction33 OriginalPaymentInformationAndReversalValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfAndRvsl", xmlNamespace );
            OriginalPaymentInformationAndReversalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CustomerPaymentReversalV09 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustomerPaymentReversalV09"/>.
/// </summary>
[Serializable]
public partial record CustomerPaymentReversalV09Document : IOuterDocument<CustomerPaymentReversalV09>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomerPaymentReversalV09"/> is required.
    /// </summary>
    [DataMember(Name=CustomerPaymentReversalV09.XmlTag)]
    public required CustomerPaymentReversalV09 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CustomerPaymentReversalV09.XmlTag);
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
