﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context13.  ISO2002 ID# _61__UahMEeuOaMA1YOy5YQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
public partial record Context13
     : IIsoXmlSerilizable<Context13>
{
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    public PointOfServiceContext4? PointOfServiceContext { get; init; } 
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public TransactionContext8? TransactionContext { get; init; } 
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    public Verification4? Verification { get; init; } 
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    public RiskContext2? RiskContext { get; init; } 
    
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
        if (PointOfServiceContext is PointOfServiceContext4 PointOfServiceContextValue)
        {
            writer.WriteStartElement(null, "PtOfSvcCntxt", xmlNamespace );
            PointOfServiceContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionContext is TransactionContext8 TransactionContextValue)
        {
            writer.WriteStartElement(null, "TxCntxt", xmlNamespace );
            TransactionContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Verification is Verification4 VerificationValue)
        {
            writer.WriteStartElement(null, "Vrfctn", xmlNamespace );
            VerificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RiskContext is RiskContext2 RiskContextValue)
        {
            writer.WriteStartElement(null, "RskCntxt", xmlNamespace );
            RiskContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Context13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
