﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentification7Choice.  ISO2002 ID# _QSXgYtp-Ed-ak6NoX_4Aeg_-1261780269.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
/// </summary>
[KnownType(typeof(AccountIdentification7Choice.ForAllAccounts))]
[KnownType(typeof(AccountIdentification7Choice.AccountsListAndBalanceDetails))]
public abstract partial record AccountIdentification7Choice_ : IIsoXmlSerilizable<AccountIdentification7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountIdentification7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ForAllAccts" => AccountIdentification7Choice.ForAllAccounts.Deserialize(elementWithPayload),
             "AcctsListAndBalDtls" => AccountIdentification7Choice.AccountsListAndBalanceDetails.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountIdentification7Choice choice.")
        };
    }
}
