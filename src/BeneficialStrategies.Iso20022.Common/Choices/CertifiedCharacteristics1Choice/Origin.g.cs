﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Origin.  ISO2002 ID# _TnJq6dp-Ed-ak6NoX_4Aeg_568642879.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice;

/// <summary>
/// Country of origin of the goods, as proven by the certificate.
/// </summary>
public partial record Origin : CertifiedCharacteristics1Choice_
     , IIsoXmlSerilizable<Origin>
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
        writer.WriteStartElement(null, "Orgn", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Origin Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
