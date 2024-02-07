﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteMethods.  ISO2002 ID# _T5L2Gtp-Ed-ak6NoX_4Aeg_1911915200.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of the different methods that can be used to vote.
/// </summary>
public partial record VoteMethods
     : IIsoXmlSerilizable<VoteMethods>
{
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    public IsoAnyBICIdentifier? VoteThroughNetwork { get; init; } 
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    public PostalAddress1? VoteByMail { get; init; } 
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    public CommunicationAddress4? ElectronicVote { get; init; } 
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    public IsoMax35Text? VoteByTelephone { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (VoteThroughNetwork is IsoAnyBICIdentifier VoteThroughNetworkValue)
        {
            writer.WriteStartElement(null, "VoteThrghNtwk", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoAnyBICIdentifier(VoteThroughNetworkValue)); // data type AnyBICIdentifier System.String
            writer.WriteEndElement();
        }
        if (VoteByMail is PostalAddress1 VoteByMailValue)
        {
            writer.WriteStartElement(null, "VoteByMail", xmlNamespace );
            VoteByMailValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ElectronicVote is CommunicationAddress4 ElectronicVoteValue)
        {
            writer.WriteStartElement(null, "ElctrncVote", xmlNamespace );
            ElectronicVoteValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteByTelephone is IsoMax35Text VoteByTelephoneValue)
        {
            writer.WriteStartElement(null, "VoteByTel", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(VoteByTelephoneValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static VoteMethods Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
