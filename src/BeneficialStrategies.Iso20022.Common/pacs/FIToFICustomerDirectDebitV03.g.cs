﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFICustomerDirectDebitV03.  ISO2002 ID# _sFjsAFkyEeGeoaLUQk__nA_-835726399.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.pacs.FIToFICustomerDirectDebitV03>;

namespace BeneficialStrategies.Iso20022.pacs;


/// <summary>
/// This record is an implementation of the pacs.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to collect funds from a debtor account for a creditor.
/// Usage
/// The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.
/// The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.
/// The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.
/// The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.|It is used to collect funds from a debtor account for a creditor.|Usage|The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.|The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.|The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.|The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.")]
public partial record FIToFICustomerDirectDebitV03 : IOuterRecord<FIToFICustomerDirectDebitV03,FIToFICustomerDirectDebitV03Document>
    ,IIsoXmlSerilizable<FIToFICustomerDirectDebitV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFICstmrDrctDbt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FIToFICustomerDirectDebitV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_sFjsAVkyEeGeoaLUQk__nA_-1215216838")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader50 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements providing information specific to the individual direct debit(s).
    /// </summary>
    [IsoId("_sFjsAlkyEeGeoaLUQk__nA_-2098450125")]
    [Description(@"Set of elements providing information specific to the individual direct debit(s).")]
    [DataMember(Name="DrctDbtTxInf")]
    [XmlElement(ElementName="DrctDbtTxInf")]
    [Required]
    public required DirectDebitTransactionInformation12 DirectDebitTransactionInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sFjsA1kyEeGeoaLUQk__nA_833637444")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFICustomerDirectDebitV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFICustomerDirectDebitV03Document ToDocument()
    {
        return new FIToFICustomerDirectDebitV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FIToFICstmrDrctDbt");
    
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
        writer.WriteStartElement(null, "DrctDbtTxInf", xmlNamespace );
        DirectDebitTransactionInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FIToFICustomerDirectDebitV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFICustomerDirectDebitV03"/>.
/// </summary>
[Serializable]
public partial record FIToFICustomerDirectDebitV03Document : IOuterDocument<FIToFICustomerDirectDebitV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFICustomerDirectDebitV03"/> is required.
    /// </summary>
    [DataMember(Name=FIToFICustomerDirectDebitV03.XmlTag)]
    public required FIToFICustomerDirectDebitV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FIToFICustomerDirectDebitV03.XmlTag);
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
