﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet21.  ISO2002 ID# _mZP3gdtPEee9e6xduATmQg.
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
public partial record CardPaymentDataSet21
     : IIsoXmlSerilizable<CardPaymentDataSet21>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    public required ResponseType5 DataSetResult { get; init; } 
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    public GenericIdentification53? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    public TransactionTotals7? TransactionTotals { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _mimAydtPEee9e6xduATmQg
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    public CardPaymentDataSet20? RejectedTransaction { get; init; } 
    
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
        if (DataSetInitiator is GenericIdentification53 DataSetInitiatorValue)
        {
            writer.WriteStartElement(null, "DataSetInitr", xmlNamespace );
            DataSetInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize TransactionTotals, multiplicity Unknown
        if (RejectedTransaction is CardPaymentDataSet20 RejectedTransactionValue)
        {
            writer.WriteStartElement(null, "RjctdTx", xmlNamespace );
            RejectedTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentDataSet21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
