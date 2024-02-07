﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition2Choice.  ISO2002 ID# _QtevGtp-Ed-ak6NoX_4Aeg_-730269459.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing position.
/// </summary>
[KnownType(typeof(ProcessingPosition2Choice.Code))]
[KnownType(typeof(ProcessingPosition2Choice.Proprietary))]
public abstract partial record ProcessingPosition2Choice_ : IIsoXmlSerilizable<ProcessingPosition2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingPosition2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ProcessingPosition2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ProcessingPosition2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingPosition2Choice choice.")
        };
    }
}
