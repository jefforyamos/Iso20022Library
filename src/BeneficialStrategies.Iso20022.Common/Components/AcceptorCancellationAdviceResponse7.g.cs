﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationAdviceResponse7.  ISO2002 ID# _vL5uAdtREee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation advice response from the acquirer.
/// </summary>
public partial record AcceptorCancellationAdviceResponse7
     : IIsoXmlSerilizable<AcceptorCancellationAdviceResponse7>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment69 Environment { get; init; } 
    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse6 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    
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
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TMSTrigger is TMSTrigger1 TMSTriggerValue)
        {
            writer.WriteStartElement(null, "TMSTrggr", xmlNamespace );
            TMSTriggerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorCancellationAdviceResponse7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
