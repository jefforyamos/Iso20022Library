﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OrganisationIdentification29.  ISO2002 ID# _6VggQW48EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record OrganisationIdentification29
     : IIsoXmlSerilizable<OrganisationIdentification29>
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
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
        if (Other is GenericOrganisationIdentification1 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OrganisationIdentification29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
