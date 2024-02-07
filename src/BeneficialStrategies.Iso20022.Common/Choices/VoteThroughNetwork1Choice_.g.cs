﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for VoteThroughNetwork1Choice.  ISO2002 ID# _qNpVMDT7Ee2tRf29bleifQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between voting directly to issuers or voting via alternate network channels.
/// </summary>
[KnownType(typeof(VoteThroughNetwork1Choice.VoteChannel))]
[KnownType(typeof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer))]
public abstract partial record VoteThroughNetwork1Choice_ : IIsoXmlSerilizable<VoteThroughNetwork1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static VoteThroughNetwork1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "VoteChanl" => VoteThroughNetwork1Choice.VoteChannel.Deserialize(elementWithPayload),
             "VoteDrctlyToIssr" => VoteThroughNetwork1Choice.VoteDirectlyToIssuer.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid VoteThroughNetwork1Choice choice.")
        };
    }
}
