﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrivateIdentification.  ISO2002 ID# _2uFgE-WkEeevU7McUP3D1w.
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
namespace BeneficialStrategies.Iso20022.Choices.Party36Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_2uFgE-WkEeevU7McUP3D1w")]
    [DisplayName("Private Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PrivateIdentification : Party36Choice_
    #else
    public partial class PrivateIdentification : Party36Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_pYxEw-WkEeevU7McUP3D1w")]
        [DisplayName("Date And Place Of Birth")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtAndPlcOfBirth")]
        #endif
        [IsoXmlTag("DtAndPlcOfBirth")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
        #else
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_pYxExeWkEeevU7McUP3D1w")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericPersonIdentification1? Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericPersonIdentification1? Other { get; init; } 
        #else
        public GenericPersonIdentification1? Other { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
