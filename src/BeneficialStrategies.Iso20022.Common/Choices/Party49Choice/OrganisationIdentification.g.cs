﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrganisationIdentification.  ISO2002 ID# _dbeBY-EpEemRzcIkmUETeA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Party49Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record OrganisationIdentification : Party49Choice_
     , IIsoXmlSerilizable<OrganisationIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Business identification code of the organisation.
    /// </summary>
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericOrganisationIdentification1? Other { get; init; } 
    
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
        if (AnyBIC is IsoAnyBICDec2014Identifier AnyBICValue)
        {
            writer.WriteStartElement(null, "AnyBIC", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoAnyBICDec2014Identifier(AnyBICValue)); // data type AnyBICDec2014Identifier System.String
            writer.WriteEndElement();
        }
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (EmailAddress is IsoMax256Text EmailAddressValue)
        {
            writer.WriteStartElement(null, "EmailAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(EmailAddressValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        if (Other is GenericOrganisationIdentification1 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new OrganisationIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
