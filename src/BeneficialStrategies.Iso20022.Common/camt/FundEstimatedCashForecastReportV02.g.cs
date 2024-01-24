﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundEstimatedCashForecastReportV02.  ISO2002 ID# _d6JYtdE-Ed-BzquC8wXy7w_78558760.
//
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
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundEstimatedCashForecastReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundEstimatedCashForecastReportV02Document ToDocument()
    {
        return new FundEstimatedCashForecastReportV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The FundEstimatedCashForecastReport message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to report the estimated cash incomings and outgoings of one or more investment funds, on one or more trade dates. These cash movements may result from, for example, redemption, subscription, switch transactions or dividends.
/// Usage
/// The FundEstimatedCashForecastReport message is used to report estimated cash movements, i.e., it is sent prior to the cutoff time and/or the price valuation of the fund.
/// This is the outer document that contains <seealso cref="FundEstimatedCashForecastReportV02"/>.
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
