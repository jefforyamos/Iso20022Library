﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingReason4Choice.  ISO2002 ID# _Iu4UcRqLEeG38P9Gj2JZJw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the failing reason.
/// </summary>
[KnownType(typeof(FailingReason4Choice.Code))]
[KnownType(typeof(FailingReason4Choice.Proprietary))]
public abstract partial record FailingReason4Choice_ : IIsoXmlSerilizable<FailingReason4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingReason4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => FailingReason4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => FailingReason4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingReason4Choice choice.")
        };
    }
}
