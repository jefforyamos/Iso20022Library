﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteParameters3.  ISO2002 ID# _TjkycNp-Ed-ak6NoX_4Aeg_-423421287.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing how the voting process is organised.
/// </summary>
public partial record VoteParameters3
     : IIsoXmlSerilizable<VoteParameters3>
{
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    public IsoDecimalNumber? SecuritiesQuantityRequiredToVote { get; init; } 
    /// <summary>
    /// Specifies whether it is allowed to only vote on a part of the entire holding, leaving part of the position un-voted.
    /// </summary>
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    /// <summary>
    /// Specifies whether it is allowed to vote in different directions for the entire holding.
    /// </summary>
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    public DateFormat2Choice_? VoteDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary (STP mode).
    /// </summary>
    public DateFormat2Choice_? VoteSTPDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    public DateFormat2Choice_? VoteMarketDeadline { get; init; } 
    /// <summary>
    /// Indicates the different methods that can be used to vote.
    /// </summary>
    public VoteMethods2? VoteMethods { get; init; } 
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat2Choice_? RevocabilityDeadline { get; init; } 
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; init; } 
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; init; } 
    /// <summary>
    /// Indicates whether beneficiary details (eg name and address) must be supplied in order to take part to a meeting.
    /// </summary>
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; } 
    /// <summary>
    /// Identifies the possible types of voting instructions. When used at the resolution level, it supersedes the value specified in the meeting notice.
    /// </summary>
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = [];
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    public IncentivePremium3? IncentivePremium { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium (STP mode).
    /// </summary>
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    
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
        if (SecuritiesQuantityRequiredToVote is IsoDecimalNumber SecuritiesQuantityRequiredToVoteValue)
        {
            writer.WriteStartElement(null, "SctiesQtyReqrdToVote", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(SecuritiesQuantityRequiredToVoteValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrtlVoteAllwd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PartialVoteAllowed)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SpltVoteAllwd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SplitVoteAllowed)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (VoteDeadline is DateFormat2Choice_ VoteDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteDdln", xmlNamespace );
            VoteDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteSTPDeadline is DateFormat2Choice_ VoteSTPDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteSTPDdln", xmlNamespace );
            VoteSTPDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteMarketDeadline is DateFormat2Choice_ VoteMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteMktDdln", xmlNamespace );
            VoteMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteMethods is VoteMethods2 VoteMethodsValue)
        {
            writer.WriteStartElement(null, "VoteMthds", xmlNamespace );
            VoteMethodsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VotingBallotElectronicAddress is CommunicationAddress4 VotingBallotElectronicAddressValue)
        {
            writer.WriteStartElement(null, "VtngBlltElctrncAdr", xmlNamespace );
            VotingBallotElectronicAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VotingBallotRequestAddress is PostalAddress1 VotingBallotRequestAddressValue)
        {
            writer.WriteStartElement(null, "VtngBlltReqAdr", xmlNamespace );
            VotingBallotRequestAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RevocabilityDeadline is DateFormat2Choice_ RevocabilityDeadlineValue)
        {
            writer.WriteStartElement(null, "RvcbltyDdln", xmlNamespace );
            RevocabilityDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RevocabilitySTPDeadline is DateFormat2Choice_ RevocabilitySTPDeadlineValue)
        {
            writer.WriteStartElement(null, "RvcbltySTPDdln", xmlNamespace );
            RevocabilitySTPDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RevocabilityMarketDeadline is DateFormat2Choice_ RevocabilityMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "RvcbltyMktDdln", xmlNamespace );
            RevocabilityMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BnfclOwnrDsclsr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BeneficialOwnerDisclosure)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "VoteInstrTp", xmlNamespace );
        writer.WriteValue(VoteInstructionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (IncentivePremium is IncentivePremium3 IncentivePremiumValue)
        {
            writer.WriteStartElement(null, "IncntivPrm", xmlNamespace );
            IncentivePremiumValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteWithPremiumDeadline is DateFormat2Choice_ VoteWithPremiumDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteWthPrmDdln", xmlNamespace );
            VoteWithPremiumDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteWithPremiumSTPDeadline is DateFormat2Choice_ VoteWithPremiumSTPDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteWthPrmSTPDdln", xmlNamespace );
            VoteWithPremiumSTPDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteWithPremiumMarketDeadline is DateFormat2Choice_ VoteWithPremiumMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteWthPrmMktDdln", xmlNamespace );
            VoteWithPremiumMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalVotingRequirements is IsoMax350Text AdditionalVotingRequirementsValue)
        {
            writer.WriteStartElement(null, "AddtlVtngRqrmnts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalVotingRequirementsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static VoteParameters3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
