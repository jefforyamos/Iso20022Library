﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCommand3.  ISO2002 ID# _LQmKgYr4EeSvuOJS0mmL0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command which has requested the device report.
/// </summary>
public partial record ATMCommand3
     : IIsoXmlSerilizable<ATMCommand3>
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    public required ATMCommand2Code Type { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (CommandIdentification is ATMCommandIdentification1 CommandIdentificationValue)
        {
            writer.WriteStartElement(null, "CmdId", xmlNamespace );
            CommandIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMCommand3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
