﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification15.  ISO2002 ID# _uQMqUQgWEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
public partial record SecurityIdentification15
     : IIsoXmlSerilizable<SecurityIdentification15>
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public IsoISINIdentifier? ISIN { get; init; } 
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    public OtherIdentification2? OtherIdentification { get; init; } 
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    public IsoRestrictedFINXMax140Text? Description { get; init; } 
    
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
        if (ISIN is IsoISINIdentifier ISINValue)
        {
            writer.WriteStartElement(null, "ISIN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISINIdentifier(ISINValue)); // data type ISINIdentifier System.String
            writer.WriteEndElement();
        }
        if (OtherIdentification is OtherIdentification2 OtherIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrId", xmlNamespace );
            OtherIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Description is IsoRestrictedFINXMax140Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(DescriptionValue)); // data type RestrictedFINXMax140Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecurityIdentification15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
