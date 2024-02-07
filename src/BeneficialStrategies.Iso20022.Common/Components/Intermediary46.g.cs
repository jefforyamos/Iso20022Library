﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary46.  ISO2002 ID# _kMs9xZQ_EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and its role.
/// </summary>
public partial record Intermediary46
     : IIsoXmlSerilizable<Intermediary46>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    public required PartyIdentification177Choice_ Identification { get; init; } 
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account32? Account { get; init; } 
    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; } 
    /// <summary>
    /// Role or function performed by the intermediary.
    /// </summary>
    public PartyRole2Choice_? Role { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress6? SecondaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public NameAndAddress4? NameAndAddress { get; init; } 
    
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
        if (LegalEntityIdentifier is IsoLEIIdentifier LegalEntityIdentifierValue)
        {
            writer.WriteStartElement(null, "LglNttyIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LegalEntityIdentifierValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (Account is Account32 AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WaivedTrailerCommissionIndicator is IsoYesNoIndicator WaivedTrailerCommissionIndicatorValue)
        {
            writer.WriteStartElement(null, "WvdTrlrComssnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(WaivedTrailerCommissionIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Role is PartyRole2Choice_ RoleValue)
        {
            writer.WriteStartElement(null, "Role", xmlNamespace );
            RoleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrimaryCommunicationAddress is CommunicationAddress6 PrimaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "PmryComAdr", xmlNamespace );
            PrimaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryCommunicationAddress is CommunicationAddress6 SecondaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "ScndryComAdr", xmlNamespace );
            SecondaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NameAndAddress is NameAndAddress4 NameAndAddressValue)
        {
            writer.WriteStartElement(null, "NmAndAdr", xmlNamespace );
            NameAndAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Intermediary46 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
