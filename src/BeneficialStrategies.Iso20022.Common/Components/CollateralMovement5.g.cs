﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMovement5.  ISO2002 ID# _P0F1VV9-EeSMgPeFpRHeJw.
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
/// Provides the agreed amount and the collateral movement direction.
/// </summary>
[IsoId("_P0F1VV9-EeSMgPeFpRHeJw")]
[DisplayName("Collateral Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralMovement5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralMovement5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralMovement5( ActiveCurrencyAndAmount reqAgreedAmount )
    {
        AgreedAmount = reqAgreedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    [IsoId("_QQNJkV9-EeSMgPeFpRHeJw")]
    [DisplayName("Agreed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdAmt")]
    #endif
    [IsoXmlTag("AgrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount AgreedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    [IsoId("_QQNJk19-EeSMgPeFpRHeJw")]
    [DisplayName("Movement Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntDrctn")]
    #endif
    [IsoXmlTag("MvmntDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralMovement3Choice_? MovementDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMovement3Choice_? MovementDirection { get; init; } 
    #else
    public CollateralMovement3Choice_? MovementDirection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
