﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestComputationMethodFormat5Choice.  ISO2002 ID# _chVpq5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of interest computation method.
/// </summary>
[KnownType(typeof(InterestComputationMethodFormat5Choice.Code))]
[KnownType(typeof(InterestComputationMethodFormat5Choice.Proprietary))]
public abstract partial record InterestComputationMethodFormat5Choice_ : IIsoXmlSerilizable<InterestComputationMethodFormat5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InterestComputationMethodFormat5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InterestComputationMethodFormat5Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InterestComputationMethodFormat5Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InterestComputationMethodFormat5Choice choice.")
        };
    }
}
