﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementSystemMethod3Choice.  ISO2002 ID# _AZQqAdokEeC60axPepSq7g_1949401070.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the settlement system/method.
/// </summary>
[KnownType(typeof(SettlementSystemMethod3Choice.Code))]
[KnownType(typeof(SettlementSystemMethod3Choice.Proprietary))]
public abstract partial record SettlementSystemMethod3Choice_ : IIsoXmlSerilizable<SettlementSystemMethod3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementSystemMethod3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SettlementSystemMethod3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SettlementSystemMethod3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementSystemMethod3Choice choice.")
        };
    }
}
