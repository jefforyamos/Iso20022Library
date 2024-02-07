﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics29.  ISO2002 ID# _x_mYtVyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
public partial record DetailedTransactionStatistics29
     : IIsoXmlSerilizable<DetailedTransactionStatistics29>
{
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    public required StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; } 
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    public required StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; } 
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
    /// </summary>
    public StatisticsPerActionType1? TotalCorrectedRejections { get; init; } 
    /// <summary>
    /// Details on transactions rejected per error code.
    /// </summary>
    public RejectionReason71? TransactionsRejectionsReason { get; init; } 
    
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
        writer.WriteStartElement(null, "TtlNbOfTxs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(TotalNumberOfTransactions)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlNbOfTxsAccptd", xmlNamespace );
        TotalNumberOfTransactionsAccepted.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlNbOfTxsRjctd", xmlNamespace );
        TotalNumberOfTransactionsRejected.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalCorrectedRejections is StatisticsPerActionType1 TotalCorrectedRejectionsValue)
        {
            writer.WriteStartElement(null, "TtlCrrctdRjctns", xmlNamespace );
            TotalCorrectedRejectionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionsRejectionsReason is RejectionReason71 TransactionsRejectionsReasonValue)
        {
            writer.WriteStartElement(null, "TxsRjctnsRsn", xmlNamespace );
            TransactionsRejectionsReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DetailedTransactionStatistics29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
