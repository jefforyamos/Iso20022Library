﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _eIHT8dcZEeqRFcf2R4bPBw.
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
namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError10Choice
{
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_eIHT8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Business Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessReport : ReservationOrError10Choice_
    #else
    public partial class BusinessReport : ReservationOrError10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Report is given for a current reservation.
        /// </summary>
        [IsoId("_eJZtYdcZEeqRFcf2R4bPBw")]
        [DisplayName("Current Reservation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurRsvatn")]
        #endif
        [IsoXmlTag("CurRsvatn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReservationReport7? CurrentReservation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationReport7? CurrentReservation { get; init; } 
        #else
        public ReservationReport7? CurrentReservation { get; set; } 
        #endif
        
        /// <summary>
        /// Report is given for a default reservation.
        /// </summary>
        [IsoId("_eJZtY9cZEeqRFcf2R4bPBw")]
        [DisplayName("Default Reservation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DfltRsvatn")]
        #endif
        [IsoXmlTag("DfltRsvatn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReservationReport7? DefaultReservation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationReport7? DefaultReservation { get; init; } 
        #else
        public ReservationReport7? DefaultReservation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
