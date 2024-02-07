﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Quantity12Choice.  ISO2002 ID# _ioTPQ_srEeCUd_EZYqZ_Uw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of quantity of assets to be transferred in percentage rate or units.
/// </summary>
[KnownType(typeof(Quantity12Choice.Unit))]
[KnownType(typeof(Quantity12Choice.PercentageRate))]
public abstract partial record Quantity12Choice_ : IIsoXmlSerilizable<Quantity12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Quantity12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Unit" => Quantity12Choice.Unit.Deserialize(elementWithPayload),
             "PctgRate" => Quantity12Choice.PercentageRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Quantity12Choice choice.")
        };
    }
}
