﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteParameters5.  ISO2002 ID# _lRnYIa09EemDtrWpq90Ckg.
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
public partial record VoteParameters5
     : IIsoXmlSerilizable<VoteParameters5>
{
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; } 
    /// <summary>
    /// Indicates whether a vote can be on a part of the entire holding, that is, part of the position is un-voted.
    /// </summary>
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    /// <summary>
    /// Indicates whether the vote can be split, that is, there could be different votes for different parts of the holding.
    /// </summary>
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    public DateFormat58Choice_? VoteDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    public DateFormat58Choice_? VoteMarketDeadline { get; init; } 
    /// <summary>
    /// Specifies the different methods that can be used to vote.
    /// </summary>
    public VoteMethods3? VoteMethods { get; init; } 
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; } 
    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat58Choice_? RevocabilityDeadline { get; init; } 
    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; } 
    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; } 
    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with a premium deadline).
    /// </summary>
    public IncentivePremium4? EarlyIncentivePremium { get; init; } 
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    public IncentivePremium4? IncentivePremium { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; } 
    
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
        if (SecuritiesQuantityRequiredToVote is FinancialInstrumentQuantity18Choice_ SecuritiesQuantityRequiredToVoteValue)
        {
            writer.WriteStartElement(null, "SctiesQtyReqrdToVote", xmlNamespace );
            SecuritiesQuantityRequiredToVoteValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrtlVoteAllwd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PartialVoteAllowed)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SpltVoteAllwd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SplitVoteAllowed)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (VoteDeadline is DateFormat58Choice_ VoteDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteDdln", xmlNamespace );
            VoteDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteMarketDeadline is DateFormat58Choice_ VoteMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteMktDdln", xmlNamespace );
            VoteMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteMethods is VoteMethods3 VoteMethodsValue)
        {
            writer.WriteStartElement(null, "VoteMthds", xmlNamespace );
            VoteMethodsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VotingBallotElectronicAddress is CommunicationAddress11 VotingBallotElectronicAddressValue)
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
        if (RevocabilityDeadline is DateFormat58Choice_ RevocabilityDeadlineValue)
        {
            writer.WriteStartElement(null, "RvcbltyDdln", xmlNamespace );
            RevocabilityDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RevocabilityMarketDeadline is DateFormat58Choice_ RevocabilityMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "RvcbltyMktDdln", xmlNamespace );
            RevocabilityMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BnfclOwnrDsclsr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BeneficialOwnerDisclosure)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (EarlyIncentivePremium is IncentivePremium4 EarlyIncentivePremiumValue)
        {
            writer.WriteStartElement(null, "EarlyIncntivPrm", xmlNamespace );
            EarlyIncentivePremiumValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncentivePremium is IncentivePremium4 IncentivePremiumValue)
        {
            writer.WriteStartElement(null, "IncntivPrm", xmlNamespace );
            IncentivePremiumValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarlyVoteWithPremiumDeadline is DateFormat58Choice_ EarlyVoteWithPremiumDeadlineValue)
        {
            writer.WriteStartElement(null, "EarlyVoteWthPrmDdln", xmlNamespace );
            EarlyVoteWithPremiumDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteWithPremiumDeadline is DateFormat58Choice_ VoteWithPremiumDeadlineValue)
        {
            writer.WriteStartElement(null, "VoteWthPrmDdln", xmlNamespace );
            VoteWithPremiumDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteWithPremiumMarketDeadline is DateFormat58Choice_ VoteWithPremiumMarketDeadlineValue)
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
        if (PreviousInstructionInvalidityIndicator is IsoYesNoIndicator PreviousInstructionInvalidityIndicatorValue)
        {
            writer.WriteStartElement(null, "PrvsInstrInvldtyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PreviousInstructionInvalidityIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static VoteParameters5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
