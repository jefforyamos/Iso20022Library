﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification17.  ISO2002 ID# _K2B0F-aOEd-q8fx_Zl_34A.
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
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_K2B0F-aOEd-q8fx_Zl_34A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Sub Account Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubAccountIdentification17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubAccountIdentification17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubAccountIdentification17( SecuritiesAccount14 reqSafekeepingAccount,System.String reqActivityIndicator )
    {
        SafekeepingAccount = reqSafekeepingAccount;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_K2B0GeaOEd-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification36Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_K2B0G-aOEd-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount14 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount14 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount14 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount14 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_K2B0HeaOEd-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Activity Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    [IsoId("_K2B0H-aOEd-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance For Sub Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation12? BalanceForSubAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation12? BalanceForSubAccount { get; init; } 
    #else
    public AggregateBalanceInformation12? BalanceForSubAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
