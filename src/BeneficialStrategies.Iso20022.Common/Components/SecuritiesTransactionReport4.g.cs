﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionReport4.  ISO2002 ID# _J-kCF4G-EeaalK9UbuVGFw.
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
/// Details of the securities transaction report.
/// </summary>
[IsoId("_J-kCF4G-EeaalK9UbuVGFw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Transaction Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTransactionReport4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTransactionReport4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTransactionReport4( System.String reqTransactionIdentification,System.String reqExecutingParty,System.String reqInvestmentPartyIndicator,System.String reqSubmittingParty,PartyIdentification79 reqBuyer,PartyIdentification79 reqSeller,SecuritiesTransactionTransmission2 reqOrderTransmission,SecuritiesTransaction1 reqTransaction,FinancialInstrumentAttributes3Choice_ reqFinancialInstrument,ExecutingParty1Choice_ reqExecutingPerson,SecuritiesTransactionIndicator2 reqAdditionalAttributes )
    {
        TransactionIdentification = reqTransactionIdentification;
        ExecutingParty = reqExecutingParty;
        InvestmentPartyIndicator = reqInvestmentPartyIndicator;
        SubmittingParty = reqSubmittingParty;
        Buyer = reqBuyer;
        Seller = reqSeller;
        OrderTransmission = reqOrderTransmission;
        Transaction = reqTransaction;
        FinancialInstrument = reqFinancialInstrument;
        ExecutingPerson = reqExecutingPerson;
        AdditionalAttributes = reqAdditionalAttributes;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_KJ36MYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity executing the transaction.
    /// </summary>
    [IsoId("_KJ36M4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Executing Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier ExecutingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExecutingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExecutingParty { get; init; } 
    #else
    public System.String ExecutingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the reporting party is defined as an investment firm under the local regulation or not.
    /// </summary>
    [IsoId("_KJ36NYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Party Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator InvestmentPartyIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String InvestmentPartyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestmentPartyIndicator { get; init; } 
    #else
    public System.String InvestmentPartyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Entity submitting the transaction report to the competent authority.
    /// </summary>
    [IsoId("_KJ36PYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitting Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier SubmittingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SubmittingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SubmittingParty { get; init; } 
    #else
    public System.String SubmittingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the acquirer of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_KJ36P4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification79 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification79 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification79 Buyer { get; init; } 
    #else
    public PartyIdentification79 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the seller of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_KJ36QYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification79 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification79 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification79 Seller { get; init; } 
    #else
    public PartyIdentification79 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    [IsoId("_KJ36Q4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Transmission")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
    #else
    public SecuritiesTransactionTransmission2 OrderTransmission { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [IsoId("_KJ36RYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransaction1 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesTransaction1 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransaction1 Transaction { get; init; } 
    #else
    public SecuritiesTransaction1 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_KJ36R4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentAttributes3Choice_ FinancialInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentAttributes3Choice_ FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes3Choice_ FinancialInstrument { get; init; } 
    #else
    public FinancialInstrumentAttributes3Choice_ FinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the person or algorithm which is responsible within the reporting party for the investment decision.
    /// </summary>
    [IsoId("_KJ36S4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Decision Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; } 
    #else
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person or algorithm responsible for the execution of the transaction.
    /// </summary>
    [IsoId("_KJ36TYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Executing Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExecutingParty1Choice_ ExecutingPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ExecutingParty1Choice_ ExecutingPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExecutingParty1Choice_ ExecutingPerson { get; init; } 
    #else
    public ExecutingParty1Choice_ ExecutingPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional indicators on the reported transaction.
    /// </summary>
    [IsoId("_KJ36T4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
    #else
    public SecuritiesTransactionIndicator2 AdditionalAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
    /// </summary>
    [IsoId("_KJ36UYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecordTechnicalData1? TechnicalAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecordTechnicalData1? TechnicalAttributes { get; init; } 
    #else
    public RecordTechnicalData1? TechnicalAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_KJ36U4G-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
