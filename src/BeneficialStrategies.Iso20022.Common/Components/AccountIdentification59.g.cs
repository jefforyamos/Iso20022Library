﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification59.  ISO2002 ID# _S53jnRuyEeyhRdHRjakS2w.
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
/// Provides account identification information.
/// </summary>
[IsoId("_S53jnRuyEeyhRdHRjakS2w")]
[DisplayName("Account Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountIdentification59
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountIdentification59 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountIdentification59( BalanceFormat11Choice_ reqConfirmedBalance )
    {
        ConfirmedBalance = reqConfirmedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_TO4KRRuyEeyhRdHRjakS2w")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SafekeepingAccount { get; init; } 
    #else
    public System.String? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_Vz_QUiLOEeyNSNrMl2zWxg")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockChainAddressOrWallet { get; init; } 
    #else
    public System.String? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_TO4KTRuyEeyhRdHRjakS2w")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification127Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_TO4KVRuyEeyhRdHRjakS2w")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_TO4KXRuyEeyhRdHRjakS2w")]
    [DisplayName("Confirmed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdBal")]
    #endif
    [IsoXmlTag("ConfdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat11Choice_ ConfirmedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat11Choice_ ConfirmedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat11Choice_ ConfirmedBalance { get; init; } 
    #else
    public BalanceFormat11Choice_ ConfirmedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
