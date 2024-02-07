﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionMultipleOrder3.  ISO2002 ID# _SEgMc9p-Ed-ak6NoX_4Aeg_17328032.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
public partial record RedemptionMultipleOrder3
     : IIsoXmlSerilizable<RedemptionMultipleOrder3>
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
    /// Date on which the order expires.
    /// </summary>
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public CancellationRight1Code? CancellationRight { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public IsoExtended350Code? ExtendedCancellationRight { get; init; } 
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    public IndividualPerson12? BeneficiaryDetails { get; init; } 
    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    public RedemptionOrder6? IndividualOrderDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _SEzuYdp-Ed-ak6NoX_4Aeg_19173398
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction21? BulkCashSettlementDetails { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    
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
        writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
        InvestmentAccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
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
        if (BeneficiaryDetails is IndividualPerson12 BeneficiaryDetailsValue)
        {
            writer.WriteStartElement(null, "BnfcryDtls", xmlNamespace );
            BeneficiaryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize IndividualOrderDetails, multiplicity Unknown
        if (BulkCashSettlementDetails is PaymentTransaction21 BulkCashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "BlkCshSttlmDtls", xmlNamespace );
            BulkCashSettlementDetailsValue.Serialize(writer, xmlNamespace);
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
    }
    public static RedemptionMultipleOrder3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
