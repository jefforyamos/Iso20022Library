﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reservation.  ISO2002 ID# _RYRzgXhdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError9Choice
{
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_RYRzgXhdEeidzqjNEfehPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reservation")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reservation : ReservationOrError9Choice_
    #else
    public partial class Reservation : ReservationOrError9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reservation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reservation( Amount2Choice_ reqAmount )
        {
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of money of the limit, expressed in an eligible currency.
        /// </summary>
        [IsoId("_UFVtM5liEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public Amount2Choice_ Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_ Amount { get; init; } 
        #else
        public Amount2Choice_ Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Status of the limit, such as enabled or disabled.
        /// </summary>
        [IsoId("_UFVtNZliEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReservationStatus1Choice_? Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationStatus1Choice_? Status { get; init; } 
        #else
        public ReservationStatus1Choice_? Status { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the reservation becomes effective.
        /// </summary>
        [IsoId("_UFVtN5liEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Start Date Time")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #else
        public DateAndDateTime2Choice_? StartDateTime { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
