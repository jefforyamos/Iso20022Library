﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _93Z_xHltEeG7BsjMvd1mEw_543627896.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CommunicationMethod1Choice;

/// <summary>
/// Communication channel method.
/// </summary>
public partial record Code : CommunicationMethod1Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    public required ExternalChannel1Code Value { get; init; } 
    
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
