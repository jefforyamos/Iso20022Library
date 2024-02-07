﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Quantity18Choice.  ISO2002 ID# _LyFLJzq5EeWQ1Y7f8kds2A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different quantity of security formats.
/// </summary>
[KnownType(typeof(Quantity18Choice.OriginalAndCurrentFaceAmount))]
[KnownType(typeof(Quantity18Choice.SignedQuantity))]
public abstract partial record Quantity18Choice_ : IIsoXmlSerilizable<Quantity18Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Quantity18Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "OrgnlAndCurFaceAmt" => Quantity18Choice.OriginalAndCurrentFaceAmount.Deserialize(elementWithPayload),
             "SgndQty" => Quantity18Choice.SignedQuantity.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Quantity18Choice choice.")
        };
    }
}
