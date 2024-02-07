﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OrganisationIdentification6.  ISO2002 ID# _QPrYxtp-Ed-ak6NoX_4Aeg_434657677.
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
public partial record OrganisationIdentification6
     : IIsoXmlSerilizable<OrganisationIdentification6>
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to organisations by the ISO 9362 Registration Authority, under an international identification scheme, as described in the latest version of the standard ISO 9362 Banking (Banking telecommunication messages, Business Identifier Codes).
    /// </summary>
    public IsoAnyBICIdentifier? BIC { get; init; } 
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
        if (BIC is IsoAnyBICIdentifier BICValue)
        {
            writer.WriteStartElement(null, "BIC", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoAnyBICIdentifier(BICValue)); // data type AnyBICIdentifier System.String
            writer.WriteEndElement();
        }
        if (Other is GenericOrganisationIdentification1 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OrganisationIdentification6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
