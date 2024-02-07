﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OwnerIdentification3Choice.  ISO2002 ID# _B1IjUZTREemC09f0MxYkRg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of individual or organisation details.
/// </summary>
[KnownType(typeof(OwnerIdentification3Choice.IndividualOwnerIdentification))]
[KnownType(typeof(OwnerIdentification3Choice.OrganisationOwnerIdentification))]
public abstract partial record OwnerIdentification3Choice_ : IIsoXmlSerilizable<OwnerIdentification3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OwnerIdentification3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "IndvOwnrId" => OwnerIdentification3Choice.IndividualOwnerIdentification.Deserialize(elementWithPayload),
             "OrgOwnrId" => OwnerIdentification3Choice.OrganisationOwnerIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OwnerIdentification3Choice choice.")
        };
    }
}
