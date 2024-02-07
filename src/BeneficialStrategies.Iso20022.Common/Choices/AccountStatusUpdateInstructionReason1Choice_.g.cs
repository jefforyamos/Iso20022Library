﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountStatusUpdateInstructionReason1Choice.  ISO2002 ID# _MizyUXi8EeaRm5xIK6nGuQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a reason for an instruction to change the status of an account.
/// </summary>
[KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason))]
[KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.Reason))]
public abstract partial record AccountStatusUpdateInstructionReason1Choice_ : IIsoXmlSerilizable<AccountStatusUpdateInstructionReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AccountStatusUpdateInstructionReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => AccountStatusUpdateInstructionReason1Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AccountStatusUpdateInstructionReason1Choice choice.")
        };
    }
}
