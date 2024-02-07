﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties1Choice.  ISO2002 ID# _7vPYQxdAEeK5g-3oYI0_9Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Party associated with the account.
/// </summary>
[KnownType(typeof(AccountParties1Choice.PrimaryOwner))]
[KnownType(typeof(AccountParties1Choice.Trustee))]
[KnownType(typeof(AccountParties1Choice.CustodianForMinor))]
[KnownType(typeof(AccountParties1Choice.Nominee))]
[KnownType(typeof(AccountParties1Choice.JointOwner))]
public abstract partial record AccountParties1Choice_ : IIsoXmlSerilizable<AccountParties1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountParties1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PmryOwnr" => AccountParties1Choice.PrimaryOwner.Deserialize(elementWithPayload),
             "Trstee" => AccountParties1Choice.Trustee.Deserialize(elementWithPayload),
             "CtdnForMnr" => AccountParties1Choice.CustodianForMinor.Deserialize(elementWithPayload),
             "Nmnee" => AccountParties1Choice.Nominee.Deserialize(elementWithPayload),
             "JntOwnr" => AccountParties1Choice.JointOwner.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountParties1Choice choice.")
        };
    }
}
