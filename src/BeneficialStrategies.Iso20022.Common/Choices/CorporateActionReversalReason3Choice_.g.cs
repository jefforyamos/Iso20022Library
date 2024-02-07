﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionReversalReason3Choice.  ISO2002 ID# _cCQvJ0GKEeWqy4niLuXETA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the reason for the reversal.
/// </summary>
[KnownType(typeof(CorporateActionReversalReason3Choice.Code))]
[KnownType(typeof(CorporateActionReversalReason3Choice.Proprietary))]
public abstract partial record CorporateActionReversalReason3Choice_ : IIsoXmlSerilizable<CorporateActionReversalReason3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionReversalReason3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionReversalReason3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionReversalReason3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionReversalReason3Choice choice.")
        };
    }
}
