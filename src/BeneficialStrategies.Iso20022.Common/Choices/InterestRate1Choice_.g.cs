﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRate1Choice.  ISO2002 ID# _Qk1wctp-Ed-ak6NoX_4Aeg_-868217621.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a fixed rate and a variable rate.
/// </summary>
[KnownType(typeof(InterestRate1Choice.FixedInterestRate))]
[KnownType(typeof(InterestRate1Choice.VariableInterestRate))]
public abstract partial record InterestRate1Choice_ : IIsoXmlSerilizable<InterestRate1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InterestRate1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "FxdIntrstRate" => InterestRate1Choice.FixedInterestRate.Deserialize(elementWithPayload),
             "VarblIntrstRate" => InterestRate1Choice.VariableInterestRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InterestRate1Choice choice.")
        };
    }
}
