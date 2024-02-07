﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransaction9.  ISO2002 ID# _1xK7IXu6EeSLmfFG0DG7zQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction for which the authorisation has been requested.
/// </summary>
public partial record CardTransaction9
     : IIsoXmlSerilizable<CardTransaction9>
{
    #nullable enable
    
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    public CardServiceType1Code? ReconciliationType { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    public TransactionIdentifier2? Reconciliation { get; init; } 
    /// <summary>
    /// Date when the settlement is expected.
    /// </summary>
    public IsoISODate? InterBankSettlementDate { get; init; } 
    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    public required IsoISODateTime InitiatorTransactionDateTime { get; init; } 
    /// <summary>
    /// Number generated by the transaction Initiator to assist in identifying a transaction uniquely. This value remains unchanged for all messages within a message pair exchange, for instance an initiation/response. It corresponds to the ISO 8583 field number 11.
    /// </summary>
    public required IsoMax35Text InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification to match transactions throughout their life cycle (for example, authorisation to financial presentment, financial presentment to chargeback). It shall contain the same value in all messages throughout a transaction’s life cycle. It corresponds partially to ISO 8583: 2003 field number 21.
    /// </summary>
    public IsoMax35Text? TransactionLifeCycleIdentification { get; init; } 
    /// <summary>
    /// Totals of the reconciliation.
    /// </summary>
    public TransactionTotals4? ReconciliationTotals { get; init; } 
    /// <summary>
    /// Net value of all gross amounts.
    /// </summary>
    public AmountAndDirection41? AmountNetReconciliation { get; init; } 
    /// <summary>
    /// Response to the reconciliation.
    /// </summary>
    public ResponseType2? TransactionResponse { get; init; } 
    
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
        if (ReconciliationType is CardServiceType1Code ReconciliationTypeValue)
        {
            writer.WriteStartElement(null, "RcncltnTp", xmlNamespace );
            writer.WriteValue(ReconciliationTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Reconciliation is TransactionIdentifier2 ReconciliationValue)
        {
            writer.WriteStartElement(null, "Rcncltn", xmlNamespace );
            ReconciliationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterBankSettlementDate is IsoISODate InterBankSettlementDateValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InterBankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InitrTxDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(InitiatorTransactionDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitrTxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(InitiatorTransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (TransactionLifeCycleIdentification is IsoMax35Text TransactionLifeCycleIdentificationValue)
        {
            writer.WriteStartElement(null, "TxLifeCyclId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionLifeCycleIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReconciliationTotals is TransactionTotals4 ReconciliationTotalsValue)
        {
            writer.WriteStartElement(null, "RcncltnTtls", xmlNamespace );
            ReconciliationTotalsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AmountNetReconciliation is AmountAndDirection41 AmountNetReconciliationValue)
        {
            writer.WriteStartElement(null, "AmtNetRcncltn", xmlNamespace );
            AmountNetReconciliationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionResponse is ResponseType2 TransactionResponseValue)
        {
            writer.WriteStartElement(null, "TxRspn", xmlNamespace );
            TransactionResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardTransaction9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
