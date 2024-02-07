﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuthorisationRequest.  ISO2002 ID# _KV7CRS5BEeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice;

/// <summary>
/// Card payment transaction including an authorisation request.
/// </summary>
public partial record AuthorisationRequest : CardPaymentDataSetTransaction9Choice_
     , IIsoXmlSerilizable<AuthorisationRequest>
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability8? Traceability { get; init; } 
    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    public required CardPaymentEnvironment77 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext28? Context { get; init; } 
    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    public required CardPaymentTransaction107 Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "TxSeqCntr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax9NumericText(TransactionSequenceCounter)); // data type Max9NumericText System.String
        writer.WriteEndElement();
        if (Traceability is Traceability8 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Context is CardPaymentContext28 ContextValue)
        {
            writer.WriteStartElement(null, "Cntxt", xmlNamespace );
            ContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new AuthorisationRequest Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
