﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails100.  ISO2002 ID# _sUxoK5wyEeazcsnODTksnQ.
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
/// Specifies the details of the transaction.
/// </summary>
[IsoId("_sUxoK5wyEeazcsnODTksnQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transaction Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDetails100
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionDetails100 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionDetails100( SecuritiesAccount27 reqSafekeepingAccount,SecurityIdentification20 reqFinancialInstrumentIdentification,Quantity10Choice_ reqSettlementQuantity,SettlementDate15Choice_ reqSettlementDate,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment,SettlementDetails133 reqSettlementParameters )
    {
        SafekeepingAccount = reqSafekeepingAccount;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        SettlementQuantity = reqSettlementQuantity;
        SettlementDate = reqSettlementDate;
        SecuritiesMovementType = reqSecuritiesMovementType;
        Payment = reqPayment;
        SettlementParameters = reqSettlementParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_sUxoM5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeIdentification { get; init; } 
    #else
    public System.String? TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_sUxoN5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PoolIdentification { get; init; } 
    #else
    public System.String? PoolIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_sUxoO5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateActionEventIdentification { get; init; } 
    #else
    public System.String? CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    [IsoId("_sUxoP5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [IsoId("_sUxoQ5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ClientTripartyCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_sUxoR5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Collateral Instruction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientCollateralInstructionIdentification { get; init; } 
    #else
    public System.String? ClientCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_sUxoSZwyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_sUxoS5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification119? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification119? AccountOwner { get; init; } 
    #else
    public PartyIdentification119? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_sUxoT5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount27 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_sUxoU5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Place")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace2? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace2? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace2? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_sUxoV5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Trade")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_sUxoW5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Clearing")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    #else
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_sUxoX5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_sUxoY5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity10Choice_ SettlementQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Quantity10Choice_ SettlementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10Choice_ SettlementQuantity { get; init; } 
    #else
    public Quantity10Choice_ SettlementQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_sUxoZ5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection67? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection67? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection67? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_sUxoa5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Late Delivery Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? LateDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("_sUxob5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expected Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// For against payment transactions, the value date/time at which the Sender expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_sUxoc5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expected Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpectedValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_sUxod5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate15Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SettlementDate15Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate15Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate15Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_sUxoe5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate6Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate6Choice_? TradeDate { get; init; } 
    #else
    public TradeDate6Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_sUxof5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acknowledged Status Time Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? AcknowledgedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("_sUxogZwyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Matched Status Time Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MatchedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? MatchedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_sUxog5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Movement Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_sUxoh5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_sUxoi5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Parameters")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDetails133 SettlementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SettlementDetails133 SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails133 SettlementParameters { get; init; } 
    #else
    public SettlementDetails133 SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_sUxoj5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiving Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties49? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties49? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties49? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_sUxok5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivering Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties49? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties49? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties49? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_sUxol5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification110? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification110? Investor { get; init; } 
    #else
    public PartyIdentification110? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_sUxom5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Qualified Foreign Intermediary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification111? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification111? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentification111? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_sUxon5wyEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Instruction Processing Additional Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
