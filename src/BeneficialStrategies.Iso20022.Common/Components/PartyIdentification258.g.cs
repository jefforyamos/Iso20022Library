﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification258.  ISO2002 ID# _jl3uccWdEeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification258
     : IIsoXmlSerilizable<PartyIdentification258>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    public IsoMax35Text? Assigner { get; init; } 
    /// <summary>
    /// Country of the party.
    /// </summary>
    public ISO3NumericCountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the party.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    public IsoMax99Text? LegalCorporateName { get; init; } 
    /// <summary>
    /// Additional identification of the party.
    /// </summary>
    public AdditionalData1? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    public LocalData1? LocalData { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Assigner is IsoMax35Text AssignerValue)
        {
            writer.WriteStartElement(null, "Assgnr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AssignerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Country is ISO3NumericCountryCode CountryValue)
        {
            writer.WriteStartElement(null, "Ctry", xmlNamespace );
            writer.WriteValue(CountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (LegalCorporateName is IsoMax99Text LegalCorporateNameValue)
        {
            writer.WriteStartElement(null, "LglCorpNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax99Text(LegalCorporateNameValue)); // data type Max99Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalIdentification is AdditionalData1 AdditionalIdentificationValue)
        {
            writer.WriteStartElement(null, "AddtlId", xmlNamespace );
            AdditionalIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalData is LocalData1 LocalDataValue)
        {
            writer.WriteStartElement(null, "LclData", xmlNamespace );
            LocalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification258 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
