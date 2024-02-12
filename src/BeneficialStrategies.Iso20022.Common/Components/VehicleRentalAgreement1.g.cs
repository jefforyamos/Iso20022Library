﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VehicleRentalAgreement1.  ISO2002 ID# _R4nhWvSwEeife6veM7daYw.
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
/// Agreement (contract) related to a vehicle rental service.
/// </summary>
[IsoId("_R4nhWvSwEeife6veM7daYw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Vehicle Rental Agreement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalAgreement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the original vehicle rental agreement, invoice or contract number.
    /// </summary>
    [IsoId("_R4nhYfSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreement Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AgreementNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgreementNumber { get; init; } 
    #else
    public System.String? AgreementNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_R4nhXvSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Adjusted Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdjustedIndicator { get; init; } 
    #else
    public System.String? AdjustedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the vehicle rental location. 
    /// </summary>
    [IsoId("_R4nhW_SwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rental Location")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? RentalLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? RentalLocation { get; init; } 
    #else
    public Address1? RentalLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Used when different than rental location
    /// </summary>
    [IsoId("_R4nhZ_SwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pickup Location")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? PickupLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? PickupLocation { get; init; } 
    #else
    public Address1? PickupLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_R4nhYPSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Check Out Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckOutDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckOutDate { get; init; } 
    #else
    public System.DateOnly? CheckOutDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_R4nhZvSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Check Out Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? CheckOutTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? CheckOutTime { get; init; } 
    #else
    public System.TimeOnly? CheckOutTime { get; set; } 
    #endif
    
    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_R4nhbfSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Return Location")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? ReturnLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? ReturnLocation { get; init; } 
    #else
    public Address1? ReturnLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_R4nhX_SwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Check In Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckInDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckInDate { get; init; } 
    #else
    public System.DateOnly? CheckInDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_R4nhbPSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Check In Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? CheckInTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? CheckInTime { get; init; } 
    #else
    public System.TimeOnly? CheckInTime { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_R4nhaPSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Duration")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Duration { get; init; } 
    #else
    public System.String? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the vehicle classification.
    /// </summary>
    [IsoId("_F5fqkPS1Eeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vehicle Class Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle4? VehicleClassDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle4? VehicleClassDetails { get; init; } 
    #else
    public Vehicle4? VehicleClassDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_R4nhZfSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Travel Distance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Distance1? TravelDistance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Distance1? TravelDistance { get; init; } 
    #else
    public Distance1? TravelDistance { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle rental rate.
    /// </summary>
    [IsoId("_R4nha_SwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rental Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RentalRate1? RentalRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RentalRate1? RentalRate { get; init; } 
    #else
    public RentalRate1? RentalRate { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle rental details.
    /// </summary>
    [IsoId("_R4nhcfSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rental Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RentalDetails1? RentalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RentalDetails1? RentalDetails { get; init; } 
    #else
    public RentalDetails1? RentalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_R4nhbvSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vehicle Registration Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? VehicleRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleRegistrationNumber { get; init; } 
    #else
    public System.String? VehicleRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_--XHofS4Eeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Insurance Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type. 
    /// </summary>
    [IsoId("_R4nhb_SwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount9? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount9? AdditionalAmount { get; init; } 
    #else
    public Amount9? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_R4nhXPSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Estimated Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? EstimatedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? EstimatedTax { get; init; } 
    #else
    public Tax33? EstimatedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Discount applied to the vehicle rental.
    /// </summary>
    [IsoId("_R4nhYvSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Discount Programme")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Discount3? DiscountProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Discount3? DiscountProgramme { get; init; } 
    #else
    public Discount3? DiscountProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_R4nhXfSwEeife6veM7daYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Loyalty Programme")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme1? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme1? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme1? LoyaltyProgramme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
