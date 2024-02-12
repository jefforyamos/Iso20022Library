﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proxy.  ISO2002 ID# _kQJ7Ia09EemDtrWpq90Ckg.
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
namespace BeneficialStrategies.Iso20022.Choices.Proxy3Choice
{
    /// <summary>
    /// Proxy assignment and registration information.
    /// </summary>
    [IsoId("_kQJ7Ia09EemDtrWpq90Ckg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proxy")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proxy : Proxy3Choice_
    #else
    public partial class Proxy : Proxy3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies how to register the proxy.
        /// </summary>
        [IsoId("_kmLOc609EemDtrWpq90Ckg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Registration Method")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? RegistrationMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegistrationMethod { get; init; } 
        #else
        public System.String? RegistrationMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_kmLOda09EemDtrWpq90Ckg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Deadline")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateFormat58Choice_? Deadline { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateFormat58Choice_? Deadline { get; init; } 
        #else
        public DateFormat58Choice_? Deadline { get; set; } 
        #endif
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_kmLOea09EemDtrWpq90Ckg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Market Deadline")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateFormat58Choice_? MarketDeadline { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateFormat58Choice_? MarketDeadline { get; init; } 
        #else
        public DateFormat58Choice_? MarketDeadline { get; set; } 
        #endif
        
        /// <summary>
        /// Proxy person that is authorised by the issuer.
        /// </summary>
        [IsoId("_kmLOe609EemDtrWpq90Ckg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Authorised Proxy")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [MinLength(0)]
        [MaxLength(10)]
        #endif
        public ValueList<Proxy8> AuthorisedProxy { get; init; } = new ValueList<Proxy8>(){};
        
        
        #nullable disable
        
    }
}
