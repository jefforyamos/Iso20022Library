﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepurchaseType8Choice.  ISO2002 ID# _GS4Cgd0dEd-Cb-IGbQ4hBQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repurchase transaction type information.
/// </summary>
[KnownType(typeof(RepurchaseType8Choice.Code))]
[KnownType(typeof(RepurchaseType8Choice.Proprietary))]
public abstract partial record RepurchaseType8Choice_ : IIsoXmlSerilizable<RepurchaseType8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepurchaseType8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RepurchaseType8Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RepurchaseType8Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepurchaseType8Choice choice.")
        };
    }
}
