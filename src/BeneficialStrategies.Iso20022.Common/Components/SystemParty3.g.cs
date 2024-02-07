﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemParty3.  ISO2002 ID# _kmMrI-5NEeCisYr99QEiWA_-1960651676.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system. 
/// A party shall denote any legal or organisational entity required in the system. 
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
public partial record SystemParty3
     : IIsoXmlSerilizable<SystemParty3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    public IsoISODate? OpeningDate { get; init; } 
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    public SystemPartyType1Code? Type { get; init; } 
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    public TechnicalIdentification1Choice_? TechnicalAddress { get; init; } 
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    public SystemPartyIdentification1? Identification { get; init; } 
    /// <summary>
    /// Name by which an organisation is known and which is usually used to identify that organisation.
    /// </summary>
    public PartyName3? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    public PostalAddress10? Address { get; init; } 
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    public SystemRestriction1? Restriction { get; init; } 
    
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
        if (OpeningDate is IsoISODate OpeningDateValue)
        {
            writer.WriteStartElement(null, "OpngDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OpeningDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ClosingDate is IsoISODate ClosingDateValue)
        {
            writer.WriteStartElement(null, "ClsgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ClosingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Type is SystemPartyType1Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TechnicalAddress is TechnicalIdentification1Choice_ TechnicalAddressValue)
        {
            writer.WriteStartElement(null, "TechAdr", xmlNamespace );
            TechnicalAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketSpecificAttribute is MarketSpecificAttribute1 MarketSpecificAttributeValue)
        {
            writer.WriteStartElement(null, "MktSpcfcAttr", xmlNamespace );
            MarketSpecificAttributeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Identification is SystemPartyIdentification1 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Name is PartyName3 NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            NameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Address is PostalAddress10 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Restriction is SystemRestriction1 RestrictionValue)
        {
            writer.WriteStartElement(null, "Rstrctn", xmlNamespace );
            RestrictionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SystemParty3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
