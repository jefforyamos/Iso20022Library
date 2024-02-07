﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for WaivingInstruction2Choice.  ISO2002 ID# _Ox8_UViPEeaMNZxYNthMeA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the waiving instruction.
/// </summary>
[KnownType(typeof(WaivingInstruction2Choice.Code))]
[KnownType(typeof(WaivingInstruction2Choice.Proprietary))]
public abstract partial record WaivingInstruction2Choice_ : IIsoXmlSerilizable<WaivingInstruction2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static WaivingInstruction2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => WaivingInstruction2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => WaivingInstruction2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid WaivingInstruction2Choice choice.")
        };
    }
}
