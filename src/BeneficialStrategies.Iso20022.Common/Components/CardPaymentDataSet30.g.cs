﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet30.  ISO2002 ID# _6jN60VIBEey4xOoMoOPSJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction for whose batch capture has been rejected.
/// </summary>
public partial record CardPaymentDataSet30
     : IIsoXmlSerilizable<CardPaymentDataSet30>
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    public required ResponseType10 TransactionResponse { get; init; } 
    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "TxSeqCntr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax9NumericText(TransactionSequenceCounter)); // data type Max9NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxRspn", xmlNamespace );
        TransactionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CardPaymentDataSet30 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
