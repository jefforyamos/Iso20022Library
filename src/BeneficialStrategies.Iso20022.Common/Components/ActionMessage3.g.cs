﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActionMessage3.  ISO2002 ID# _TqzxMYO6EeSWSLYdc10LRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to log.
/// </summary>
public partial record ActionMessage3
     : IIsoXmlSerilizable<ActionMessage3>
{
    #nullable enable
    
    /// <summary>
    /// Destination of the information.
    /// </summary>
    public required UserInterface3Code Destination { get; init; } 
    /// <summary>
    /// Format of the content.
    /// </summary>
    public OutputFormat1Code? Format { get; init; } 
    /// <summary>
    /// Content of the information.
    /// </summary>
    public required IsoMax20000Text Content { get; init; } 
    
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
        writer.WriteStartElement(null, "Dstn", xmlNamespace );
        writer.WriteValue(Destination.ToString()); // Enum value
        writer.WriteEndElement();
        if (Format is OutputFormat1Code FormatValue)
        {
            writer.WriteStartElement(null, "Frmt", xmlNamespace );
            writer.WriteValue(FormatValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Cntt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax20000Text(Content)); // data type Max20000Text System.String
        writer.WriteEndElement();
    }
    public static ActionMessage3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
