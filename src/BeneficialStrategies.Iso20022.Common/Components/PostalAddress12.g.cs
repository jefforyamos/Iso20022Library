﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress12.  ISO2002 ID# _EIZxODgzEeKfZIj_SwVRwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Address of a party expressed in a formal structure.
/// </summary>
public partial record PostalAddress12
     : IIsoXmlSerilizable<PostalAddress12>
{
    #nullable enable
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.|.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Identifies a subdivision of a country eg, state, region, county.
    /// </summary>
    public IsoMax35Text? CountrySubDivision { get; init; } 
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    public required CountryCode Country { get; init; } 
    
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
        if (TownName is IsoMax35Text TownNameValue)
        {
            writer.WriteStartElement(null, "TwnNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TownNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CountrySubDivision is IsoMax35Text CountrySubDivisionValue)
        {
            writer.WriteStartElement(null, "CtrySubDvsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CountrySubDivisionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Ctry", xmlNamespace );
        writer.WriteValue(Country.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static PostalAddress12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
