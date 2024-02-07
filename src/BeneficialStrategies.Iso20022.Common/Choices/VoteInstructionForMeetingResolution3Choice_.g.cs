﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for VoteInstructionForMeetingResolution3Choice.  ISO2002 ID# _nguqQa4dEemG7MmivSuE5g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Vote instruction applying to resolutions added during the meeting.
/// </summary>
[KnownType(typeof(VoteInstructionForMeetingResolution3Choice.VoteIndication))]
[KnownType(typeof(VoteInstructionForMeetingResolution3Choice.Shareholder))]
public abstract partial record VoteInstructionForMeetingResolution3Choice_ : IIsoXmlSerilizable<VoteInstructionForMeetingResolution3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static VoteInstructionForMeetingResolution3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "VoteIndctn" => VoteInstructionForMeetingResolution3Choice.VoteIndication.Deserialize(elementWithPayload),
             "Shrhldr" => VoteInstructionForMeetingResolution3Choice.Shareholder.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid VoteInstructionForMeetingResolution3Choice choice.")
        };
    }
}
