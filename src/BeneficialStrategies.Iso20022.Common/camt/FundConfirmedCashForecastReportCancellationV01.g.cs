﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundConfirmedCashForecastReportCancellationV01.  ISO2002 ID# _Y7HS6NE-Ed-BzquC8wXy7w_1651868953.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The FundConfirmedCashForecastReportCancellation message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to cancel a previously sent FundConfirmedCashForecastReport message.
/// Usage
/// The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FundConfirmedCashForecastReportCancellation message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.|This message is used to cancel a previously sent FundConfirmedCashForecastReport message.|Usage|The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record FundConfirmedCashForecastReportCancellationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.044.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundConfirmedCashForecastReportCancellationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundConfirmedCashForecastReportCancellationV01Document ToDocument()
    {
        return new FundConfirmedCashForecastReportCancellationV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The FundConfirmedCashForecastReportCancellation message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to cancel a previously sent FundConfirmedCashForecastReport message.
/// Usage
/// The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// This is the outer document that contains <seealso cref="FundConfirmedCashForecastReportCancellationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FundConfirmedCashForecastReportCancellationV01Document : IOuterDocument<FundConfirmedCashForecastReportCancellationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.044.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundConfirmedCashForecastReportCancellationV01"/> is required.
    /// </summary>
    public required FundConfirmedCashForecastReportCancellationV01 Message { get; init; }
}
