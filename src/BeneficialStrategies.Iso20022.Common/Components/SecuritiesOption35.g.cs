﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption35.  ISO2002 ID# _FwYg0ROCEeKyONjZVQUqzg.
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
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_FwYg0ROCEeKyONjZVQUqzg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Option")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption35
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption35 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption35( SecurityIdentification14 reqFinancialInstrumentIdentification,CreditDebitCode reqCreditDebitIndicator,Quantity6Choice_ reqPostingQuantity,SecurityDate6 reqDateDetails )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        CreditDebitIndicator = reqCreditDebitIndicator;
        PostingQuantity = reqPostingQuantity;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_GFspiROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_GFspkxOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Debit Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_GFspnROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Temporary Financial Instrument Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    #else
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_GFsppxOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Posting Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ PostingQuantity { get; init; } 
    #else
    public Quantity6Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_GFspsROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Place")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_GFspuxOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fraction Disposition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType23Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType23Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType23Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_GFspxROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Option")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOption { get; init; } 
    #else
    public string? CurrencyOption { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_GFspzxOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityDate6 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityDate6 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityDate6 DateDetails { get; init; } 
    #else
    public SecurityDate6 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_GFsp2ROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate29? RateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate29? RateDetails { get; init; } 
    #else
    public CorporateActionRate29? RateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_GFsp4xOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice39? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice39? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice39? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_GFsp7ROCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiving Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties24? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties24? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties24? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_GFsp9xOCEeKyONjZVQUqzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivering Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties24? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties24? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties24? DeliveringSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
