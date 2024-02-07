﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRate8Choice.  ISO2002 ID# _H7ydeX5aEea2k7EBUopqxw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a fixed rate and a variable rate.
/// </summary>
[KnownType(typeof(InterestRate8Choice.Fixed))]
[KnownType(typeof(InterestRate8Choice.Floating))]
public abstract partial record InterestRate8Choice_ : IIsoXmlSerilizable<InterestRate8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InterestRate8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Fxd" => InterestRate8Choice.Fixed.Deserialize(elementWithPayload),
             "Fltg" => InterestRate8Choice.Floating.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InterestRate8Choice choice.")
        };
    }
}
