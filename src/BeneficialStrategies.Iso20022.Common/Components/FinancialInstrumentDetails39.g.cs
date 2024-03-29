﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails39.  ISO2002 ID# _2xktOyAeEeuyDZ-ukt4YRg.
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
/// Reporting per financial instrument.
/// </summary>
[IsoId("_2xktOyAeEeuyDZ-ukt4YRg")]
[DisplayName("Financial Instrument Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentDetails39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentDetails39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentDetails39( SecurityIdentification20 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_2xktPSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_2xktQSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndsFinInstrmAttrbts")]
    #endif
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument76? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument76? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrument76? InvestmentFundsFinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_2xktQyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation24? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation24? PriceDetails { get; init; } 
    #else
    public PriceInformation24? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_2xktRyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace4? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_2xktSyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngBal")]
    #endif
    [IsoXmlTag("OpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningBalance4? OpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningBalance4? OpeningBalance { get; init; } 
    #else
    public OpeningBalance4? OpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_2xktTyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgBal")]
    #endif
    [IsoXmlTag("ClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingBalance4? ClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingBalance4? ClosingBalance { get; init; } 
    #else
    public ClosingBalance4? ClosingBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_2xktUyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public ValueList<Transaction119> Transaction { get; init; } = new ValueList<Transaction119>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2xktUyAeEeuyDZ-ukt4YRg
    
    
    #nullable disable
    
}
