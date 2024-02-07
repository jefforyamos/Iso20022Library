﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType55Choice.  ISO2002 ID# _qIKqe_fYEeiNZp_PtLohLw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a repair reason.
/// </summary>
[KnownType(typeof(SecuritiesTransactionType55Choice.Code))]
[KnownType(typeof(SecuritiesTransactionType55Choice.Proprietary))]
public abstract partial record SecuritiesTransactionType55Choice_ : IIsoXmlSerilizable<SecuritiesTransactionType55Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesTransactionType55Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SecuritiesTransactionType55Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SecuritiesTransactionType55Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesTransactionType55Choice choice.")
        };
    }
}
