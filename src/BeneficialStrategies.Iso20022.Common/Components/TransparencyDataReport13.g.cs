﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransparencyDataReport13.  ISO2002 ID# _pRLggWlAEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting quantitative details of equity instruments as part of transparency calculations.
/// </summary>
public partial record TransparencyDataReport13
     : IIsoXmlSerilizable<TransparencyDataReport13>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    public required IsoISINOct2015Identifier Identification { get; init; } 
    /// <summary>
    /// Date to which the quantitative data fields below relate.
    /// </summary>
    public IsoISODate? ReportingDate { get; init; } 
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Indicates whether the instrument was suspended for trading on that Trading Venue for the whole day on the given reporting day.
    /// </summary>
    public required IsoTrueFalseIndicator Suspension { get; init; } 
    /// <summary>
    /// Total number of transactions executed on the reporting day.
    /// </summary>
    public required NumberAndVolume2 TransactionsExecuted { get; init; } 
    /// <summary>
    /// Details all transactions that have been performed under a pre-trade Waiver.
    /// </summary>
    public required NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; init; } 
    /// <summary>
    /// Details all transactions that have been performed under a post-trade large in scale waivers.
    /// </summary>
    public required NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; init; } 
    
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
        if (TechnicalRecordIdentification is IsoMax35Text TechnicalRecordIdentificationValue)
        {
            writer.WriteStartElement(null, "TechRcrdId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TechnicalRecordIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(Identification)); // data type ISINOct2015Identifier System.String
        writer.WriteEndElement();
        if (ReportingDate is IsoISODate ReportingDateValue)
        {
            writer.WriteStartElement(null, "RptgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ReportingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TradingVenue is IsoMICIdentifier TradingVenueValue)
        {
            writer.WriteStartElement(null, "TradgVn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(TradingVenueValue)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sspnsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(Suspension)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxsExctd", xmlNamespace );
        TransactionsExecuted.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxsExctdExclgPreTradWvr", xmlNamespace );
        TransactionsExecutedExcludingPreTradeWaiver.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxsExctdExclgPstTradLrgInScaleWvr", xmlNamespace );
        TransactionsExecutedExcludingPostTradeLargeInScaleWaiver.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TransparencyDataReport13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
