﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemParty5.  ISO2002 ID# _0NEVZYwXEei289CGNqs21g.
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
public partial record SystemParty5
     : IIsoXmlSerilizable<SystemParty5>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party within the system.
    /// </summary>
    public SystemPartyIdentification9? PartyIdentification { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    public PostalAddress25? Address { get; init; } 
    /// <summary>
    /// Specifies the options on how to contact the party.
    /// </summary>
    public Contact5? ContactDetails { get; init; } 
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
    public SystemPartyType1Choice_? Type { get; init; } 
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    public TechnicalIdentification2Choice_? TechnicalAddress { get; init; } 
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public PartyName4? Name { get; init; } 
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    public ResidenceType1Code? ResidenceType { get; init; } 
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    public PartyLockStatus1? LockStatus { get; init; } 
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
        if (PartyIdentification is SystemPartyIdentification9 PartyIdentificationValue)
        {
            writer.WriteStartElement(null, "PtyId", xmlNamespace );
            PartyIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Address is PostalAddress25 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactDetails is Contact5 ContactDetailsValue)
        {
            writer.WriteStartElement(null, "CtctDtls", xmlNamespace );
            ContactDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
        if (Type is SystemPartyType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TechnicalAddress is TechnicalIdentification2Choice_ TechnicalAddressValue)
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
        if (Name is PartyName4 NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            NameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResidenceType is ResidenceType1Code ResidenceTypeValue)
        {
            writer.WriteStartElement(null, "ResTp", xmlNamespace );
            writer.WriteValue(ResidenceTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LockStatus is PartyLockStatus1 LockStatusValue)
        {
            writer.WriteStartElement(null, "LckSts", xmlNamespace );
            LockStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Restriction is SystemRestriction1 RestrictionValue)
        {
            writer.WriteStartElement(null, "Rstrctn", xmlNamespace );
            RestrictionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SystemParty5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
