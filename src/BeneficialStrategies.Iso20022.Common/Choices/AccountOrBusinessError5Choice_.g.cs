﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountOrBusinessError5Choice.  ISO2002 ID# _fDmr0dcZEeqRFcf2R4bPBw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between account details or a business error when the requested data cannot be retrieved.
/// </summary>
[KnownType(typeof(AccountOrBusinessError5Choice.Account))]
[KnownType(typeof(AccountOrBusinessError5Choice.BusinessError))]
public abstract partial record AccountOrBusinessError5Choice_ : IIsoXmlSerilizable<AccountOrBusinessError5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountOrBusinessError5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Acct" => AccountOrBusinessError5Choice.Account.Deserialize(elementWithPayload),
             "BizErr" => AccountOrBusinessError5Choice.BusinessError.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountOrBusinessError5Choice choice.")
        };
    }
}
