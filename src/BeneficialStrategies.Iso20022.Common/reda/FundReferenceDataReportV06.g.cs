﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundReferenceDataReportV06.  ISO2002 ID# _m-g3sc0QEeuAE-cYsQdwHQ.
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
/// The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) version 3 and 3.1. Versions 3 and 3.1 will coexist until version 4 is available.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.|Usage|A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its ""home"" market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.|The FundReferenceDataReport message may be used in various models or environments:|-	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.|-	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.|-	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.|The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) version 3 and 3.1. Versions 3 and 3.1 will coexist until version 4 is available.")]
public partial record FundReferenceDataReportV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndRefDataRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundReferenceDataReportV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundReferenceDataReportV06Document ToDocument()
    {
        return new FundReferenceDataReportV06Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.
/// Usage
/// A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its "home" market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.
/// The FundReferenceDataReport message may be used in various models or environments:
/// -	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.
/// -	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.
/// -	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.
/// The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) version 3 and 3.1. Versions 3 and 3.1 will coexist until version 4 is available.
/// This is the outer document that contains <seealso cref="FundReferenceDataReportV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundReferenceDataReportV06Document : IOuterDocument<FundReferenceDataReportV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.004.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundReferenceDataReportV06"/> is required.
    /// </summary>
    public required FundReferenceDataReportV06 Message { get; init; }
}
