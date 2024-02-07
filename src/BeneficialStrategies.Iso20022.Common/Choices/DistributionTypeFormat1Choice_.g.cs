﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DistributionTypeFormat1Choice.  ISO2002 ID# _Q3nihdp-Ed-ak6NoX_4Aeg_2019414237.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of distribution.
/// </summary>
[KnownType(typeof(DistributionTypeFormat1Choice.Code))]
[KnownType(typeof(DistributionTypeFormat1Choice.Proprietary))]
public abstract partial record DistributionTypeFormat1Choice_ : IIsoXmlSerilizable<DistributionTypeFormat1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DistributionTypeFormat1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DistributionTypeFormat1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DistributionTypeFormat1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DistributionTypeFormat1Choice choice.")
        };
    }
}
