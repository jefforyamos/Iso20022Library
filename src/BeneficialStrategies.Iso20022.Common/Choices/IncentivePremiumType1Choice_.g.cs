﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IncentivePremiumType1Choice.  ISO2002 ID# _RDieodp-Ed-ak6NoX_4Aeg_1038160776.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of cash premium paid to the security holder when voting.
/// </summary>
[KnownType(typeof(IncentivePremiumType1Choice.PerSecurity))]
[KnownType(typeof(IncentivePremiumType1Choice.PerVote))]
[KnownType(typeof(IncentivePremiumType1Choice.PerAttendee))]
public abstract partial record IncentivePremiumType1Choice_ : IIsoXmlSerilizable<IncentivePremiumType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static IncentivePremiumType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PerScty" => IncentivePremiumType1Choice.PerSecurity.Deserialize(elementWithPayload),
             "PerVote" => IncentivePremiumType1Choice.PerVote.Deserialize(elementWithPayload),
             "PerAttndee" => IncentivePremiumType1Choice.PerAttendee.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid IncentivePremiumType1Choice choice.")
        };
    }
}
