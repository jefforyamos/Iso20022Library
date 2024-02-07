﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuantityOrCode1Choice.  ISO2002 ID# _9Z368K-VEemJ1NnLPsTFaw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a quantity or a code value.
/// </summary>
[KnownType(typeof(QuantityOrCode1Choice.Quantity))]
[KnownType(typeof(QuantityOrCode1Choice.Code))]
public abstract partial record QuantityOrCode1Choice_ : IIsoXmlSerilizable<QuantityOrCode1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static QuantityOrCode1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => QuantityOrCode1Choice.Quantity.Deserialize(elementWithPayload),
             "Cd" => QuantityOrCode1Choice.Code.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid QuantityOrCode1Choice choice.")
        };
    }
}
