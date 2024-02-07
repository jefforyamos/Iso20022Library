﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Vyh5GZqLEeWcAIE4lEkF_Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat26Choice;

/// <summary>
/// Place of safekeeping expressed with a propriety identification scheme.
/// </summary>
public partial record Proprietary : SafekeepingPlaceFormat26Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required GenericIdentification47 Type { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public IsoRestrictedFINXMax30Text? Identification { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Identification is IsoRestrictedFINXMax30Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax30Text(IdentificationValue)); // data type RestrictedFINXMax30Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
