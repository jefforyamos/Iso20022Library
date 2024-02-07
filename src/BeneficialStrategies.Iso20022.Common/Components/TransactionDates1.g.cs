﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDates1.  ISO2002 ID# _RUrR99p-Ed-ak6NoX_4Aeg_1881477218.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements identifying the dates related to the underlying transactions.
/// </summary>
public partial record TransactionDates1
     : IIsoXmlSerilizable<TransactionDates1>
{
    #nullable enable
    
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor's agent in case of a credit transfer, creditor's agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
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
    public ProprietaryDate1? Proprietary { get; init; } 
    
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
        if (Proprietary is ProprietaryDate1 ProprietaryValue)
        {
            writer.WriteStartElement(null, "Prtry", xmlNamespace );
            ProprietaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionDates1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
