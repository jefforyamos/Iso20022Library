﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionTransactionDetailsSD2.  ISO2002 ID# _cb3Su5FHEeanIpS4qvJ1tw.
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
[IsoId("_cb3Su5FHEeanIpS4qvJ1tw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Option Transaction Details SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionTransactionDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionTransactionDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionTransactionDetailsSD2( System.String reqPlaceAndName,System.String reqTransactionIdentification,System.DateTime reqTransactionIdentificationDate,FinancialInstrumentQuantity15Choice_ reqTransactionIdentificationQuantity )
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
    [IsoId("_cb3SxJFHEeanIpS4qvJ1tw")]
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
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_cb3Sw5FHEeanIpS4qvJ1tw")]
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
    [IsoId("_cb3SwJFHEeanIpS4qvJ1tw")]
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
    [IsoId("_cb3Sv5FHEeanIpS4qvJ1tw")]
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
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_cb3SvJFHEeanIpS4qvJ1tw")]
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
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    [IsoId("_uhizwJFJEeanIpS4qvJ1tw")]
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
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_F1LSUJFKEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accepted Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_TFM98JFKEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unaccepted Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_cb3SxZFHEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Entitled Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EntitledAmount { get; init; } 
    #else
    public System.Decimal? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_cb3SwpFHEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Entitled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    [IsoId("_CauvQJFLEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Entitled Oversubscription Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount to be refunded for oversubscribed shares not accepted by the issuer / agent.
    /// </summary>
    [IsoId("_cuR7kJFLEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Refunded Oversubscription Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? RefundedOversubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RefundedOversubscriptionAmount { get; init; } 
    #else
    public System.Decimal? RefundedOversubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    [IsoId("_mACa0JFLEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Subscription Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SubscriptionAmount { get; init; } 
    #else
    public System.Decimal? SubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    [IsoId("_41RbcJFLEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Oversubscription Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OversubscriptionAmount { get; init; } 
    #else
    public System.Decimal? OversubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Adjustment related to the difference between the estimated and final price for the subscription cost.
    /// </summary>
    [IsoId("_ITh5MJFMEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Final Subscription Adjustment Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? FinalSubscriptionAdjustmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FinalSubscriptionAdjustmentAmount { get; init; } 
    #else
    public System.Decimal? FinalSubscriptionAdjustmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_V6bzxJFMEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash In Lieu Of Share")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CashInLieuOfShare { get; init; } 
    #else
    public System.Decimal? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_cb3SwZFHEeanIpS4qvJ1tw")]
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
    
    /// <summary>
    /// Quantity entered by the Agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_cb3SvpFHEeanIpS4qvJ1tw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent Entered Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
