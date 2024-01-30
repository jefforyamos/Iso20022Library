﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundReferenceDataReportV03.  ISO2002 ID# _A7DpwTQaEeifw8iDiyZLmQ.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// Scope
/// The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.
/// Usage
/// A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its "home" market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.
/// The FundReferenceDataReport message may be used in various models or environments:
/// -	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.
/// -	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.
/// -	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.
/// The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) versions 1 and 2.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.|Usage|A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its ""home"" market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.|The FundReferenceDataReport message may be used in various models or environments:|-	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.|-	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.|-	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.|The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) versions 1 and 2.")]
public partial record FundReferenceDataReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndRefDataRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_A7DpwzQaEeifw8iDiyZLmQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_iClSEl9NEeicg40_9gK9vQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_iClSE19NEeicg40_9gK9vQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund reference data report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_pBDgEF9NEeicg40_9gK9vQ")]
    [Description(@"Unique and unambiguous identifier for the fund reference data report, as assigned by the reporting party.")]
    [DataMember(Name="FndRefDataRptId")]
    [XmlElement(ElementName="FndRefDataRptId")]
    public IsoMax35Text? FundReferenceDataReportIdentification { get; init; }
    
    /// <summary>
    /// Fund reference data.
    /// </summary>
    [IsoId("_A7DpxTQaEeifw8iDiyZLmQ")]
    [Description(@"Fund reference data.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    [Required]
    public required FundReferenceDataReport1 Report { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundReferenceDataReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundReferenceDataReportV03Document ToDocument()
    {
        return new FundReferenceDataReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundReferenceDataReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundReferenceDataReportV03Document : IOuterDocument<FundReferenceDataReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.004.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundReferenceDataReportV03"/> is required.
    /// </summary>
    public required FundReferenceDataReportV03 Message { get; init; }
}
