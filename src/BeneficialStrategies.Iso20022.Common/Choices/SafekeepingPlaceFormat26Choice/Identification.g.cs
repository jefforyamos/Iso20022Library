﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _Vyh5AZqLEeWcAIE4lEkF_Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat26Choice;

/// <summary>
/// Place of safekeeping expressed as a code and a narrative description.
/// </summary>
public partial record Identification : SafekeepingPlaceFormat26Choice_
     , IIsoXmlSerilizable<Identification>
{
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    public IsoRestrictedFINXMax30Text? Value { get; init; } 
    
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
        writer.WriteStartElement(null, "SfkpgPlcTp", xmlNamespace );
        writer.WriteValue(SafekeepingPlaceType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Value is IsoRestrictedFINXMax30Text ValueValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax30Text(ValueValue)); // data type RestrictedFINXMax30Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Identification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
