﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ContractTerm3Choice.  ISO2002 ID# _tFmdMa9_EemF0ZVFnxVu4g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the transaction is open term, that is. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
/// </summary>
[KnownType(typeof(ContractTerm3Choice.Open))]
[KnownType(typeof(ContractTerm3Choice.Fixed))]
public abstract partial record ContractTerm3Choice_ : IIsoXmlSerilizable<ContractTerm3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ContractTerm3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Opn" => ContractTerm3Choice.Open.Deserialize(elementWithPayload),
             "Fxd" => ContractTerm3Choice.Fixed.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ContractTerm3Choice choice.")
        };
    }
}
