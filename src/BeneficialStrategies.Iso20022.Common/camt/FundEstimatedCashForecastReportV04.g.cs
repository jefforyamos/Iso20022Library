﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundEstimatedCashForecastReportV04.  ISO2002 ID# _DQeV4QasEeSrXeb3pHPmbg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// A report provider, such as a transfer agent, sends the FundEstimatedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the estimated cash incomings and outgoings of one or more share classes of an investment fund on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundEstimatedCashForecastReport is used to report estimated cash movements, that is, it is sent prior to the cut-off time and/or the price valuation of the fund.
/// The message contains incoming and outgoing cash flows that are estimated, that is, the price has not been applied. If the price is definitive, then the FundConfirmedCashForecastReport message must be used.
/// The message structure allows for the following uses:
/// -	to provide cash in and cash out amounts for a fund/sub fund (FundOrSubFundDetails sequence is used),
/// -	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or more EstimatedFundCashForecastDetails sequences are used),
/// -	to provide cash in and cash out amounts for one or more share classes (one or more EstimatedFundCashForecastDetails sequences are used).
/// -	to provide cash in and cash out amounts for more than one fund/sub fund, and more than one share classes (two or more FundOrSubFundDetails sequences and two or more EstimatedFundCashForecastDetails sequences and used); however, it should be noted that, in this usage, there is no way to determine which share class belongs to which fund/sub fund from the message content itself, which may not be desirable and the use of this kind of combination should be bilaterally agreed.
/// This message allows the report provider to report estimated cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges. If the report provider wishes to give detailed information related to estimated cash movements, then the FundDetailedEstimatedCashForecastReport message must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundEstimatedCashForecastReport message to the report user, such as an investment manager or pricing agent, to report the estimated cash incomings and outgoings of one or more share classes of an investment fund on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundEstimatedCashForecastReport is used to report estimated cash movements, that is, it is sent prior to the cut-off time and/or the price valuation of the fund.|The message contains incoming and outgoing cash flows that are estimated, that is, the price has not been applied. If the price is definitive, then the FundConfirmedCashForecastReport message must be used.|The message structure allows for the following uses:|-	to provide cash in and cash out amounts for a fund/sub fund (FundOrSubFundDetails sequence is used),|-	to provide cash in and cash out amounts for a fund/sub fund and one or more share classes (a FundOrSubFundDetails sequence and one or more EstimatedFundCashForecastDetails sequences are used),|-	to provide cash in and cash out amounts for one or more share classes (one or more EstimatedFundCashForecastDetails sequences are used).|-	to provide cash in and cash out amounts for more than one fund/sub fund, and more than one share classes (two or more FundOrSubFundDetails sequences and two or more EstimatedFundCashForecastDetails sequences and used); however, it should be noted that, in this usage, there is no way to determine which share class belongs to which fund/sub fund from the message content itself, which may not be desirable and the use of this kind of combination should be bilaterally agreed.|This message allows the report provider to report estimated cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges. If the report provider wishes to give detailed information related to estimated cash movements, then the FundDetailedEstimatedCashForecastReport message must be used.")]
public partial record FundEstimatedCashForecastReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndEstmtdCshFcstRpt";
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_DQeV5QasEeSrXeb3pHPmbg")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_DQeV5wasEeSrXeb3pHPmbg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_DQeV6QasEeSrXeb3pHPmbg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_DQeV6wasEeSrXeb3pHPmbg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DQeV7QasEeSrXeb3pHPmbg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.
    /// </summary>
    [IsoId("_TYM-QQc3EeSyIPzOZ6VzBQ")]
    [Description(@"Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.")]
    [DataMember(Name="FndOrSubFndDtls")]
    [XmlElement(ElementName="FndOrSubFndDtls")]
    public Fund1? FundOrSubFundDetails { get; init; }
    
    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of transactions in shares in an investment fund, for example, subscriptions, redemptions or switches.
    /// </summary>
    [IsoId("_DQeV7wasEeSrXeb3pHPmbg")]
    [Description(@"Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of transactions in shares in an investment fund, for example, subscriptions, redemptions or switches.")]
    [DataMember(Name="EstmtdFndCshFcstDtls")]
    [XmlElement(ElementName="EstmtdFndCshFcstDtls")]
    public EstimatedFundCashForecast6? EstimatedFundCashForecastDetails { get; init; }
    
    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_DQeV8QasEeSrXeb3pHPmbg")]
    [Description(@"Estimated net cash as a result of the cash-in and cash-out flows.")]
    [DataMember(Name="CnsltdNetCshFcst")]
    [XmlElement(ElementName="CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_DQeV8wasEeSrXeb3pHPmbg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundEstimatedCashForecastReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundEstimatedCashForecastReportV04Document ToDocument()
    {
        return new FundEstimatedCashForecastReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundEstimatedCashForecastReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundEstimatedCashForecastReportV04Document : IOuterDocument<FundEstimatedCashForecastReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundEstimatedCashForecastReportV04"/> is required.
    /// </summary>
    public required FundEstimatedCashForecastReportV04 Message { get; init; }
}
