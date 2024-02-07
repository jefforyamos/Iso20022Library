﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrganisationIdentification.  ISO2002 ID# _Rca4uNp-Ed-ak6NoX_4Aeg_1330521146.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Party1Choice;

/// <summary>
/// Unique and unambiguous way of identifying an organisation.
/// </summary>
public partial record OrganisationIdentification : Party1Choice_
     , IIsoXmlSerilizable<OrganisationIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoBEIIdentifier? BEI { get; init; } 
    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities or physical entities according to the European Association for Numbering (EAN) numbering scheme rules. The number is used to retrieve detailed information linked to it.
    /// </summary>
    public IsoEANGLNIdentifier? EANGLN { get; init; } 
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; } 
    /// <summary>
    /// Data Universal Numbering System. A unique identification number provided by Dun & Bradstreet to identify an organization.
    /// </summary>
    public IsoDunsIdentifier? DUNS { get; init; } 
    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank to identify a relationship as defined between the bank and its client.
    /// </summary>
    public IsoMax35Text? BankPartyIdentification { get; init; } 
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    public GenericIdentification3? ProprietaryIdentification { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (BEI is IsoBEIIdentifier BEIValue)
        {
            writer.WriteStartElement(null, "BEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBEIIdentifier(BEIValue)); // data type BEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (EANGLN is IsoEANGLNIdentifier EANGLNValue)
        {
            writer.WriteStartElement(null, "EANGLN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoEANGLNIdentifier(EANGLNValue)); // data type EANGLNIdentifier System.String
            writer.WriteEndElement();
        }
        if (CHIPSUniversalIdentification is IsoCHIPSUniversalIdentifier CHIPSUniversalIdentificationValue)
        {
            writer.WriteStartElement(null, "USCHU", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoCHIPSUniversalIdentifier(CHIPSUniversalIdentificationValue)); // data type CHIPSUniversalIdentifier System.String
            writer.WriteEndElement();
        }
        if (DUNS is IsoDunsIdentifier DUNSValue)
        {
            writer.WriteStartElement(null, "DUNS", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDunsIdentifier(DUNSValue)); // data type DunsIdentifier System.String
            writer.WriteEndElement();
        }
        if (BankPartyIdentification is IsoMax35Text BankPartyIdentificationValue)
        {
            writer.WriteStartElement(null, "BkPtyId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BankPartyIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TaxIdentificationNumber is IsoMax35Text TaxIdentificationNumberValue)
        {
            writer.WriteStartElement(null, "TaxIdNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TaxIdentificationNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProprietaryIdentification is GenericIdentification3 ProprietaryIdentificationValue)
        {
            writer.WriteStartElement(null, "PrtryId", xmlNamespace );
            ProprietaryIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new OrganisationIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
