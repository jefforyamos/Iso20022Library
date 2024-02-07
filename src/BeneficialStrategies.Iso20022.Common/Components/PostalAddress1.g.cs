﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress1.  ISO2002 ID# _QG4pKNp-Ed-ak6NoX_4Aeg_-839174134.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record PostalAddress1
     : IIsoXmlSerilizable<PostalAddress1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    public AddressType2Code? AddressType { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    public SimpleValueList<IsoMax70Text> AddressLine { get; init; } = [];
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    public IsoMax70Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    public IsoMax16Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax16Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Identifies a subdivision of a country for example, state, region, county.
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
        if (AddressType is AddressType2Code AddressTypeValue)
        {
            writer.WriteStartElement(null, "AdrTp", xmlNamespace );
            writer.WriteValue(AddressTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AdrLine", xmlNamespace );
        AddressLine.Serialize(writer, xmlNamespace, "Max70Text", SerializationFormatter.IsoMax70Text );
        writer.WriteEndElement();
        if (StreetName is IsoMax70Text StreetNameValue)
        {
            writer.WriteStartElement(null, "StrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(StreetNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (BuildingNumber is IsoMax16Text BuildingNumberValue)
        {
            writer.WriteStartElement(null, "BldgNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax16Text(BuildingNumberValue)); // data type Max16Text System.String
            writer.WriteEndElement();
        }
        if (PostCode is IsoMax16Text PostCodeValue)
        {
            writer.WriteStartElement(null, "PstCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax16Text(PostCodeValue)); // data type Max16Text System.String
            writer.WriteEndElement();
        }
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
    public static PostalAddress1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
