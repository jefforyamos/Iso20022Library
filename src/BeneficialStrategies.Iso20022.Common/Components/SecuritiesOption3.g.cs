﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption3.  ISO2002 ID# _UHL119p-Ed-ak6NoX_4Aeg_-1087035337.
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
[IsoId("_UHL119p-Ed-ak6NoX_4Aeg_-1087035337")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Option")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption3( SecurityIdentification11 reqSecurityIdentification,CreditDebitCode reqCreditDebitIndicator,Quantity6Choice_ reqPostingQuantity,SecurityDate1 reqDateDetails )
    {
        SecurityIdentification = reqSecurityIdentification;
        CreditDebitIndicator = reqCreditDebitIndicator;
        PostingQuantity = reqPostingQuantity;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UHL12Np-Ed-ak6NoX_4Aeg_-1087035306")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_UHL12dp-Ed-ak6NoX_4Aeg_-1086114873")]
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
    [IsoId("_UHL12tp-Ed-ak6NoX_4Aeg_-1086114843")]
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
    [IsoId("_UHL129p-Ed-ak6NoX_4Aeg_571731726")]
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
    [IsoId("_UHL13Np-Ed-ak6NoX_4Aeg_1058428119")]
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
    [IsoId("_UHL13dp-Ed-ak6NoX_4Aeg_-1086114813")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fraction Disposition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType4Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType4Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType4Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_UHVm0Np-Ed-ak6NoX_4Aeg_1342278860")]
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
    [IsoId("_UHVm0dp-Ed-ak6NoX_4Aeg_-220473876")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityDate1 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityDate1 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityDate1 DateDetails { get; init; } 
    #else
    public SecurityDate1 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_UHVm0tp-Ed-ak6NoX_4Aeg_2141373299")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate6? RateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate6? RateDetails { get; init; } 
    #else
    public CorporateActionRate6? RateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_UHVm09p-Ed-ak6NoX_4Aeg_419678953")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice9? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice9? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice9? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_UHVm1Np-Ed-ak6NoX_4Aeg_-995838969")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiving Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties4? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties4? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties4? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_UHVm1dp-Ed-ak6NoX_4Aeg_-1883343031")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivering Settlement Parties")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties4? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties4? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties4? DeliveringSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
