﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteParameters4.  ISO2002 ID# _yqy18VuCEeSmO6RkXg92Lg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing how the voting process is organised.
/// </summary>
[IsoId("_yqy18VuCEeSmO6RkXg92Lg")]
[DisplayName("Vote Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteParameters4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteParameters4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteParameters4( System.String reqPartialVoteAllowed,System.String reqSplitVoteAllowed,System.String reqBeneficialOwnerDisclosure )
    {
        PartialVoteAllowed = reqPartialVoteAllowed;
        SplitVoteAllowed = reqSplitVoteAllowed;
        BeneficialOwnerDisclosure = reqBeneficialOwnerDisclosure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_zHgnI1uCEeSmO6RkXg92Lg")]
    [DisplayName("Securities Quantity Required To Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyReqrdToVote")]
    #endif
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? SecuritiesQuantityRequiredToVote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SecuritiesQuantityRequiredToVote { get; init; } 
    #else
    public System.UInt64? SecuritiesQuantityRequiredToVote { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is allowed to only vote on a part of the entire holding, leaving part of the position un-voted.
    /// </summary>
    [IsoId("_zHgnJVuCEeSmO6RkXg92Lg")]
    [DisplayName("Partial Vote Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlVoteAllwd")]
    #endif
    [IsoXmlTag("PrtlVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartialVoteAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartialVoteAllowed { get; init; } 
    #else
    public System.String PartialVoteAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is allowed to vote in different directions for the entire holding.
    /// </summary>
    [IsoId("_zHgnJ1uCEeSmO6RkXg92Lg")]
    [DisplayName("Split Vote Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltVoteAllwd")]
    #endif
    [IsoXmlTag("SpltVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SplitVoteAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SplitVoteAllowed { get; init; } 
    #else
    public System.String SplitVoteAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_zHgnKVuCEeSmO6RkXg92Lg")]
    [DisplayName("Vote Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDdln")]
    #endif
    [IsoXmlTag("VoteDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary (STP mode).
    /// </summary>
    [IsoId("_zHgnK1uCEeSmO6RkXg92Lg")]
    [DisplayName("Vote STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteSTPDdln")]
    #endif
    [IsoXmlTag("VoteSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_zHgnLVuCEeSmO6RkXg92Lg")]
    [DisplayName("Vote Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMktDdln")]
    #endif
    [IsoXmlTag("VoteMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the different methods that can be used to vote.
    /// </summary>
    [IsoId("_zHgnL1uCEeSmO6RkXg92Lg")]
    [DisplayName("Vote Methods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMthds")]
    #endif
    [IsoXmlTag("VoteMthds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteMethods2? VoteMethods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteMethods2? VoteMethods { get; init; } 
    #else
    public VoteMethods2? VoteMethods { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_zHgnMVuCEeSmO6RkXg92Lg")]
    [DisplayName("Voting Ballot Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngBlltElctrncAdr")]
    #endif
    [IsoXmlTag("VtngBlltElctrncAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    #else
    public CommunicationAddress4? VotingBallotElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_zHgnM1uCEeSmO6RkXg92Lg")]
    [DisplayName("Voting Ballot Request Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngBlltReqAdr")]
    #endif
    [IsoXmlTag("VtngBlltReqAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    #else
    public PostalAddress1? VotingBallotRequestAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_zHgnNVuCEeSmO6RkXg92Lg")]
    [DisplayName("Revocability Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyDdln")]
    #endif
    [IsoXmlTag("RvcbltyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RevocabilityDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RevocabilityDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RevocabilityDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_zHgnN1uCEeSmO6RkXg92Lg")]
    [DisplayName("Revocability STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltySTPDdln")]
    #endif
    [IsoXmlTag("RvcbltySTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RevocabilitySTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RevocabilitySTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RevocabilitySTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_zHgnOVuCEeSmO6RkXg92Lg")]
    [DisplayName("Revocability Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyMktDdln")]
    #endif
    [IsoXmlTag("RvcbltyMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RevocabilityMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RevocabilityMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RevocabilityMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    [IsoId("_zHgnO1uCEeSmO6RkXg92Lg")]
    [DisplayName("Beneficial Owner Disclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrDsclsr")]
    #endif
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficialOwnerDisclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficialOwnerDisclosure { get; init; } 
    #else
    public System.String BeneficialOwnerDisclosure { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the possible types of voting instructions. When used at the resolution level, it supersedes the value specified in the meeting notice.
    /// </summary>
    [IsoId("_zHgnPVuCEeSmO6RkXg92Lg")]
    [DisplayName("Vote Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrTp")]
    #endif
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = new SimpleValueList<VoteInstruction2Code>(){};
    
    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with premium deadline).
    /// </summary>
    [IsoId("_IG9nIFuEEeSmO6RkXg92Lg")]
    [DisplayName("Early Incentive Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyIncntivPrm")]
    #endif
    [IsoXmlTag("EarlyIncntivPrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncentivePremium3? EarlyIncentivePremium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremium3? EarlyIncentivePremium { get; init; } 
    #else
    public IncentivePremium3? EarlyIncentivePremium { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_zHgnP1uCEeSmO6RkXg92Lg")]
    [DisplayName("Incentive Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncntivPrm")]
    #endif
    [IsoXmlTag("IncntivPrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncentivePremium3? IncentivePremium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremium3? IncentivePremium { get; init; } 
    #else
    public IncentivePremium3? IncentivePremium { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    [IsoId("_73mR0FuEEeSmO6RkXg92Lg")]
    [DisplayName("Early Vote With Premium Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyVoteWthPrmDdln")]
    #endif
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    #else
    public DateFormat29Choice_? EarlyVoteWithPremiumDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_zHgnQVuCEeSmO6RkXg92Lg")]
    [DisplayName("Vote With Premium Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteWithPremiumDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteWithPremiumDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteWithPremiumDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium (STP mode).
    /// </summary>
    [IsoId("_zHgnQ1uCEeSmO6RkXg92Lg")]
    [DisplayName("Vote With Premium STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmSTPDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteWithPremiumSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_zHgnRVuCEeSmO6RkXg92Lg")]
    [DisplayName("Vote With Premium Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmMktDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? VoteWithPremiumMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_zHgnR1uCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Voting Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlVtngRqrmnts")]
    #endif
    [IsoXmlTag("AddtlVtngRqrmnts")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalVotingRequirements { get; init; } 
    #else
    public System.String? AdditionalVotingRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    [IsoId("_j5p3cF6kEeSyc4g_pm5hbw")]
    [DisplayName("Previous Instruction Invalidity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstrInvldtyInd")]
    #endif
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousInstructionInvalidityIndicator { get; init; } 
    #else
    public System.String? PreviousInstructionInvalidityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
