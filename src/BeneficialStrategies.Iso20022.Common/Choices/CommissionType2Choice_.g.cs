﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CommissionType2Choice.  ISO2002 ID# _Ac_TctokEeC60axPepSq7g_1955335824.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code or a data source scheme to determine the commission type.
/// </summary>
[KnownType(typeof(CommissionType2Choice.Code))]
[KnownType(typeof(CommissionType2Choice.Proprietary))]
public abstract partial record CommissionType2Choice_ : IIsoXmlSerilizable<CommissionType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CommissionType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CommissionType2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CommissionType2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CommissionType2Choice choice.")
        };
    }
}
