﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _MP5s45lgEeeE1Ya-LgRsuQ.
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
namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError5Choice
{
    /// <summary>
    /// Reports either on the business information or on a business error.
    /// </summary>
    [IsoId("_MP5s45lgEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Business Report")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessReport : GeneralBusinessOrError5Choice_
    #else
    public partial class BusinessReport : GeneralBusinessOrError5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BusinessReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BusinessReport( System.String reqBusinessInformationReference,GeneralBusinessOrError6Choice_ reqGeneralBusinessOrError )
        {
            BusinessInformationReference = reqBusinessInformationReference;
            GeneralBusinessOrError = reqGeneralBusinessOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
        /// </summary>
        [IsoId("_MYGmo5lgEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Business Information Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text BusinessInformationReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String BusinessInformationReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String BusinessInformationReference { get; init; } 
        #else
        public System.String BusinessInformationReference { get; set; } 
        #endif
        
        /// <summary>
        /// Requested business information.
        /// </summary>
        [IsoId("_MYGmpZlgEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("General Business Or Error")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
        #else
        public GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
