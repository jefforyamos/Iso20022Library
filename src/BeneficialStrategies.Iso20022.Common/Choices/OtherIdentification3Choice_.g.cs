﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OtherIdentification3Choice.  ISO2002 ID# _05uN4SCOEeWJd9HF2tO7BA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of other identification.
/// </summary>
[KnownType(typeof(OtherIdentification3Choice.Code))]
[KnownType(typeof(OtherIdentification3Choice.Proprietary))]
public abstract partial record OtherIdentification3Choice_ : IIsoXmlSerilizable<OtherIdentification3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OtherIdentification3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OtherIdentification3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OtherIdentification3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OtherIdentification3Choice choice.")
        };
    }
}
