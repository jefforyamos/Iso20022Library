﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeContract3.  ISO2002 ID# _6R7xwbGIEeuSTr8k0UEM8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
/// </summary>
public partial record TradeContract3
     : IIsoXmlSerilizable<TradeContract3>
{
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    /// <summary>
    /// Type code of the trade contract.
    /// </summary>
    public IsoMax35Text? TradeTypeIdentification { get; init; } 
    /// <summary>
    /// Amount of the trade contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    public TradeParty5? Buyer { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _6SzUdbGIEeuSTr8k0UEM8A
    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    public TradeParty5? Seller { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _6SzUd7GIEeuSTr8k0UEM8A
    /// <summary>
    /// Planned final payment date at the time of issuance.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// When absent, the flag meaning is NotApplicable.
    /// </summary>
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; } 
    /// <summary>
    /// Start date of the trade contract.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Currency in which the trade is being settled.
    /// </summary>
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    /// <summary>
    /// Schedule of the payments defined for the trade contract.
    /// </summary>
    public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
    /// <summary>
    /// Schedule of the shipment.
    /// </summary>
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the trade contract.
    /// </summary>
    public DocumentGeneralInformation5? Attachment { get; init; } 
    
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
        if (ContractDocumentIdentification is DocumentIdentification22 ContractDocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "CtrctDocId", xmlNamespace );
            ContractDocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeTypeIdentification is IsoMax35Text TradeTypeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradTpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TradeTypeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Amount is IsoActiveCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        // Not sure how to serialize Buyer, multiplicity Unknown
        // Not sure how to serialize Seller, multiplicity Unknown
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ProlongationFlag is IsoTrueFalseIndicator ProlongationFlagValue)
        {
            writer.WriteStartElement(null, "PrlngtnFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ProlongationFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (StartDate is IsoISODate StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SettlementCurrency is ActiveCurrencyCode SettlementCurrencyValue)
        {
            writer.WriteStartElement(null, "SttlmCcy", xmlNamespace );
            writer.WriteValue(SettlementCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExchangeRateInformation is ExchangeRate1 ExchangeRateInformationValue)
        {
            writer.WriteStartElement(null, "XchgRateInf", xmlNamespace );
            ExchangeRateInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentSchedule is InterestPaymentDateRange1 PaymentScheduleValue)
        {
            writer.WriteStartElement(null, "PmtSchdl", xmlNamespace );
            PaymentScheduleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ShipmentSchedule is ShipmentSchedule2Choice_ ShipmentScheduleValue)
        {
            writer.WriteStartElement(null, "ShipmntSchdl", xmlNamespace );
            ShipmentScheduleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Attachment is DocumentGeneralInformation5 AttachmentValue)
        {
            writer.WriteStartElement(null, "Attchmnt", xmlNamespace );
            AttachmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TradeContract3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
