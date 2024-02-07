﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat55Choice.  ISO2002 ID# _ckDmi5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a percentage price or an amount price or index points.
/// </summary>
[KnownType(typeof(PriceFormat55Choice.PercentagePrice))]
[KnownType(typeof(PriceFormat55Choice.AmountPrice))]
[KnownType(typeof(PriceFormat55Choice.IndexPoints))]
public abstract partial record PriceFormat55Choice_ : IIsoXmlSerilizable<PriceFormat55Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PriceFormat55Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PctgPric" => PriceFormat55Choice.PercentagePrice.Deserialize(elementWithPayload),
             "AmtPric" => PriceFormat55Choice.AmountPrice.Deserialize(elementWithPayload),
             "IndxPts" => PriceFormat55Choice.IndexPoints.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PriceFormat55Choice choice.")
        };
    }
}
