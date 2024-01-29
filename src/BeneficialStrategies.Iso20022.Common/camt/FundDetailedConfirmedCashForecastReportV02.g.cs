﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundDetailedConfirmedCashForecastReportV02.  ISO2002 ID# _b0VixdE-Ed-BzquC8wXy7w_1495578419.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The FundDetailedConfirmedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to report confirmed cash incomings and outgoings, sorted by country, institution or some other criteria defined by the user. This message can be used to report the confirmed cash movements of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.
/// Usage
/// The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FundDetailedConfirmedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.|This message is used to report confirmed cash incomings and outgoings, sorted by country, institution or some other criteria defined by the user. This message can be used to report the confirmed cash movements of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.|Usage|The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund.")]
public partial record FundDetailedConfirmedCashForecastReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.043.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_b0VixtE-Ed-BzquC8wXy7w_-1352828548")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_b0Vix9E-Ed-BzquC8wXy7w_-1583705960")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_b0ViyNE-Ed-BzquC8wXy7w_-1570778354")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_b0ViydE-Ed-BzquC8wXy7w_1567017889")]
    [Description(@"Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.")]
    [DataMember(Name="FndCshFcstDtls")]
    [XmlElement(ElementName="FndCshFcstDtls")]
    [Required]
    public required SomeFundCashForecastDetailsRecord FundCashForecastDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_b0ViytE-Ed-BzquC8wXy7w_-439464245")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundDetailedConfirmedCashForecastReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundDetailedConfirmedCashForecastReportV02Document ToDocument()
    {
        return new FundDetailedConfirmedCashForecastReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundDetailedConfirmedCashForecastReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundDetailedConfirmedCashForecastReportV02Document : IOuterDocument<FundDetailedConfirmedCashForecastReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.043.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundDetailedConfirmedCashForecastReportV02"/> is required.
    /// </summary>
    public required FundDetailedConfirmedCashForecastReportV02 Message { get; init; }
}