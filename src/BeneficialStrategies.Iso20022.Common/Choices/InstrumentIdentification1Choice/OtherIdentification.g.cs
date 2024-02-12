﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherIdentification.  ISO2002 ID# _AmCO0QbTEeqrW7Meu5r3kQ.
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
namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification1Choice
{
    /// <summary>
    /// Other identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_AmCO0QbTEeqrW7Meu5r3kQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Identification")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherIdentification : InstrumentIdentification1Choice_
    #else
    public partial class OtherIdentification : InstrumentIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherIdentification( System.String reqIdentification,System.String reqSource )
        {
            Identification = reqIdentification;
            Source = reqSource;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_n3WSFQbTEeqrW7Meu5r3kQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the source of the identifier that represent the constituents of a custom basket.
        /// </summary>
        [IsoId("_n3WSFwbTEeqrW7Meu5r3kQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Source")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Source { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Source { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Source { get; init; } 
        #else
        public System.String Source { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
