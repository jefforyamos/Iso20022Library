﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _YxN_49LGEeiN28wlpBQScw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat5Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged, expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_YxN_49LGEeiN28wlpBQScw")]
    [DisplayName("Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Identification : PledgeeFormat5Choice_
    #else
    public partial class Identification : PledgeeFormat5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Identification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Identification( PledgeeType1Code reqPledgeeType )
        {
            PledgeeType = reqPledgeeType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Additional information about the entity to which the financial instruments are pledged.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Value { get; init; } 
        #else
        public System.String? Value { get; set; } 
        #endif
        
        /// <summary>
        /// Entity to which the financial instruments are pledged expressed as a code.
        /// </summary>
        [IsoId("_iSB9IE9gEeSn2-3swbRbzg")]
        [DisplayName("Pledgee Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PldgeeTp")]
        #endif
        [IsoXmlTag("PldgeeTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PledgeeType1Code PledgeeType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PledgeeType1Code PledgeeType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PledgeeType1Code PledgeeType { get; init; } 
        #else
        public PledgeeType1Code PledgeeType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
