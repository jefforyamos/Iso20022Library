﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalEligibleBalanceFormat11.  ISO2002 ID# _plMAxzi7Eeydid5dcNPKvg.
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
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
[IsoId("_plMAxzi7Eeydid5dcNPKvg")]
[DisplayName("Total Eligible Balance Format")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalEligibleBalanceFormat11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_plMAyTi7Eeydid5dcNPKvg")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity80Choice_? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity80Choice_? Balance { get; init; } 
    #else
    public Quantity80Choice_? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_plMAyzi7Eeydid5dcNPKvg")]
    [DisplayName("Full Period Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullPrdUnits")]
    #endif
    [IsoXmlTag("FullPrdUnits")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat13? FullPeriodUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat13? FullPeriodUnits { get; init; } 
    #else
    public SignedQuantityFormat13? FullPeriodUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    [IsoId("_plMAzTi7Eeydid5dcNPKvg")]
    [DisplayName("Part Way Period Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PartWayPrdUnits")]
    #endif
    [IsoXmlTag("PartWayPrdUnits")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat13? PartWayPeriodUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat13? PartWayPeriodUnits { get; init; } 
    #else
    public SignedQuantityFormat13? PartWayPeriodUnits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
