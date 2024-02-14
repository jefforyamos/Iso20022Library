﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedCorporateActionOption17.  ISO2002 ID# _JT5iHxn1EeyroI8qKgB7Mg.
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
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_JT5iHxn1EeyroI8qKgB7Mg")]
[DisplayName("Instructed Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedCorporateActionOption17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedCorporateActionOption17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedCorporateActionOption17( CorporateActionOption30Choice_ reqOptionType,BalanceFormat11Choice_ reqInstructedBalance,CorporateActionEventDeadlines3 reqEventDeadlines )
    {
        OptionType = reqOptionType;
        InstructedBalance = reqInstructedBalance;
        EventDeadlines = reqEventDeadlines;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_Jo6IwRn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_Jo6IyRn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption30Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption30Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption30Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption30Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_Jo6I0Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat11Choice_ InstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat11Choice_ InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat11Choice_ InstructedBalance { get; init; } 
    #else
    public BalanceFormat11Choice_ InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_Jo6I2Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Default Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltActn")]
    #endif
    [IsoXmlTag("DfltActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #else
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_Jo6I4Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Accepted Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAccptdInstdBal")]
    #endif
    [IsoXmlTag("OptnAccptdInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I4xn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Cancelled Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnCancInstrBal")]
    #endif
    [IsoXmlTag("OptnCancInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    [IsoId("_Jo6I5Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Pending Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPdgInstrBal")]
    #endif
    [IsoXmlTag("OptnPdgInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I5xn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Rejected Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnRjctdInstrBal")]
    #endif
    [IsoXmlTag("OptnRjctdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I6Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Protect Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPrtctInstrBal")]
    #endif
    [IsoXmlTag("OptnPrtctInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_Jo6I6xn1EeyroI8qKgB7Mg")]
    [DisplayName("Event Deadlines")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDdlns")]
    #endif
    [IsoXmlTag("EvtDdlns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #else
    public CorporateActionEventDeadlines3 EventDeadlines { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_Jo6I7Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnInstrDtls")]
    #endif
    [IsoXmlTag("OptnInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionInstructionDetails7? OptionInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionInstructionDetails7? OptionInstructionDetails { get; init; } 
    #else
    public OptionInstructionDetails7? OptionInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
