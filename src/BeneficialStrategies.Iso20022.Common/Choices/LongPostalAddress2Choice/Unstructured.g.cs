﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unstructured.  ISO2002 ID# _RVRH2Np-Ed-ak6NoX_4Aeg_-1296060100.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.LongPostalAddress2Choice;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
/// </summary>
public partial record Unstructured : LongPostalAddress2Choice_
     , IIsoXmlSerilizable<Unstructured>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 350 characters.
    /// </summary>
    public required IsoMax350Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Ustrd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Value)); // data type Max350Text System.String
        writer.WriteEndElement();
    }
    public static new Unstructured Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
