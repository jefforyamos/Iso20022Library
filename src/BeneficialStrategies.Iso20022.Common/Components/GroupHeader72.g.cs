﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader72.  ISO2002 ID# _lnRSeTq3EeWZFYSPlduMhw.
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
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_lnRSeTq3EeWZFYSPlduMhw")]
[DisplayName("Group Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GroupHeader72
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GroupHeader72 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GroupHeader72( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,System.String reqNumberOfTransactions,SettlementInstruction4 reqSettlementInformation )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        NumberOfTransactions = reqNumberOfTransactions;
        SettlementInformation = reqSettlementInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party and sent to the next party in the chain, to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_lunQhzq3EeWZFYSPlduMhw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_lunQiTq3EeWZFYSPlduMhw")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_lunQizq3EeWZFYSPlduMhw")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = new ValueList<Authorisation1Choice_>(){};
    
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_lunQjTq3EeWZFYSPlduMhw")]
    [DisplayName("Batch Booking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchBookg")]
    #endif
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchBooking { get; init; } 
    #else
    public System.String? BatchBooking { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_lunQjzq3EeWZFYSPlduMhw")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText NumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfTransactions { get; init; } 
    #else
    public System.String NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_lunQkTq3EeWZFYSPlduMhw")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the return applies to the whole group of transactions or to individual transactions within the original group(s).
    /// </summary>
    [IsoId("_lunQkzq3EeWZFYSPlduMhw")]
    [DisplayName("Group Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpRtr")]
    #endif
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? GroupReturn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GroupReturn { get; init; } 
    #else
    public System.String? GroupReturn { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent in the return message.
    /// </summary>
    [IsoId("_lunQlTq3EeWZFYSPlduMhw")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRtrdIntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalReturnedInterbankSettlementAmount { get; init; } 
    #else
    public System.Decimal? TotalReturnedInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_lunQlzq3EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_lunQmTq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInf")]
    #endif
    [IsoXmlTag("SttlmInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInstruction4 SettlementInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInstruction4 SettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInstruction4 SettlementInformation { get; init; } 
    #else
    public SettlementInstruction4 SettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).|Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_lunQmzq3EeWZFYSPlduMhw")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).|Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_lunQnTq3EeWZFYSPlduMhw")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
