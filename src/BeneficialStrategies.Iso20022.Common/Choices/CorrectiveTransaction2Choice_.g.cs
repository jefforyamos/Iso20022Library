﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorrectiveTransaction2Choice.  ISO2002 ID# _wO4VgWXqEeap-P22vGV91g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the corrective transaction on which the investigation is processed.
/// </summary>
[KnownType(typeof(CorrectiveTransaction2Choice.Initiation))]
[KnownType(typeof(CorrectiveTransaction2Choice.Interbank))]
public abstract partial record CorrectiveTransaction2Choice_ : IIsoXmlSerilizable<CorrectiveTransaction2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorrectiveTransaction2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Initn" => CorrectiveTransaction2Choice.Initiation.Deserialize(elementWithPayload),
             "IntrBk" => CorrectiveTransaction2Choice.Interbank.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorrectiveTransaction2Choice choice.")
        };
    }
}
