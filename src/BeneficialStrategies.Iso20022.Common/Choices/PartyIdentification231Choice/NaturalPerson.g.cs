﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NaturalPerson.  ISO2002 ID# _ow34o_Q0EeqAradXpAelDQ.
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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification231Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_ow34o_Q0EeqAradXpAelDQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Natural Person")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NaturalPerson : PartyIdentification231Choice_
    #else
    public partial class NaturalPerson : PartyIdentification231Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NaturalPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NaturalPerson( PersonName3 reqNameAndAddress,NaturalPersonIdentification1 reqIdentification )
        {
            NameAndAddress = reqNameAndAddress;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_pEXcYfQ0EeqAradXpAelDQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Name And Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PersonName3 NameAndAddress { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public PersonName3 NameAndAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PersonName3 NameAndAddress { get; init; } 
        #else
        public PersonName3 NameAndAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_pEXcY_Q0EeqAradXpAelDQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Email Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? EmailAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailAddress { get; init; } 
        #else
        public System.String? EmailAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Natural person local identification and type.
        /// </summary>
        [IsoId("_pEXcZfQ0EeqAradXpAelDQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NaturalPersonIdentification1 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public NaturalPersonIdentification1 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NaturalPersonIdentification1 Identification { get; init; } 
        #else
        public NaturalPersonIdentification1 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [IsoId("_894vEvQ1EeqAradXpAelDQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Nationality")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? Nationality { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? Nationality { get; init; } 
        #else
        public string? Nationality { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which and place at which a born person is born.
        /// </summary>
        [IsoId("_894vE_Q1EeqAradXpAelDQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Date And Place Of Birth")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
        #else
        public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
