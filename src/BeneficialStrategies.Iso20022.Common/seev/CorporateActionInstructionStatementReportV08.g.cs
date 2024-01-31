﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionStatementReportV08.  ISO2002 ID# _BBQd57T-EeiTob_PrFFUxA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.042.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstructionStatementReport message is sent by an account servicer to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionInstructionStatementReport message is sent by an account servicer to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstructionStatementReportV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.042.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStmtRpt";
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_BBQd7bT-EeiTob_PrFFUxA")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// General characteristics related to a statement which reports information.
    /// </summary>
    [IsoId("_BBQd77T-EeiTob_PrFFUxA")]
    [Description(@"General characteristics related to a statement which reports information.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement72 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Account information and detailed account holdings information report for corporate action events.
    /// </summary>
    [IsoId("_BBQd8bT-EeiTob_PrFFUxA")]
    [Description(@"Account information and detailed account holdings information report for corporate action events.")]
    [DataMember(Name="AcctAndStmtDtls")]
    [XmlElement(ElementName="AcctAndStmtDtls")]
    [Required]
    public required AccountIdentification45 AccountAndStatementDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BBQd87T-EeiTob_PrFFUxA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionStatementReportV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionStatementReportV08Document ToDocument()
    {
        return new CorporateActionInstructionStatementReportV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionStatementReportV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstructionStatementReportV08Document : IOuterDocument<CorporateActionInstructionStatementReportV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.042.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionStatementReportV08"/> is required.
    /// </summary>
    public required CorporateActionInstructionStatementReportV08 Message { get; init; }
}
