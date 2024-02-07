﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentificationSearchCriteria2Choice.  ISO2002 ID# _g7QEuGliEeGaMcKyqKNRfQ_-836272256.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between the different options to search for an account.
/// </summary>
[KnownType(typeof(AccountIdentificationSearchCriteria2Choice.Equal))]
[KnownType(typeof(AccountIdentificationSearchCriteria2Choice.ContainText))]
[KnownType(typeof(AccountIdentificationSearchCriteria2Choice.NotContainText))]
public abstract partial record AccountIdentificationSearchCriteria2Choice_ : IIsoXmlSerilizable<AccountIdentificationSearchCriteria2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountIdentificationSearchCriteria2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "EQ" => AccountIdentificationSearchCriteria2Choice.Equal.Deserialize(elementWithPayload),
             "CTTxt" => AccountIdentificationSearchCriteria2Choice.ContainText.Deserialize(elementWithPayload),
             "NCTTxt" => AccountIdentificationSearchCriteria2Choice.NotContainText.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountIdentificationSearchCriteria2Choice choice.")
        };
    }
}
