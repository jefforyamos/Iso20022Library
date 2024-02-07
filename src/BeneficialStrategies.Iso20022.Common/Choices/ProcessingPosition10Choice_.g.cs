﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition10Choice.  ISO2002 ID# _chT0q5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing position.
/// </summary>
[KnownType(typeof(ProcessingPosition10Choice.Code))]
[KnownType(typeof(ProcessingPosition10Choice.Proprietary))]
public abstract partial record ProcessingPosition10Choice_ : IIsoXmlSerilizable<ProcessingPosition10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingPosition10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ProcessingPosition10Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ProcessingPosition10Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingPosition10Choice choice.")
        };
    }
}
