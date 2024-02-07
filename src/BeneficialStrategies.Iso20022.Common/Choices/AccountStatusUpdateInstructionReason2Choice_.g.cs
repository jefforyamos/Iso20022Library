﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountStatusUpdateInstructionReason2Choice.  ISO2002 ID# _0Y8Z4Xi8EeaRm5xIK6nGuQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a reason for an instruction to change the status of an account.
/// </summary>
[KnownType(typeof(AccountStatusUpdateInstructionReason2Choice.Code))]
[KnownType(typeof(AccountStatusUpdateInstructionReason2Choice.Proprietary))]
public abstract partial record AccountStatusUpdateInstructionReason2Choice_ : IIsoXmlSerilizable<AccountStatusUpdateInstructionReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountStatusUpdateInstructionReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AccountStatusUpdateInstructionReason2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AccountStatusUpdateInstructionReason2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountStatusUpdateInstructionReason2Choice choice.")
        };
    }
}
