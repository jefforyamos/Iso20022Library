﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CommodityDerivative2Choice.  ISO2002 ID# _nZzFsU-nEeiVsYLJl6hleg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice for transparency calculation specific details on commodities.
/// </summary>
[KnownType(typeof(CommodityDerivative2Choice.Freight))]
[KnownType(typeof(CommodityDerivative2Choice.Energy))]
public abstract partial record CommodityDerivative2Choice_ : IIsoXmlSerilizable<CommodityDerivative2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CommodityDerivative2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Frght" => CommodityDerivative2Choice.Freight.Deserialize(elementWithPayload),
             "Nrgy" => CommodityDerivative2Choice.Energy.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CommodityDerivative2Choice choice.")
        };
    }
}
