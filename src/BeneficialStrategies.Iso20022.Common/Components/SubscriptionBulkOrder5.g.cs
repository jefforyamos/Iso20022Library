﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionBulkOrder5.  ISO2002 ID# _vT7MmTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor's principal in an investment fund.
/// </summary>
public partial record SubscriptionBulkOrder5
     : IIsoXmlSerilizable<SubscriptionBulkOrder5>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Order to invest the investor's principal in an investment fund.
    /// </summary>
    public SubscriptionOrder15? IndividualOrderDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _vsxKfTbsEead9bDRE_1DAQ
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction70? BulkCashSettlementDetails { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is PlaceOfTradeIdentification1Choice_ PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OrderDateTime is IsoISODateTime OrderDateTimeValue)
        {
            writer.WriteStartElement(null, "OrdrDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(OrderDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ExpiryDateTime is DateAndDateTimeChoice_ ExpiryDateTimeValue)
        {
            writer.WriteStartElement(null, "XpryDtTm", xmlNamespace );
            ExpiryDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedFutureTradeDate is IsoISODate RequestedFutureTradeDateValue)
        {
            writer.WriteStartElement(null, "ReqdFutrTradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedFutureTradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (CancellationRight is CancellationRight1Choice_ CancellationRightValue)
        {
            writer.WriteStartElement(null, "CxlRght", xmlNamespace );
            CancellationRightValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize IndividualOrderDetails, multiplicity Unknown
        if (RequestedSettlementCurrency is ActiveCurrencyCode RequestedSettlementCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmCcy", xmlNamespace );
            writer.WriteValue(RequestedSettlementCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedNAVCurrency is ActiveOrHistoricCurrencyCode RequestedNAVCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdNAVCcy", xmlNamespace );
            writer.WriteValue(RequestedNAVCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TotalSettlementAmount is IsoActiveCurrencyAndAmount TotalSettlementAmountValue)
        {
            writer.WriteStartElement(null, "TtlSttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalSettlementAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (BulkCashSettlementDetails is PaymentTransaction70 BulkCashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "BlkCshSttlmDtls", xmlNamespace );
            BulkCashSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubscriptionBulkOrder5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
