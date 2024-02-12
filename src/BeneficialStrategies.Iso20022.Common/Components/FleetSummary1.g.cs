﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetSummary1.  ISO2002 ID# _otojUPikEeiJaN6-Lf-c_w.
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
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_otojUPikEeiJaN6-Lf-c_w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Fleet Summary")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetSummary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    [IsoId("_otpKYPikEeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Driver")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Driver1? Driver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Driver1? Driver { get; init; } 
    #else
    public Driver1? Driver { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    [IsoId("_otpKYfikEeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vehicle")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle5? Vehicle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle5? Vehicle { get; init; } 
    #else
    public Vehicle5? Vehicle { get; set; } 
    #endif
    
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_8NRf8fixEeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Driver Or Vehicle Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData20? DriverOrVehicleCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData20? DriverOrVehicleCard { get; init; } 
    #else
    public PlainCardData20? DriverOrVehicleCard { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur. 
    /// </summary>
    [IsoId("_rK5AMPi1EeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Fuel Prompt Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? CardFuelPromptCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CardFuelPromptCode { get; init; } 
    #else
    public System.UInt64? CardFuelPromptCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currently known as "TransactionNumber". An identification code assigned by an agent.  This code can be used after applying for and awaiting the appropriate prompt value to be defined.
    /// </summary>
    [IsoId("_QdgiIPi2EeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent Fuel Prompt Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AgentFuelPromptCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentFuelPromptCode { get; init; } 
    #else
    public System.String? AgentFuelPromptCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details related to an individual trip. 
    /// </summary>
    [IsoId("_MfuEoPi7EeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trip Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TripInformation1? TripInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TripInformation1? TripInformation { get; init; } 
    #else
    public TripInformation1? TripInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_lowBwPi_EeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Amenity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalAmenity1? LocalAmenity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalAmenity1? LocalAmenity { get; init; } 
    #else
    public LocalAmenity1? LocalAmenity { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    [IsoId("_GVZhUPjEEeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Related Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction117? TransactionRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction117? TransactionRelatedData { get; init; } 
    #else
    public PaymentTransaction117? TransactionRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    [IsoId("_2LjFsPi_EeiJaN6-Lf-c_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation19? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation19? AdditionalData { get; init; } 
    #else
    public AdditionalInformation19? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
