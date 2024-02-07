﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LegalPersonIdentification1.  ISO2002 ID# _bF0vcT3YEe2uHKhHp3bXyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the organisation which is a legal person.
/// </summary>
public partial record LegalPersonIdentification1
     : IIsoXmlSerilizable<LegalPersonIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the legal person.
    /// </summary>
    public required OrganisationIdentification15Choice_ Identification { get; init; } 
    /// <summary>
    /// Code of country where the registered office of the organisation is located.
    /// </summary>
    public CountryCode? Country { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Country is CountryCode CountryValue)
        {
            writer.WriteStartElement(null, "Ctry", xmlNamespace );
            writer.WriteValue(CountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static LegalPersonIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
