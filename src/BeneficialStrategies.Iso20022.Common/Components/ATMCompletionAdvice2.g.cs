﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCompletionAdvice2.  ISO2002 ID# _THx_Ya4SEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the completion of an operation on the ATM.
/// </summary>
public partial record ATMCompletionAdvice2
     : IIsoXmlSerilizable<ATMCompletionAdvice2>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required ATMEnvironment13 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    public required ATMContext13 Context { get; init; } 
    /// <summary>
    /// Transaction for which the completion is sent.
    /// </summary>
    public required ATMTransaction20 Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "Cntxt", xmlNamespace );
        Context.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ATMCompletionAdvice2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
