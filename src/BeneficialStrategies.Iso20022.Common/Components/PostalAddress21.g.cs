﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PostalAddress21.  ISO2002 ID# _E4FW4SFyEeW9XJWqfgXIIA.
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
public partial record PostalAddress21
     : IIsoXmlSerilizable<PostalAddress21>
{
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    public AddressType2Choice_? AddressType { get; init; } 
    /// <summary>
    /// Indicates whether mail should be sent to the address.
    /// </summary>
    public IsoYesNoIndicator? MailingIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    public IsoYesNoIndicator? RegistrationAddressIndicator { get; init; } 
    /// <summary>
    /// When the individual resides at another person’s address, the name of the other person.
    /// </summary>
    public IsoMax70Text? CareOf { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    public SimpleValueList<IsoMax70Text> AddressLine { get; init; } = [];
    /// <summary>
    /// Name of the street or thoroughfare.
    /// </summary>
    public IsoMax70Text? StreetName { get; init; } 
    /// <summary>
    /// Number that identifies the position of the building on a street.
    /// </summary>
    public IsoMax16Text? BuildingNumber { get; init; } 
    /// <summary>
    /// Name of the building or house.
    /// </summary>
    public IsoMax35Text? BuildingName { get; init; } 
    /// <summary>
    /// Post box number of the addressee within the residential or company building.
    /// </summary>
    public IsoMax10Text? PostBox { get; init; } 
    /// <summary>
    /// Side or wing of the building, for example, ‘wing A’.
    /// </summary>
    public IsoMax35Text? SideInBuilding { get; init; } 
    /// <summary>
    /// Floor or storey within the building.
    /// </summary>
    public IsoMax70Text? Floor { get; init; } 
    /// <summary>
    /// Identification of the suite or apartment.
    /// </summary>
    public IsoMax10Text? SuiteIdentification { get; init; } 
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    public IsoMax16Text? PostCode { get; init; } 
    /// <summary>
    /// Name of a district, that is, a part of the town or region.
    /// </summary>
    public IsoMax35Text? DistrictName { get; init; } 
    /// <summary>
    /// Name of the village.
    /// </summary>
    public IsoMax70Text? Village { get; init; } 
    /// <summary>
    /// Name of the town or city.
    /// </summary>
    public IsoMax35Text? TownName { get; init; } 
    /// <summary>
    /// Name of the state, county or country sub-division.
    /// </summary>
    public IsoMax70Text? State { get; init; } 
    /// <summary>
    /// Country of the address.
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
        if (AddressType is AddressType2Choice_ AddressTypeValue)
        {
            writer.WriteStartElement(null, "AdrTp", xmlNamespace );
            AddressTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MailingIndicator is IsoYesNoIndicator MailingIndicatorValue)
        {
            writer.WriteStartElement(null, "MlngInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MailingIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (RegistrationAddressIndicator is IsoYesNoIndicator RegistrationAddressIndicatorValue)
        {
            writer.WriteStartElement(null, "RegnAdrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RegistrationAddressIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CareOf is IsoMax70Text CareOfValue)
        {
            writer.WriteStartElement(null, "CareOf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(CareOfValue)); // data type Max70Text System.String
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
        if (BuildingName is IsoMax35Text BuildingNameValue)
        {
            writer.WriteStartElement(null, "BldgNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BuildingNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PostBox is IsoMax10Text PostBoxValue)
        {
            writer.WriteStartElement(null, "PstBx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10Text(PostBoxValue)); // data type Max10Text System.String
            writer.WriteEndElement();
        }
        if (SideInBuilding is IsoMax35Text SideInBuildingValue)
        {
            writer.WriteStartElement(null, "SdInBldg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SideInBuildingValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Floor is IsoMax70Text FloorValue)
        {
            writer.WriteStartElement(null, "Flr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(FloorValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (SuiteIdentification is IsoMax10Text SuiteIdentificationValue)
        {
            writer.WriteStartElement(null, "SuiteId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10Text(SuiteIdentificationValue)); // data type Max10Text System.String
            writer.WriteEndElement();
        }
        if (PostCode is IsoMax16Text PostCodeValue)
        {
            writer.WriteStartElement(null, "PstCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax16Text(PostCodeValue)); // data type Max16Text System.String
            writer.WriteEndElement();
        }
        if (DistrictName is IsoMax35Text DistrictNameValue)
        {
            writer.WriteStartElement(null, "DstrctNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DistrictNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Village is IsoMax70Text VillageValue)
        {
            writer.WriteStartElement(null, "Vllg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(VillageValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (TownName is IsoMax35Text TownNameValue)
        {
            writer.WriteStartElement(null, "TwnNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TownNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (State is IsoMax70Text StateValue)
        {
            writer.WriteStartElement(null, "Stat", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(StateValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Ctry", xmlNamespace );
        writer.WriteValue(Country.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static PostalAddress21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
