﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RentalDetails2.  ISO2002 ID# _Y2H6UcW1EeuhguwJmlgagQ.
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
/// Details of car rental service.
/// </summary>
[IsoId("_Y2H6UcW1EeuhguwJmlgagQ")]
[DisplayName("Rental Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RentalDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the car rental service.
    /// </summary>
    [IsoId("_Y6vUkcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlId")]
    #endif
    [IsoXmlTag("RntlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? RentalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RentalIdentification { get; init; } 
    #else
    public System.String? RentalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of registration of car rental service as  per folio.
    /// </summary>
    [IsoId("_Y6vUk8W1EeuhguwJmlgagQ")]
    [DisplayName("Rental Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlDtTm")]
    #endif
    [IsoXmlTag("RntlDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RentalDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RentalDateTime { get; init; } 
    #else
    public System.DateTime? RentalDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the vehicle at the start of the rental period.
    /// </summary>
    [IsoId("_Y6vUlcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlStart")]
    #endif
    [IsoXmlTag("RntlStart")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceStartEnd2? RentalStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceStartEnd2? RentalStart { get; init; } 
    #else
    public ServiceStartEnd2? RentalStart { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the vehicle at the end of the rental period.
    /// </summary>
    [IsoId("_Y6vUl8W1EeuhguwJmlgagQ")]
    [DisplayName("Rental Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlRtr")]
    #endif
    [IsoXmlTag("RntlRtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceStartEnd2? RentalReturn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceStartEnd2? RentalReturn { get; init; } 
    #else
    public ServiceStartEnd2? RentalReturn { get; set; } 
    #endif
    
    /// <summary>
    /// Time period for the whole duration of rental.
    /// </summary>
    [IsoId("_Y6vUmcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Time Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlTmPrd")]
    #endif
    [IsoXmlTag("RntlTmPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PeriodUnit2Code? RentalTimePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PeriodUnit2Code? RentalTimePeriod { get; init; } 
    #else
    public PeriodUnit2Code? RentalTimePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Time period expressed in a number of units (for example, 1 week, 3 days, etc.).
    /// </summary>
    [IsoId("_Y6vUm8W1EeuhguwJmlgagQ")]
    [DisplayName("Time Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmPrdUnit")]
    #endif
    [IsoXmlTag("TmPrdUnit")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? TimePeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimePeriodUnit { get; init; } 
    #else
    public System.String? TimePeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Rate for the time period.
    /// </summary>
    [IsoId("_Y6vUncW1EeuhguwJmlgagQ")]
    [DisplayName("Time Period Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmPrdRate")]
    #endif
    [IsoXmlTag("TmPrdRate")]
    [IsoSimpleType(IsoSimpleType.ImpliedCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? TimePeriodRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TimePeriodRate { get; init; } 
    #else
    public System.Decimal? TimePeriodRate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code applied for the rental.
    /// </summary>
    [IsoId("_Y6vUn8W1EeuhguwJmlgagQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
