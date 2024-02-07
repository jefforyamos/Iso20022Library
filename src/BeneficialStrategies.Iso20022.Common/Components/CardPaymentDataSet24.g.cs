﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet24.  ISO2002 ID# _1y1K4Qx4Eeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
public partial record CardPaymentDataSet24
     : IIsoXmlSerilizable<CardPaymentDataSet24>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    public required ResponseType10 DataSetResult { get; init; } 
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    public GenericIdentification176? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    public TransactionTotals7? TransactionTotals { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _1-gPaQx4Eeqdx6buGpCCQw
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    public CardPaymentDataSet25? RejectedTransaction { get; init; } 
    /// <summary>
    /// Transaction in the batch, whose capture has been suspendeed.
    /// </summary>
    public CardPaymentDataSet25? SuspendedTransaction { get; init; } 
    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    public CardPaymentDataSet25? ResumedApproval { get; init; } 
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    public CardPaymentDataSet25? ResumedRejection { get; init; } 
    
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
        writer.WriteStartElement(null, "DataSetId", xmlNamespace );
        DataSetIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSetRslt", xmlNamespace );
        DataSetResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RmvDataSet", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(RemoveDataSet)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (DataSetInitiator is GenericIdentification176 DataSetInitiatorValue)
        {
            writer.WriteStartElement(null, "DataSetInitr", xmlNamespace );
            DataSetInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize TransactionTotals, multiplicity Unknown
        if (RejectedTransaction is CardPaymentDataSet25 RejectedTransactionValue)
        {
            writer.WriteStartElement(null, "RjctdTx", xmlNamespace );
            RejectedTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SuspendedTransaction is CardPaymentDataSet25 SuspendedTransactionValue)
        {
            writer.WriteStartElement(null, "SspdTx", xmlNamespace );
            SuspendedTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResumedApproval is CardPaymentDataSet25 ResumedApprovalValue)
        {
            writer.WriteStartElement(null, "RsmdApprvl", xmlNamespace );
            ResumedApprovalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResumedRejection is CardPaymentDataSet25 ResumedRejectionValue)
        {
            writer.WriteStartElement(null, "RsmdRjctn", xmlNamespace );
            ResumedRejectionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentDataSet24 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
