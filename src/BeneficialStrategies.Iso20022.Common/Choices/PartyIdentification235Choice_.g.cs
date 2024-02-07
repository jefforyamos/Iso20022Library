﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification235Choice.  ISO2002 ID# _vS27Ie9KEemVGdgB8P8uQQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Provides the identification of the organisation.
/// </summary>
[KnownType(typeof(PartyIdentification235Choice.Legal))]
[KnownType(typeof(PartyIdentification235Choice.Natural))]
public abstract partial record PartyIdentification235Choice_ : IIsoXmlSerilizable<PartyIdentification235Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification235Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Lgl" => PartyIdentification235Choice.Legal.Deserialize(elementWithPayload),
             "Ntrl" => PartyIdentification235Choice.Natural.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification235Choice choice.")
        };
    }
}
