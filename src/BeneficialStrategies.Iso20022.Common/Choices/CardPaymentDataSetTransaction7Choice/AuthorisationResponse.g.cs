﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuthorisationResponse.  ISO2002 ID# _438Td9eiEeiJyp_aycJaTw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction7Choice;

/// <summary>
/// Card payment transaction including an authorisation response.
/// </summary>
public partial record AuthorisationResponse : CardPaymentDataSetTransaction7Choice_
     , IIsoXmlSerilizable<AuthorisationResponse>
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability5? Traceability { get; init; } 
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    public required CardPaymentEnvironment69 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    public required CardPaymentTransaction90 Transaction { get; init; } 
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    public required CardPaymentTransaction84 TransactionResponse { get; init; } 
    
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
        if (Traceability is Traceability5 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxRspn", xmlNamespace );
        TransactionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new AuthorisationResponse Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
