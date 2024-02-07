﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingInvalidReferenceDataReportV02.  ISO2002 ID# _vXohoSdoEei12pGEsJIAeQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.FinancialInstrumentReportingInvalidReferenceDataReportV02>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.042.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument.
/// </summary>
[Serializable]
[Description(@"The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument.")]
public partial record FinancialInstrumentReportingInvalidReferenceDataReportV02 : IOuterRecord<FinancialInstrumentReportingInvalidReferenceDataReportV02,FinancialInstrumentReportingInvalidReferenceDataReportV02Document>
    ,IIsoXmlSerilizable<FinancialInstrumentReportingInvalidReferenceDataReportV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.042.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgInvldRefDataRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FinancialInstrumentReportingInvalidReferenceDataReportV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Date period capturing when instruments in the report have been invalidated
    /// Usage:
    /// Within MiFIR, only the From Date To Date field will be used with the From Date corresponding to the date the first instrument was added to this report while the To Date is the date the last instrument was added to the file.
    /// </summary>
    [IsoId("_vXohoydoEei12pGEsJIAeQ")]
    [Description(@"Date period capturing when instruments in the report have been invalidated||Usage:|Within MiFIR, only the From Date To Date field will be used with the From Date corresponding to the date the first instrument was added to this report while the To Date is the date the last instrument was added to the file.")]
    [DataMember(Name="DtPrd")]
    [XmlElement(ElementName="DtPrd")]
    [Required]
    public required Period4Choice_ DatePeriod { get; init; }
    
    /// <summary>
    /// Number of invalid records in this message.
    /// </summary>
    [IsoId("_vXohpSdoEei12pGEsJIAeQ")]
    [Description(@"Number of invalid records in this message.|")]
    [DataMember(Name="NbOfRcrds")]
    [XmlElement(ElementName="NbOfRcrds")]
    public IsoNumber? NumberOfRecords { get; init; }
    
    /// <summary>
    /// Provides the details of the financial instruments.
    /// </summary>
    [IsoId("_vXohpydoEei12pGEsJIAeQ")]
    [Description(@"Provides the details of the financial instruments.")]
    [DataMember(Name="FinInstrms")]
    [XmlElement(ElementName="FinInstrms")]
    [Required]
    public required SecuritiesInvalidReferenceDataReport4 FinancialInstruments { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vXohqSdoEei12pGEsJIAeQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingInvalidReferenceDataReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingInvalidReferenceDataReportV02Document ToDocument()
    {
        return new FinancialInstrumentReportingInvalidReferenceDataReportV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FinInstrmRptgInvldRefDataRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "DtPrd", xmlNamespace );
        DatePeriod.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NumberOfRecords is IsoNumber NumberOfRecordsValue)
        {
            writer.WriteStartElement(null, "NbOfRcrds", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfRecordsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrms", xmlNamespace );
        FinancialInstruments.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentReportingInvalidReferenceDataReportV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingInvalidReferenceDataReportV02"/>.
/// </summary>
[Serializable]
public partial record FinancialInstrumentReportingInvalidReferenceDataReportV02Document : IOuterDocument<FinancialInstrumentReportingInvalidReferenceDataReportV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.042.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingInvalidReferenceDataReportV02"/> is required.
    /// </summary>
    [DataMember(Name=FinancialInstrumentReportingInvalidReferenceDataReportV02.XmlTag)]
    public required FinancialInstrumentReportingInvalidReferenceDataReportV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FinancialInstrumentReportingInvalidReferenceDataReportV02.XmlTag);
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
