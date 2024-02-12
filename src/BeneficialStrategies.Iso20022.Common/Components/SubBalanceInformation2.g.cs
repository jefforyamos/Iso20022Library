﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation2.  ISO2002 ID# _QY60U9p-Ed-ak6NoX_4Aeg_-1856391421.
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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QY60U9p-Ed-ak6NoX_4Aeg_-1856391421")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Sub Balance Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubBalanceInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubBalanceInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubBalanceInformation2( SubBalanceQuantity1Choice_ reqQuantity,SecuritiesBalanceType1Code reqSubBalanceType,System.String reqExtendedSubBalanceType )
    {
        Quantity = reqQuantity;
        SubBalanceType = reqSubBalanceType;
        ExtendedSubBalanceType = reqExtendedSubBalanceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QY60VNp-Ed-ak6NoX_4Aeg_-1856391403")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #else
    public SubBalanceQuantity1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_QY60Vdp-Ed-ak6NoX_4Aeg_-1856391386")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Balance Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType1Code SubBalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesBalanceType1Code SubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType1Code SubBalanceType { get; init; } 
    #else
    public SecuritiesBalanceType1Code SubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QY60Vtp-Ed-ak6NoX_4Aeg_-1044552916")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extended Sub Balance Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedSubBalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExtendedSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedSubBalanceType { get; init; } 
    #else
    public System.String ExtendedSubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_QY60V9p-Ed-ak6NoX_4Aeg_-1856391341")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Balance Breakdown Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
