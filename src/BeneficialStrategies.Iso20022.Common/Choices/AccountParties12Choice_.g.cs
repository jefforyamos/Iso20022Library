﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties12Choice.  ISO2002 ID# _mWdfp5Q_EemqYPWMBuVawg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Information about a party's account.
/// </summary>
[KnownType(typeof(AccountParties12Choice.PrimaryOwner))]
[KnownType(typeof(AccountParties12Choice.Trustee))]
[KnownType(typeof(AccountParties12Choice.Nominee))]
[KnownType(typeof(AccountParties12Choice.JointOwner))]
public abstract partial record AccountParties12Choice_ : IIsoXmlSerilizable<AccountParties12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountParties12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PmryOwnr" => AccountParties12Choice.PrimaryOwner.Deserialize(elementWithPayload),
             "Trstee" => AccountParties12Choice.Trustee.Deserialize(elementWithPayload),
             "Nmnee" => AccountParties12Choice.Nominee.Deserialize(elementWithPayload),
             "JntOwnr" => AccountParties12Choice.JointOwner.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountParties12Choice choice.")
        };
    }
}
