﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _-mXAkyC1EeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument19Choice;

/// <summary>
/// Settlement instructions for a payment by cheque.
/// </summary>
public partial record ChequeDetails : PaymentInstrument19Choice_
     , IIsoXmlSerilizable<ChequeDetails>
{
    #nullable enable
    
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    public required NameAndAddress5 PayeeIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "PyeeId", xmlNamespace );
        PayeeIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new ChequeDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
