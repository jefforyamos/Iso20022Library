﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CodeOrProprietary1Choice.  ISO2002 ID# _Qotj1tp-Ed-ak6NoX_4Aeg_-1810617673.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format between an ISO 20022 code and a proprietary code.
/// </summary>
[KnownType(typeof(CodeOrProprietary1Choice.Code))]
[KnownType(typeof(CodeOrProprietary1Choice.Proprietary))]
public abstract partial record CodeOrProprietary1Choice_ : IIsoXmlSerilizable<CodeOrProprietary1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CodeOrProprietary1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CodeOrProprietary1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CodeOrProprietary1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CodeOrProprietary1Choice choice.")
        };
    }
}
