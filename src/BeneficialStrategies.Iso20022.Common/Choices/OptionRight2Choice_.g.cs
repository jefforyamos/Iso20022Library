﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionRight2Choice.  ISO2002 ID# _PwmrYZEjEeakHoV5BVecAQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the option rights.
/// </summary>
[KnownType(typeof(OptionRight2Choice.Code))]
[KnownType(typeof(OptionRight2Choice.Proprietary))]
public abstract partial record OptionRight2Choice_ : IIsoXmlSerilizable<OptionRight2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OptionRight2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OptionRight2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OptionRight2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OptionRight2Choice choice.")
        };
    }
}
