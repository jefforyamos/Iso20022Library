﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IdentificationAsDSS.  ISO2002 ID# _RB5f5tp-Ed-ak6NoX_4Aeg_-292430851.
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
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormatChoice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_RB5f5tp-Ed-ak6NoX_4Aeg_-292430851")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification As DSS")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IdentificationAsDSS : SafekeepingPlaceFormatChoice_
    #else
    public partial class IdentificationAsDSS : SafekeepingPlaceFormatChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IdentificationAsDSS instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IdentificationAsDSS( System.String reqIssuer,System.String reqInformation )
        {
            Issuer = reqIssuer;
            Information = reqInformation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_b9Wtp-Ed-ak6NoX_4Aeg_691069232")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Issuer")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax8Text Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_b9W9p-Ed-ak6NoX_4Aeg_691068172")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Information")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 0 ,MinimumLength = 0)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact4AlphaNumericText Information { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Information { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Information { get; init; } 
        #else
        public System.String Information { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information.
        /// </summary>
        [IsoId("_P_luUNp-Ed-ak6NoX_4Aeg_691069664")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Narrative")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Narrative { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Narrative { get; init; } 
        #else
        public System.String? Narrative { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
