﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _SfeRItp-Ed-ak6NoX_4Aeg_-11928027.
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
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat2Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_SfeRItp-Ed-ak6NoX_4Aeg_-11928027")]
    [DisplayName("Proprietary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proprietary : SafekeepingPlaceFormat2Choice_
    #else
    public partial class Proprietary : SafekeepingPlaceFormat2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Proprietary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Proprietary( GenericIdentification20 reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P-Zbhtp-Ed-ak6NoX_4Aeg_-178701769")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification20 Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification20 Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification20 Type { get; init; } 
        #else
        public GenericIdentification20 Type { get; set; } 
        #endif
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
        /// </summary>
        [IsoId("_P-Zbh9p-Ed-ak6NoX_4Aeg_-1061935056")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Identification { get; init; } 
        #else
        public System.String? Identification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
