﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionType4Choice.  ISO2002 ID# _AbgFstokEeC60axPepSq7g_934276367.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the option type.
/// </summary>
[KnownType(typeof(OptionType4Choice.Code))]
[KnownType(typeof(OptionType4Choice.Proprietary))]
public abstract partial record OptionType4Choice_ : IIsoXmlSerilizable<OptionType4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OptionType4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OptionType4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OptionType4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OptionType4Choice choice.")
        };
    }
}
