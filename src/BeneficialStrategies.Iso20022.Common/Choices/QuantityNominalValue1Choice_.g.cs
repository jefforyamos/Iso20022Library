﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuantityNominalValue1Choice.  ISO2002 ID# _kXBi4HaiEeavseMKyTsJEA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Information on the securities quantity or bonds nominal amount.
/// </summary>
[KnownType(typeof(QuantityNominalValue1Choice.Quantity))]
[KnownType(typeof(QuantityNominalValue1Choice.NominalValue))]
public abstract partial record QuantityNominalValue1Choice_ : IIsoXmlSerilizable<QuantityNominalValue1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static QuantityNominalValue1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => QuantityNominalValue1Choice.Quantity.Deserialize(elementWithPayload),
             "NmnlVal" => QuantityNominalValue1Choice.NominalValue.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid QuantityNominalValue1Choice choice.")
        };
    }
}
