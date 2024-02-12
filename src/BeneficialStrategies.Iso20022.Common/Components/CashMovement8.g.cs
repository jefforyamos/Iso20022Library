﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashMovement8.  ISO2002 ID# _rn_kOxIwEeydmIVkS03esw.
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
/// Movements of cash.
/// </summary>
[IsoId("_rn_kOxIwEeydmIVkS03esw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cash Movement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashMovement8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashMovement8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashMovement8( CollateralEntryType1Code reqCashMovement,System.Decimal reqCashAmount,System.String reqCollateralMovement )
    {
        CashMovement = reqCashMovement;
        CashAmount = reqCashAmount;
        CollateralMovement = reqCollateralMovement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the cash amount is to be delivered or received.
    /// </summary>
    [IsoId("_r-pJoRIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Movement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralEntryType1Code CashMovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralEntryType1Code CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralEntryType1Code CashMovement { get; init; } 
    #else
    public CollateralEntryType1Code CashMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the cash movement
    /// </summary>
    [IsoId("_r-pJoxIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal CashAmount { get; init; } 
    #else
    public System.Decimal CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_r-pJpRIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    [IsoId("_r-pJpxIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Movement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CollateralMovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CollateralMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralMovement { get; init; } 
    #else
    public System.String CollateralMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    [IsoId("_r-pJqRIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Cash Movement Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientCashMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientCashMovementIdentification { get; init; } 
    #else
    public System.String? ClientCashMovementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the triparty agent to the cash movement.
    /// </summary>
    [IsoId("_r-pJqxIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Triparty Agent Service Provider Cash Movement Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderCashMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCashMovementIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCashMovementIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
