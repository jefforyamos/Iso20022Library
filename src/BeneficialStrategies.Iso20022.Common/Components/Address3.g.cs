﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Address3.  ISO2002 ID# _sB268cWrEeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured postal address in the local language.
/// </summary>
public partial record Address3
     : IIsoXmlSerilizable<Address3>
{
    #nullable enable
    
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public IsoMax200Text? AddressLine1 { get; init; } 
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public IsoMax200Text? AddressLine2 { get; init; } 
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    public IsoMax200Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    public IsoMax35Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax35Text? PostalCode { get; init; } 
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    public IsoMax100Text? TownName { get; init; } 
    /// <summary>
    /// Name of the country sub division minor.
    /// </summary>
    public IsoMax100Text? CountrySubDivisionMinorName { get; init; } 
    /// <summary>
    /// Name of the country sub division major.
    /// </summary>
    public IsoMax100Text? CountrySubDivisionMajorName { get; init; } 
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// In accordance with ISO 3166-1.
    /// </summary>
    public ISOMax3ACountryCode? Country { get; init; } 
    
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
        if (AddressLine1 is IsoMax200Text AddressLine1Value)
        {
            writer.WriteStartElement(null, "AdrLine1", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax200Text(AddressLine1Value)); // data type Max200Text System.String
            writer.WriteEndElement();
        }
        if (AddressLine2 is IsoMax200Text AddressLine2Value)
        {
            writer.WriteStartElement(null, "AdrLine2", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax200Text(AddressLine2Value)); // data type Max200Text System.String
            writer.WriteEndElement();
        }
        if (StreetName is IsoMax200Text StreetNameValue)
        {
            writer.WriteStartElement(null, "StrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax200Text(StreetNameValue)); // data type Max200Text System.String
            writer.WriteEndElement();
        }
        if (BuildingNumber is IsoMax35Text BuildingNumberValue)
        {
            writer.WriteStartElement(null, "BldgNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BuildingNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PostalCode is IsoMax35Text PostalCodeValue)
        {
            writer.WriteStartElement(null, "PstlCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PostalCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TownName is IsoMax100Text TownNameValue)
        {
            writer.WriteStartElement(null, "TwnNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100Text(TownNameValue)); // data type Max100Text System.String
            writer.WriteEndElement();
        }
        if (CountrySubDivisionMinorName is IsoMax100Text CountrySubDivisionMinorNameValue)
        {
            writer.WriteStartElement(null, "CtrySubDvsnMnrNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100Text(CountrySubDivisionMinorNameValue)); // data type Max100Text System.String
            writer.WriteEndElement();
        }
        if (CountrySubDivisionMajorName is IsoMax100Text CountrySubDivisionMajorNameValue)
        {
            writer.WriteStartElement(null, "CtrySubDvsnMjrNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100Text(CountrySubDivisionMajorNameValue)); // data type Max100Text System.String
            writer.WriteEndElement();
        }
        if (Country is ISOMax3ACountryCode CountryValue)
        {
            writer.WriteStartElement(null, "Ctry", xmlNamespace );
            writer.WriteValue(CountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Address3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
