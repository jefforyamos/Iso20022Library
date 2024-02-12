﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInstructedBalanceOptionInstructionDetailsSD1.  ISO2002 ID# _sIx_1pH9EeaNbfbSYshZYw.
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
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_sIx_1pH9EeaNbfbSYshZYw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Instructed Balance Option Instruction Details SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionInstructionDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionInstructionDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionInstructionDetailsSD1( System.String reqPlaceAndName,OptionNumber1Choice_ reqOptionNumber,System.String reqTransactionIdentification,System.DateTime reqTransactionIdentificationDate,FinancialInstrumentQuantity15Choice_ reqTransactionIdentificationQuantity,DTCInstructionStatus2Code reqTransactionIdentificationStatus )
    {
        PlaceAndName = reqPlaceAndName;
        OptionNumber = reqOptionNumber;
        TransactionIdentification = reqTransactionIdentification;
        TransactionIdentificationDate = reqTransactionIdentificationDate;
        TransactionIdentificationQuantity = reqTransactionIdentificationQuantity;
        TransactionIdentificationStatus = reqTransactionIdentificationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_sIx_2pH9EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place And Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_D1jXJJH-EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_VkuHlJH-EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_VkuHlZH-EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
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
    [IsoId("_VkuHlpH-EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime TransactionIdentificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransactionIdentificationDate { get; init; } 
    #else
    public System.DateTime TransactionIdentificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_gtfN8JINEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Contra CUSIP")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #else
    public OtherIdentification2? TransactionContraCUSIP { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_z6q0gZINEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_I9r7UJIOEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_SleU8JIOEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #else
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_ltwNYJIOEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Protect Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionIdentificationProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionIdentificationProtectDate { get; init; } 
    #else
    public System.DateTime? TransactionIdentificationProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the cover protect.
    /// </summary>
    [IsoId("_1DOikJIOEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification Cover Protect Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionIdentificationCoverProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionIdentificationCoverProtectDate { get; init; } 
    #else
    public System.DateTime? TransactionIdentificationCoverProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Conditional quantity on the instruction.
    /// </summary>
    [IsoId("_8FL3gJIQEeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Conditional Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Tender bid price of the instruction.
    /// </summary>
    [IsoId("_GBpgoJIREeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Tender Bid Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; } 
    #else
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_VkuHl5H-EeaNbfbSYshZYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Customer Reference Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
