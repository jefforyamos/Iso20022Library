﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionBulkExecution2.  ISO2002 ID# _VUO3wtp-Ed-ak6NoX_4Aeg_-215103151.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
public partial record SubscriptionBulkExecution2
     : IIsoXmlSerilizable<SubscriptionBulkExecution2>
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    public CountryCode? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public CancellationRight1? CancellationRight { get; init; } 
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    public SubscriptionExecution3? IndividualExecutionDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _VUO3x9p-Ed-ak6NoX_4Aeg_-215102764
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    public PaymentTransaction16? BulkCashSettlementDetails { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (PlaceOfTrade is CountryCode PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            writer.WriteValue(PlaceOfTradeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OrderDateTime is IsoISODateTime OrderDateTimeValue)
        {
            writer.WriteStartElement(null, "OrdrDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(OrderDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (CancellationRight is CancellationRight1 CancellationRightValue)
        {
            writer.WriteStartElement(null, "CxlRght", xmlNamespace );
            CancellationRightValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize IndividualExecutionDetails, multiplicity Unknown
        if (RequestedSettlementCurrency is CurrencyCode RequestedSettlementCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmCcy", xmlNamespace );
            writer.WriteValue(RequestedSettlementCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedNAVCurrency is CurrencyCode RequestedNAVCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdNAVCcy", xmlNamespace );
            writer.WriteValue(RequestedNAVCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BulkCashSettlementDetails is PaymentTransaction16 BulkCashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "BlkCshSttlmDtls", xmlNamespace );
            BulkCashSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubscriptionBulkExecution2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
