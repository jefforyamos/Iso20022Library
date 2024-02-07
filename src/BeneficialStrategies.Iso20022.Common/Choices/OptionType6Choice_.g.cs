﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionType6Choice.  ISO2002 ID# _tfykITnCEeWV5sr121Fc8A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the option type.
/// </summary>
[KnownType(typeof(OptionType6Choice.Code))]
[KnownType(typeof(OptionType6Choice.Proprietary))]
public abstract partial record OptionType6Choice_ : IIsoXmlSerilizable<OptionType6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OptionType6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OptionType6Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OptionType6Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OptionType6Choice choice.")
        };
    }
}
