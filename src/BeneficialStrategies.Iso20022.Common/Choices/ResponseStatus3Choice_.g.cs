﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ResponseStatus3Choice.  ISO2002 ID# _0j-I4AlIEeGATtfOBToyew_1037532092.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of response status.
/// </summary>
[KnownType(typeof(ResponseStatus3Choice.Consented))]
[KnownType(typeof(ResponseStatus3Choice.Rejected))]
[KnownType(typeof(ResponseStatus3Choice.Pending))]
public abstract partial record ResponseStatus3Choice_ : IIsoXmlSerilizable<ResponseStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ResponseStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cnsntd" => ResponseStatus3Choice.Consented.Deserialize(elementWithPayload),
             "Rjctd" => ResponseStatus3Choice.Rejected.Deserialize(elementWithPayload),
             "Pdg" => ResponseStatus3Choice.Pending.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ResponseStatus3Choice choice.")
        };
    }
}
