﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatisticsPerCounterparty3Choice.  ISO2002 ID# _66pN4c2GEeqFGLkKbAvCGg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Statistics per counterparty reporting under the local regulation.
/// </summary>
[KnownType(typeof(StatisticsPerCounterparty3Choice.DataSetAction))]
[KnownType(typeof(StatisticsPerCounterparty3Choice.Report))]
public abstract partial record StatisticsPerCounterparty3Choice_ : IIsoXmlSerilizable<StatisticsPerCounterparty3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StatisticsPerCounterparty3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DataSetActn" => StatisticsPerCounterparty3Choice.DataSetAction.Deserialize(elementWithPayload),
             "Rpt" => StatisticsPerCounterparty3Choice.Report.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StatisticsPerCounterparty3Choice choice.")
        };
    }
}
