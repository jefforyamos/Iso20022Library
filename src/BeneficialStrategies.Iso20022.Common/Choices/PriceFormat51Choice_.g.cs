﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat51Choice.  ISO2002 ID# _Wy2joUGNEeWqy4niLuXETA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a percentage price or an amount price or index points.
/// </summary>
[KnownType(typeof(PriceFormat51Choice.PercentagePrice))]
[KnownType(typeof(PriceFormat51Choice.AmountPrice))]
[KnownType(typeof(PriceFormat51Choice.IndexPoints))]
public abstract partial record PriceFormat51Choice_ : IIsoXmlSerilizable<PriceFormat51Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PriceFormat51Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PctgPric" => PriceFormat51Choice.PercentagePrice.Deserialize(elementWithPayload),
             "AmtPric" => PriceFormat51Choice.AmountPrice.Deserialize(elementWithPayload),
             "IndxPts" => PriceFormat51Choice.IndexPoints.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PriceFormat51Choice choice.")
        };
    }
}
