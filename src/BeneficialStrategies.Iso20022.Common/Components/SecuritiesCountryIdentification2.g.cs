﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCountryIdentification2.  ISO2002 ID# _lv3_EYAMEeaYeOsLN4966A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details an individual country including its name and country code.
/// </summary>
public partial record SecuritiesCountryIdentification2
     : IIsoXmlSerilizable<SecuritiesCountryIdentification2>
{
    #nullable enable
    
    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    public required CountryCodeAndName3 Country { get; init; } 
    /// <summary>
    /// Flag which reflects if the country is a member of the EEA (European Economic Area) or not.
    /// </summary>
    public required IsoTrueFalseIndicator EEACountry { get; init; } 
    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    public Modification1Code? Modification { get; init; } 
    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    public required Period4Choice_ ValidityPeriod { get; init; } 
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    public IsoISODate? LastUpdated { get; init; } 
    
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
        writer.WriteStartElement(null, "Ctry", xmlNamespace );
        Country.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EEACtry", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(EEACountry)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (Modification is Modification1Code ModificationValue)
        {
            writer.WriteStartElement(null, "Mod", xmlNamespace );
            writer.WriteValue(ModificationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "VldtyPrd", xmlNamespace );
        ValidityPeriod.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LastUpdated is IsoISODate LastUpdatedValue)
        {
            writer.WriteStartElement(null, "LastUpdtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(LastUpdatedValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static SecuritiesCountryIdentification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
