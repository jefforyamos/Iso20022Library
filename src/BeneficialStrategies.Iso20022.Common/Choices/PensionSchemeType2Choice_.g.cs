﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PensionSchemeType2Choice.  ISO2002 ID# _CELmwTOUEeqLMcD_sEa8Xw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a type of pension scheme.
/// </summary>
[KnownType(typeof(PensionSchemeType2Choice.Code))]
[KnownType(typeof(PensionSchemeType2Choice.Proprietary))]
public abstract partial record PensionSchemeType2Choice_ : IIsoXmlSerilizable<PensionSchemeType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PensionSchemeType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => PensionSchemeType2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => PensionSchemeType2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PensionSchemeType2Choice choice.")
        };
    }
}
