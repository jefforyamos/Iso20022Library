﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryParty5.  ISO2002 ID# __hD_J248EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a proprietary party.
/// </summary>
public partial record ProprietaryParty5
     : IIsoXmlSerilizable<ProprietaryParty5>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary party.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Proprietary party.
    /// </summary>
    public required Party40Choice_ Party { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Type)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ProprietaryParty5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
