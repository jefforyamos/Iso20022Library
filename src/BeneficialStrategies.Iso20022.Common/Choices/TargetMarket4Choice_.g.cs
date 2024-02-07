﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TargetMarket4Choice.  ISO2002 ID# _eEqHsNdhEeibyvRfU9vJ7w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of how a financial product is in scope of a target market parameter.
/// </summary>
[KnownType(typeof(TargetMarket4Choice.Type))]
[KnownType(typeof(TargetMarket4Choice.Other))]
public abstract partial record TargetMarket4Choice_ : IIsoXmlSerilizable<TargetMarket4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TargetMarket4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Tp" => TargetMarket4Choice.Type.Deserialize(elementWithPayload),
             "Othr" => TargetMarket4Choice.Other.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TargetMarket4Choice choice.")
        };
    }
}
