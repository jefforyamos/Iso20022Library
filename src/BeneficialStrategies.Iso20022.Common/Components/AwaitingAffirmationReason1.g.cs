﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AwaitingAffirmationReason1.  ISO2002 ID# _A6MM09okEeC60axPepSq7g_-1610048646.
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
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_A6MM09okEeC60axPepSq7g_-1610048646")]
[DisplayName("Awaiting Affirmation Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AwaitingAffirmationReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AwaitingAffirmationReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AwaitingAffirmationReason1( AwaitingAffirmationReason1Choice_ reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the trade is wainting the affirmation.
    /// </summary>
    [IsoId("_A6MM1NokEeC60axPepSq7g_-1723887712")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AwaitingAffirmationReason1Choice_ Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AwaitingAffirmationReason1Choice_ Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AwaitingAffirmationReason1Choice_ Code { get; init; } 
    #else
    public AwaitingAffirmationReason1Choice_ Code { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A6MM1dokEeC60axPepSq7g_1687846297")]
    [DisplayName("Additional Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsnInf")]
    #endif
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
