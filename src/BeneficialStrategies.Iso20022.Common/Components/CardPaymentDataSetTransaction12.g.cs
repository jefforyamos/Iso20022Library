﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction12.  ISO2002 ID# _xsescWmMEeS7iYydEtv3Ug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction to be authorised in a batch.
/// </summary>
public partial record CardPaymentDataSetTransaction12
     : IIsoXmlSerilizable<CardPaymentDataSetTransaction12>
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability2? Traceability { get; init; } 
    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    public required CardPaymentEnvironment32 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext12? Context { get; init; } 
    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    public required CardPaymentTransaction47 Transaction { get; init; } 
    
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
        if (Traceability is Traceability2 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Context is CardPaymentContext12 ContextValue)
        {
            writer.WriteStartElement(null, "Cntxt", xmlNamespace );
            ContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CardPaymentDataSetTransaction12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
