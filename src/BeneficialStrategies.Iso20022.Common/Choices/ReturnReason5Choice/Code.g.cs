﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TP6Pktp-Ed-ak6NoX_4Aeg_-1676326035.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;

/// <summary>
/// Reason for the return, as published in an external reason code list.
/// </summary>
public partial record Code : ReturnReason5Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the return reason, as published in an external return reason code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    public required ExternalReturnReason1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
