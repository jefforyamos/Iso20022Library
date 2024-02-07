﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InvestigatedParties1Choice.  ISO2002 ID# _cRD_EzwTEeGKuZXNQxGH3g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identifies the response parameters for which there is a match with the search criteria.
/// </summary>
[KnownType(typeof(InvestigatedParties1Choice.Code))]
[KnownType(typeof(InvestigatedParties1Choice.Proprietary))]
public abstract partial record InvestigatedParties1Choice_ : IIsoXmlSerilizable<InvestigatedParties1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InvestigatedParties1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InvestigatedParties1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InvestigatedParties1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InvestigatedParties1Choice choice.")
        };
    }
}
