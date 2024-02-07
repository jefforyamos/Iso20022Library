﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5Tocc83yEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TerminationDate7Choice;

/// <summary>
/// Closing date/time or maturity date/time of the transaction expressed as an ISO 20022 code.
/// </summary>
public partial record Code : TerminationDate7Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    
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
    }
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
