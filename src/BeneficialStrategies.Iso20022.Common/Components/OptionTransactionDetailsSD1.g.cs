﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionTransactionDetailsSD1.  ISO2002 ID# _mi1bIJElEeajS_7NioJdVA.
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
/// Provides additional information regarding corporate action movement option details.
/// </summary>
[IsoId("_mi1bIJElEeajS_7NioJdVA")]
[DisplayName("Option Transaction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionTransactionDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionTransactionDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionTransactionDetailsSD1( System.String reqPlaceAndName,System.String reqTransactionIdentification,System.DateTime reqTransactionIdentificationDate,FinancialInstrumentQuantity15Choice_ reqTransactionIdentificationQuantity )
    {
        PlaceAndName = reqPlaceAndName;
        TransactionIdentification = reqTransactionIdentification;
        TransactionIdentificationDate = reqTransactionIdentificationDate;
        TransactionIdentificationQuantity = reqTransactionIdentificationQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_thTpIZElEeajS_7NioJdVA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_p-YfgJEmEeajS_7NioJdVA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_3iVzwJEmEeajS_7NioJdVA")]
    [DisplayName("Transaction Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqNb")]
    #endif
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSequenceNumber { get; init; } 
    #else
    public System.String? TransactionSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_OwnRMJEnEeajS_7NioJdVA")]
    [DisplayName("Transaction Identification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdDt")]
    #endif
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TransactionIdentificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransactionIdentificationDate { get; init; } 
    #else
    public System.DateTime TransactionIdentificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_2y-98JEnEeajS_7NioJdVA")]
    [DisplayName("Transaction Identification Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdQty")]
    #endif
    [IsoXmlTag("TxIdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_7ErnMJEoEeajS_7NioJdVA")]
    [DisplayName("Entitled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldAmt")]
    #endif
    [IsoXmlTag("EntitldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_6fTMwJEpEeajS_7NioJdVA")]
    [DisplayName("Entitled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldQty")]
    #endif
    [IsoXmlTag("EntitldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity entered by the Agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_LRKncJEqEeajS_7NioJdVA")]
    [DisplayName("Agent Entered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtNtrdQty")]
    #endif
    [IsoXmlTag("AgtNtrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity less the quantity entered by Agent on PUT (Mortgage Backed) instructions. Remaining unpaid quantity.
    /// </summary>
    [IsoId("_VVNfQJEqEeajS_7NioJdVA")]
    [DisplayName("Agent Remaining Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtRmngQty")]
    #endif
    [IsoXmlTag("AgtRmngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AgentRemainingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AgentRemainingQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AgentRemainingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_hOpycJEqEeajS_7NioJdVA")]
    [DisplayName("Customer Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRefId")]
    #endif
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
