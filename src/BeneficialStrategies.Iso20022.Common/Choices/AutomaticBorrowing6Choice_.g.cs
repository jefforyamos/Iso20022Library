﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AutomaticBorrowing6Choice.  ISO2002 ID# _lL50gTtFEeWRTLSN0i0tng.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the automatic borrowing information.
/// </summary>
[KnownType(typeof(AutomaticBorrowing6Choice.Code))]
[KnownType(typeof(AutomaticBorrowing6Choice.Proprietary))]
public abstract partial record AutomaticBorrowing6Choice_ : IIsoXmlSerilizable<AutomaticBorrowing6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AutomaticBorrowing6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AutomaticBorrowing6Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AutomaticBorrowing6Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AutomaticBorrowing6Choice choice.")
        };
    }
}
