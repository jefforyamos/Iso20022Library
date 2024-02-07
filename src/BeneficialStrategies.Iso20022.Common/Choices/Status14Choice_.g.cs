﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status14Choice.  ISO2002 ID# _HT5NMR6rEeODgY9qxg6TFA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the status.
/// </summary>
[KnownType(typeof(Status14Choice.Status))]
[KnownType(typeof(Status14Choice.Rejected))]
public abstract partial record Status14Choice_ : IIsoXmlSerilizable<Status14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Status14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Sts" => Status14Choice.Status.Deserialize(elementWithPayload),
             "Rjctd" => Status14Choice.Rejected.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Status14Choice choice.")
        };
    }
}
