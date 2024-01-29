﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundDetailedEstimatedCashForecastReportV03.  ISO2002 ID# _dYVFEtE-Ed-BzquC8wXy7w_890369762.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedEstimatedCashForecastReport message to the report user, such as an investment manager, to report the estimated cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundDetailedEstimatedCashForecastReport is used to provide estimated cash movements, i.e., it is sent prior to the cut-off time and/or the price valuation of the fund. If the price is definitive, then the FundDetailedConfirmedCashForecastReport message must be used.
/// The FundDetailedEstimatedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to give the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.
/// In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundDetailedEstimatedCashForecastReport message to the report user, such as an investment manager, to report the estimated cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundDetailedEstimatedCashForecastReport is used to provide estimated cash movements, i.e., it is sent prior to the cut-off time and/or the price valuation of the fund. If the price is definitive, then the FundDetailedConfirmedCashForecastReport message must be used.|The FundDetailedEstimatedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to give the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.|In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges.")]
public partial record FundDetailedEstimatedCashForecastReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldEstmtdCshFcstRptV03";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_dYVFE9E-Ed-BzquC8wXy7w_1477333674")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_dYVFFNE-Ed-BzquC8wXy7w_1323500831")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_dYVFFdE-Ed-BzquC8wXy7w_1332733556")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_dYVFFtE-Ed-BzquC8wXy7w_1334582479")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_dYVFF9E-Ed-BzquC8wXy7w_256000331")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required SomeMessagePaginationRecord MessagePagination { get; init; }
    
    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_dYePANE-Ed-BzquC8wXy7w_82163480")]
    [Description(@"Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.")]
    [DataMember(Name="EstmtdFndCshFcstDtls")]
    [XmlElement(ElementName="EstmtdFndCshFcstDtls")]
    [Required]
    public required SomeEstimatedFundCashForecastDetailsRecord EstimatedFundCashForecastDetails { get; init; }
    
    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.
    /// </summary>
    [IsoId("_dYePAdE-Ed-BzquC8wXy7w_928675024")]
    [Description(@"Estimated net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.")]
    [DataMember(Name="CnsltdNetCshFcst")]
    [XmlElement(ElementName="CnsltdNetCshFcst")]
    public SomeConsolidatedNetCashForecastRecord? ConsolidatedNetCashForecast { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dYePAtE-Ed-BzquC8wXy7w_-1975912921")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundDetailedEstimatedCashForecastReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundDetailedEstimatedCashForecastReportV03Document ToDocument()
    {
        return new FundDetailedEstimatedCashForecastReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundDetailedEstimatedCashForecastReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundDetailedEstimatedCashForecastReportV03Document : IOuterDocument<FundDetailedEstimatedCashForecastReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.042.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundDetailedEstimatedCashForecastReportV03"/> is required.
    /// </summary>
    public required FundDetailedEstimatedCashForecastReportV03 Message { get; init; }
}