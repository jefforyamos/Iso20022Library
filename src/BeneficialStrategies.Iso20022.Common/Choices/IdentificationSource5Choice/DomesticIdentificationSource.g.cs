﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DomesticIdentificationSource.  ISO2002 ID# _n7S8IV9NEeS7xuKaq75oiQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource5Choice;

/// <summary>
/// Country of the proprietary identification scheme.
/// </summary>
public partial record DomesticIdentificationSource : IdentificationSource5Choice_
     , IIsoXmlSerilizable<DomesticIdentificationSource>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
    /// </summary>
    public required CountryCode Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DmstIdSrc", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new DomesticIdentificationSource Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
