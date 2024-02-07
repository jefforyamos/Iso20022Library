﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionBulkExecution3.  ISO2002 ID# _R2Dgudp-Ed-ak6NoX_4Aeg_-675591954.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
public partial record RedemptionBulkExecution3
     : IIsoXmlSerilizable<RedemptionBulkExecution3>
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
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public CancellationRight1Code? CancellationRight { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public IsoExtended350Code? ExtendedCancellationRight { get; init; } 
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    public RedemptionExecution5? IndividualExecutionDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _R2Mqptp-Ed-ak6NoX_4Aeg_-675591477
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
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction22? BulkCashSettlementDetails { get; init; } 
    
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
        if (RequestedFutureTradeDate is IsoISODate RequestedFutureTradeDateValue)
        {
            writer.WriteStartElement(null, "ReqdFutrTradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedFutureTradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (CancellationRight is CancellationRight1Code CancellationRightValue)
        {
            writer.WriteStartElement(null, "CxlRght", xmlNamespace );
            writer.WriteValue(CancellationRightValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExtendedCancellationRight is IsoExtended350Code ExtendedCancellationRightValue)
        {
            writer.WriteStartElement(null, "XtndedCxlRght", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedCancellationRightValue)); // data type Extended350Code System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize IndividualExecutionDetails, multiplicity Unknown
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
        if (CashSettlementDate is IsoISODate CashSettlementDateValue)
        {
            writer.WriteStartElement(null, "CshSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CashSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (BulkCashSettlementDetails is PaymentTransaction22 BulkCashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "BlkCshSttlmDtls", xmlNamespace );
            BulkCashSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RedemptionBulkExecution3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
