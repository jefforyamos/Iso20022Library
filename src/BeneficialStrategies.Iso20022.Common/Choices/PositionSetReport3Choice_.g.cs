﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PositionSetReport3Choice.  ISO2002 ID# _0loGgcKwEeuM4pgP8Vixbg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Statistics per counterparty reporting under the local regulation.
/// </summary>
[KnownType(typeof(PositionSetReport3Choice.DataSetAction))]
[KnownType(typeof(PositionSetReport3Choice.Report))]
public abstract partial record PositionSetReport3Choice_ : IIsoXmlSerilizable<PositionSetReport3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PositionSetReport3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DataSetActn" => PositionSetReport3Choice.DataSetAction.Deserialize(elementWithPayload),
             "Rpt" => PositionSetReport3Choice.Report.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PositionSetReport3Choice choice.")
        };
    }
}
