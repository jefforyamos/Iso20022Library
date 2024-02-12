﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationReport5.  ISO2002 ID# _Tr4EV5liEeeE1Ya-LgRsuQ.
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
/// Reports either on the reservation or on a business error.
/// </summary>
[IsoId("_Tr4EV5liEeeE1Ya-LgRsuQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Reservation Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReservationReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReservationReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReservationReport5( ReservationIdentification1 reqReservationIdentification,ReservationOrError7Choice_ reqReservationOrError )
    {
        ReservationIdentification = reqReservationIdentification;
        ReservationOrError = reqReservationOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [IsoId("_T0LEs5liEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reservation Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationIdentification1 ReservationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReservationIdentification1 ReservationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationIdentification1 ReservationIdentification { get; init; } 
    #else
    public ReservationIdentification1 ReservationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_T0LEtZliEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reservation Or Error")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationOrError7Choice_ ReservationOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReservationOrError7Choice_ ReservationOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationOrError7Choice_ ReservationOrError { get; init; } 
    #else
    public ReservationOrError7Choice_ ReservationOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
