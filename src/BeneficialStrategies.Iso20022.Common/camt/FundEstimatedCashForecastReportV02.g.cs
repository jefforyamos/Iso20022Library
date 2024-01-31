﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundEstimatedCashForecastReportV02.  ISO2002 ID# _d6JYtdE-Ed-BzquC8wXy7w_78558760.
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
/// The FundEstimatedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to report the estimated cash incomings and outgoings of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.
/// Usage
/// The FundEstimatedCashForecastReport message is used to report estimated cash movements, i.e., it is sent prior to the cutoff time and/or the price valuation of the fund.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FundEstimatedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.|This message is used to report the estimated cash incomings and outgoings of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.|Usage|The FundEstimatedCashForecastReport message is used to report estimated cash movements, i.e., it is sent prior to the cutoff time and/or the price valuation of the fund.")]
public partial record FundEstimatedCashForecastReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.040.001.02";
    
    #nullable enable
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_d6JYttE-Ed-BzquC8wXy7w_-203432164")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_d6JYt9E-Ed-BzquC8wXy7w_-602392790")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_d6JYuNE-Ed-BzquC8wXy7w_-506346429")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switch to/from a specified investment fund.
    /// </summary>
    [IsoId("_d6JYudE-Ed-BzquC8wXy7w_1685167439")]
    [Description(@"Information related to the estimated cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switch to/from a specified investment fund.")]
    [DataMember(Name="EstmtdFndCshFcstDtls")]
    [XmlElement(ElementName="EstmtdFndCshFcstDtls")]
    [Required]
    public required EstimatedFundCashForecast1 EstimatedFundCashForecastDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_d6JYutE-Ed-BzquC8wXy7w_328515513")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundEstimatedCashForecastReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundEstimatedCashForecastReportV02Document ToDocument()
    {
        return new FundEstimatedCashForecastReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundEstimatedCashForecastReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundEstimatedCashForecastReportV02Document : IOuterDocument<FundEstimatedCashForecastReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundEstimatedCashForecastReportV02"/> is required.
    /// </summary>
    public required FundEstimatedCashForecastReportV02 Message { get; init; }
}
