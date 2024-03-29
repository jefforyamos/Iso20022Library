﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyAccount3.  ISO2002 ID# _JSd9kU7NEeyGi9JAv6wq7Q.
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
/// Loyalty Account description.
/// </summary>
[IsoId("_JSd9kU7NEeyGi9JAv6wq7Q")]
[DisplayName("Loyalty Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyAccount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoyaltyAccount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoyaltyAccount3( System.String reqLoyaltyIdentification )
    {
        LoyaltyIdentification = reqLoyaltyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of Loyalty Account.
    /// </summary>
    [IsoId("_JY9AEU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Loyalty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyId")]
    #endif
    [IsoXmlTag("LltyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LoyaltyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LoyaltyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LoyaltyIdentification { get; init; } 
    #else
    public System.String LoyaltyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Standard or last entry mode to access the Loyalty account or card.
    /// </summary>
    [IsoId("_JY9AE07NEeyGi9JAv6wq7Q")]
    [DisplayName("Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryMd")]
    #endif
    [IsoXmlTag("NtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? EntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? EntryMode { get; init; } 
    #else
    public CardDataReading8Code? EntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identification for this Loyalty Account.
    /// </summary>
    [IsoId("_JY9AFU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardIdentificationType1Code? IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardIdentificationType1Code? IdentificationType { get; init; } 
    #else
    public CardIdentificationType1Code? IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_JY9AF07NEeyGi9JAv6wq7Q")]
    [DisplayName("Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnd")]
    #endif
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Brand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Brand { get; init; } 
    #else
    public System.String? Brand { get; set; } 
    #endif
    
    /// <summary>
    /// Provider of the Loyalty Account.
    /// </summary>
    [IsoId("_JY9AGU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Provider { get; init; } 
    #else
    public System.String? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_JY9AG07NEeyGi9JAv6wq7Q")]
    [DisplayName("Owner Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrNm")]
    #endif
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax45Text? OwnerName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OwnerName { get; init; } 
    #else
    public System.String? OwnerName { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of a Loyalty Account (Point or Currency).
    /// </summary>
    [IsoId("_JY9AHU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountUnit1Code? Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountUnit1Code? Unit { get; init; } 
    #else
    public AmountUnit1Code? Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of a Loyalty Account if any.
    /// </summary>
    [IsoId("_JY9AH07NEeyGi9JAv6wq7Q")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of a Loyalty Account.
    /// </summary>
    [IsoId("_JY9AIU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Balance { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Balance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
