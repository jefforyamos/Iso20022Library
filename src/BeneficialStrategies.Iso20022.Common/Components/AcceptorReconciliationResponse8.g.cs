﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationResponse8.  ISO2002 ID# _2W61YU7TEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
public partial record AcceptorReconciliationResponse8
     : IIsoXmlSerilizable<AcceptorReconciliationResponse8>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    public required ResponseType10 TransactionResponse { get; init; } 
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    public required TransactionReconciliation5 Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxRspn", xmlNamespace );
        TransactionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AcceptorReconciliationResponse8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
