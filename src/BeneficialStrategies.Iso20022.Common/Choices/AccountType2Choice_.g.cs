﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountType2Choice.  ISO2002 ID# _cyOI8SC7EeWPMvNwVtiMsA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the type of account.
/// </summary>
[KnownType(typeof(AccountType2Choice.Code))]
[KnownType(typeof(AccountType2Choice.Proprietary))]
public abstract partial record AccountType2Choice_ : IIsoXmlSerilizable<AccountType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AccountType2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AccountType2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountType2Choice choice.")
        };
    }
}
