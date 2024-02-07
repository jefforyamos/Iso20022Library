﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginLending.  ISO2002 ID# _lod1J8zsEeux2uvSBFU54Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData31Choice;

/// <summary>
/// Details of the margin lending transaction.
/// </summary>
public partial record MarginLending : TransactionLoanData31Choice_
     , IIsoXmlSerilizable<MarginLending>
{
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    public InterestRate6? MarginLoanAttribute { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (UniqueTradeIdentifier is IsoMax52Text UniqueTradeIdentifierValue)
        {
            writer.WriteStartElement(null, "UnqTradIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax52Text(UniqueTradeIdentifierValue)); // data type Max52Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EventDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (ExecutionDateTime is IsoISODateTime ExecutionDateTimeValue)
        {
            writer.WriteStartElement(null, "ExctnDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ExecutionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (TradingVenue is IsoMICIdentifier TradingVenueValue)
        {
            writer.WriteStartElement(null, "TradgVn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(TradingVenueValue)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
        if (CollateralDeliveryMethod is CollateralDeliveryMethod1Code CollateralDeliveryMethodValue)
        {
            writer.WriteStartElement(null, "CollDlvryMtd", xmlNamespace );
            writer.WriteValue(CollateralDeliveryMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OutstandingMarginLoanAmount is IsoActiveOrHistoricCurrencyAndAmount OutstandingMarginLoanAmountValue)
        {
            writer.WriteStartElement(null, "OutsdngMrgnLnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OutstandingMarginLoanAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ShortMarketValueAmount is IsoActiveOrHistoricCurrencyAndAmount ShortMarketValueAmountValue)
        {
            writer.WriteStartElement(null, "ShrtMktValAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(ShortMarketValueAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MarginLoanAttribute is InterestRate6 MarginLoanAttributeValue)
        {
            writer.WriteStartElement(null, "MrgnLnAttr", xmlNamespace );
            MarginLoanAttributeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationDate is IsoISODate TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TerminationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static new MarginLending Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
