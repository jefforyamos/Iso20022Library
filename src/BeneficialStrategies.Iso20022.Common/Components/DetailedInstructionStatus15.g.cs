﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus15.  ISO2002 ID# _l2hzAfNmEeqRfth943bvEA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Information about a meeting instruction vote.
/// </summary>
[IsoId("_l2hzAfNmEeqRfth943bvEA")]
[DisplayName("Detailed Instruction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedInstructionStatus15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedInstructionStatus15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedInstructionStatus15( System.String reqSingleInstructionIdentification,ModalityOfCounting1Choice_ reqModalityOfCounting )
    {
        SingleInstructionIdentification = reqSingleInstructionIdentification;
        ModalityOfCounting = reqModalityOfCounting;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message for which the confirmation is provided.
    /// </summary>
    [IsoId("_mKeCt_NmEeqRfth943bvEA")]
    [DisplayName("Single Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnglInstrId")]
    #endif
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SingleInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SingleInstructionIdentification { get; init; } 
    #else
    public System.String SingleInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the safekeeping account.
    /// </summary>
    [IsoId("_mKeCufNmEeqRfth943bvEA")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_mKeCu_NmEeqRfth943bvEA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification231Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_mKeCvfNmEeqRfth943bvEA")]
    [DisplayName("Sub Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctId")]
    #endif
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubAccountIdentification { get; init; } 
    #else
    public System.String? SubAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_mKeCv_NmEeqRfth943bvEA")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification233Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification233Choice_>(){};
    
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_mKeCwfNmEeqRfth943bvEA")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232Choice_? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232Choice_? Proxy { get; init; } 
    #else
    public PartyIdentification232Choice_? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_mKeCw_NmEeqRfth943bvEA")]
    [DisplayName("Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstr")]
    #endif
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandingInstruction { get; init; } 
    #else
    public System.String? StandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Modality through which the votes that have been recorded and counted were received by the issuer, including whether this is ahead of the meeting or at the meeting.
    /// </summary>
    [IsoId("_mKeCxfNmEeqRfth943bvEA")]
    [DisplayName("Modality Of Counting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModltyOfCntg")]
    #endif
    [IsoXmlTag("ModltyOfCntg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    #else
    public ModalityOfCounting1Choice_ ModalityOfCounting { get; set; } 
    #endif
    
    /// <summary>
    /// Date or date and time at which the votes that have been recorded and counted were received.
    /// </summary>
    [IsoId("_mKeCx_NmEeqRfth943bvEA")]
    [DisplayName("Vote Receipt Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteRctDtTm")]
    #endif
    [IsoXmlTag("VoteRctDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; } 
    #else
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_mKeCyfNmEeqRfth943bvEA")]
    [DisplayName("Vote Per Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VotePerRsltn")]
    #endif
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Vote13> VotePerResolution { get; init; } = new ValueList<Vote13>(){};
    
    
    #nullable disable
    
}
