﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party16Choice.  ISO2002 ID# _ll6wwRRkEeOKWo1NF21OVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the party.
/// </summary>
[KnownType(typeof(Party16Choice.Organisation))]
[KnownType(typeof(Party16Choice.IndividualPerson))]
public abstract partial record Party16Choice_ : IIsoXmlSerilizable<Party16Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Party16Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Org" => Party16Choice.Organisation.Deserialize(elementWithPayload),
             "IndvPrsn" => Party16Choice.IndividualPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Party16Choice choice.")
        };
    }
}
