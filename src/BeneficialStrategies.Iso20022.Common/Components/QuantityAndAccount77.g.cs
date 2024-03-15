﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount77.  ISO2002 ID# _Ycb_p9LCEeiN28wlpBQScw.
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
/// Details on a quantity, account and other related information.
/// </summary>
[IsoId("_Ycb_p9LCEeiN28wlpBQScw")]
[DisplayName("Quantity And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityAndAccount77
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuantityAndAccount77 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuantityAndAccount77( Quantity6Choice_ reqSettledQuantity,SecuritiesAccount19 reqSafekeepingAccount )
    {
        SettledQuantity = reqSettledQuantity;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_Yt_pm9LCEeiN28wlpBQScw")]
    [DisplayName("Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldQty")]
    #endif
    [IsoXmlTag("SttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ SettledQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ SettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ SettledQuantity { get; init; } 
    #else
    public Quantity6Choice_ SettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_Yt_po9LCEeiN28wlpBQScw")]
    [DisplayName("Previously Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySttldQty")]
    #endif
    [IsoXmlTag("PrevslySttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_Yt_pq9LCEeiN28wlpBQScw")]
    [DisplayName("Remaining To Be Settled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngToBeSttldQty")]
    #endif
    [IsoXmlTag("RmngToBeSttldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_Yt_ps9LCEeiN28wlpBQScw")]
    [DisplayName("Previously Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySttldAmt")]
    #endif
    [IsoXmlTag("PrevslySttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection52? PreviouslySettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection52? PreviouslySettledAmount { get; init; } 
    #else
    public AmountAndDirection52? PreviouslySettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_Yt_pu9LCEeiN28wlpBQScw")]
    [DisplayName("Remaining To Be Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngToBeSttldAmt")]
    #endif
    [IsoXmlTag("RmngToBeSttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection52? RemainingToBeSettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection52? RemainingToBeSettledAmount { get; init; } 
    #else
    public AmountAndDirection52? RemainingToBeSettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_Yt_pw9LCEeiN28wlpBQScw")]
    [DisplayName("Denomination Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnChc")]
    #endif
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? DenominationChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DenominationChoice { get; init; } 
    #else
    public System.String? DenominationChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Yt_py9LCEeiN28wlpBQScw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification144? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification144? AccountOwner { get; init; } 
    #else
    public PartyIdentification144? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Yt_p09LCEeiN28wlpBQScw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Yt_p29LCEeiN28wlpBQScw")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_Yt_p49LCEeiN28wlpBQScw")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown47? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown47? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown47? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Yt_p69LCEeiN28wlpBQScw")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace3? SafekeepingPlace { get; set; } 
    #endif
    
    
    #nullable disable
    
}
