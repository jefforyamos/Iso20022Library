﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDates2.  ISO2002 ID# _Rpr4p9p-Ed-ak6NoX_4Aeg_-135162253.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the dates related to the underlying individual transaction.
/// </summary>
public partial record TransactionDates2
     : IIsoXmlSerilizable<TransactionDates2>
{
    #nullable enable
    
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Identifies when an amount of money should have contractually been credited or debited the account versus when the amount of money was actually settled (debited/credited) on the cash account.
    /// </summary>
    public IsoISODate? TradeActivityContractualSettlementDate { get; init; } 
    /// <summary>
    /// Date on which the trade was executed.
    /// </summary>
    public IsoISODate? TradeDate { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Start date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// End date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    /// <summary>
    /// Date and time of the underlying transaction.
    /// </summary>
    public IsoISODateTime? TransactionDateTime { get; init; } 
    /// <summary>
    /// Proprietary date related to the underlying transaction.
    /// </summary>
    public ProprietaryDate2? Proprietary { get; init; } 
    
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
        if (AcceptanceDateTime is IsoISODateTime AcceptanceDateTimeValue)
        {
            writer.WriteStartElement(null, "AccptncDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(AcceptanceDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (TradeActivityContractualSettlementDate is IsoISODate TradeActivityContractualSettlementDateValue)
        {
            writer.WriteStartElement(null, "TradActvtyCtrctlSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TradeActivityContractualSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TradeDate is IsoISODate TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InterbankSettlementDate is IsoISODate InterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (StartDate is IsoISODate StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EndDate is IsoISODate EndDateValue)
        {
            writer.WriteStartElement(null, "EndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TransactionDateTime is IsoISODateTime TransactionDateTimeValue)
        {
            writer.WriteStartElement(null, "TxDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(TransactionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (Proprietary is ProprietaryDate2 ProprietaryValue)
        {
            writer.WriteStartElement(null, "Prtry", xmlNamespace );
            ProprietaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionDates2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
