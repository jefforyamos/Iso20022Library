﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LetterOfGuarantee3Choice.  ISO2002 ID# _AY9vEdokEeC60axPepSq7g_-1666647769.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the letter of guarantee information.
/// </summary>
[KnownType(typeof(LetterOfGuarantee3Choice.Indicator))]
[KnownType(typeof(LetterOfGuarantee3Choice.Proprietary))]
public abstract partial record LetterOfGuarantee3Choice_ : IIsoXmlSerilizable<LetterOfGuarantee3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static LetterOfGuarantee3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ind" => LetterOfGuarantee3Choice.Indicator.Deserialize(elementWithPayload),
             "Prtry" => LetterOfGuarantee3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid LetterOfGuarantee3Choice choice.")
        };
    }
}
