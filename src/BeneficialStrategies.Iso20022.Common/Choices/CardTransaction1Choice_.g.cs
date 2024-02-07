﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CardTransaction1Choice.  ISO2002 ID# _t6ZGslkyEeGeoaLUQk__nA_-1316380729.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a acquirer globalised card transaction or an individual card transaction.
/// </summary>
[KnownType(typeof(CardTransaction1Choice.Aggregated))]
[KnownType(typeof(CardTransaction1Choice.Individual))]
public abstract partial record CardTransaction1Choice_ : IIsoXmlSerilizable<CardTransaction1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CardTransaction1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Aggtd" => CardTransaction1Choice.Aggregated.Deserialize(elementWithPayload),
             "Indv" => CardTransaction1Choice.Individual.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CardTransaction1Choice choice.")
        };
    }
}
