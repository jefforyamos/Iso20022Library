﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionStatementReportV07.  ISO2002 ID# _65Nzi5SbEeeh5JjedkaA_g.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionInstructionStatementReportV07>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.042.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionInstructionStatementReport message to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends the CorporateActionInstructionStatementReport message to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstructionStatementReportV07 : IOuterRecord<CorporateActionInstructionStatementReportV07,CorporateActionInstructionStatementReportV07Document>
    ,IIsoXmlSerilizable<CorporateActionInstructionStatementReportV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.042.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStmtRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionInstructionStatementReportV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_65NzkZSbEeeh5JjedkaA_g")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// General characteristics related to a statement which reports information.
    /// </summary>
    [IsoId("_65Nzk5SbEeeh5JjedkaA_g")]
    [Description(@"General characteristics related to a statement which reports information.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement65 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Account information and detailed account holdings information report for corporate action events.
    /// </summary>
    [IsoId("_65NzlZSbEeeh5JjedkaA_g")]
    [Description(@"Account information and detailed account holdings information report for corporate action events.")]
    [DataMember(Name="AcctAndStmtDtls")]
    [XmlElement(ElementName="AcctAndStmtDtls")]
    [Required]
    public required AccountIdentification43 AccountAndStatementDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_65Nzl5SbEeeh5JjedkaA_g")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionStatementReportV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionStatementReportV07Document ToDocument()
    {
        return new CorporateActionInstructionStatementReportV07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnInstrStmtRpt");
    
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
        writer.WriteStartElement(null, "StmtGnlDtls", xmlNamespace );
        StatementGeneralDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctAndStmtDtls", xmlNamespace );
        AccountAndStatementDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionInstructionStatementReportV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionStatementReportV07"/>.
/// </summary>
[Serializable]
public partial record CorporateActionInstructionStatementReportV07Document : IOuterDocument<CorporateActionInstructionStatementReportV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.042.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionStatementReportV07"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionInstructionStatementReportV07.XmlTag)]
    public required CorporateActionInstructionStatementReportV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionInstructionStatementReportV07.XmlTag);
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
