﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PersonOrOrganisation2Choice.  ISO2002 ID# _9-fNkQkiEeWGouz230Xp5Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the identification of a person or an organisation.
/// </summary>
[KnownType(typeof(PersonOrOrganisation2Choice.LEI))]
[KnownType(typeof(PersonOrOrganisation2Choice.Person))]
public abstract partial record PersonOrOrganisation2Choice_ : IIsoXmlSerilizable<PersonOrOrganisation2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PersonOrOrganisation2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "LEI" => PersonOrOrganisation2Choice.LEI.Deserialize(elementWithPayload),
             "Prsn" => PersonOrOrganisation2Choice.Person.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PersonOrOrganisation2Choice choice.")
        };
    }
}
