﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyOrBusinessError3Choice.  ISO2002 ID# _0CyYAYwXEei289CGNqs21g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Report between the party reference data or a business error.
/// </summary>
[KnownType(typeof(PartyOrBusinessError3Choice.SystemParty))]
[KnownType(typeof(PartyOrBusinessError3Choice.BusinessError))]
public abstract partial record PartyOrBusinessError3Choice_ : IIsoXmlSerilizable<PartyOrBusinessError3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyOrBusinessError3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SysPty" => PartyOrBusinessError3Choice.SystemParty.Deserialize(elementWithPayload),
             "BizErr" => PartyOrBusinessError3Choice.BusinessError.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyOrBusinessError3Choice choice.")
        };
    }
}
