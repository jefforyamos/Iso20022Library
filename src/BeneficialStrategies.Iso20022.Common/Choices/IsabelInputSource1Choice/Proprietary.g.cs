﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _SG0RY8mMEeWAGphE2LvqeA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IsabelInputSource1Choice;

/// <summary>
/// Input source for the generation of the file, in a proprietary form.
/// </summary>
public partial record Proprietary : IsabelInputSource1Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies an alphanumeric string with a maximum length of 4 characters.
    /// </summary>
    public required IsoMax4AlphaNumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Prtry", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Value)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
