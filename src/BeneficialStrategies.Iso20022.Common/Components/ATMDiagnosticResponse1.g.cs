﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMDiagnosticResponse1.  ISO2002 ID# _XQgAsItpEeSDLd7nI4Quzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a diagnostic from an ATM manager.
/// </summary>
public partial record ATMDiagnosticResponse1
     : IIsoXmlSerilizable<ATMDiagnosticResponse1>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    public required ATMEnvironment6 Environment { get; init; } 
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    public ATMCommand1? Command { get; init; } 
    
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
        if (Command is ATMCommand1 CommandValue)
        {
            writer.WriteStartElement(null, "Cmd", xmlNamespace );
            CommandValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMDiagnosticResponse1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
