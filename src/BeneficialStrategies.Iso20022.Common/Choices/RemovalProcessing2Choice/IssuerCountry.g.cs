﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IssuerCountry.  ISO2002 ID# __ioARRIoEeyZaPkaPAzTvQ.
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
namespace BeneficialStrategies.Iso20022.Choices.RemovalProcessing2Choice
{
    /// <summary>
    /// Country of the issuer  (this can the either the country of residence or the nationality).
    /// </summary>
    [IsoId("__ioARRIoEeyZaPkaPAzTvQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer Country")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IssuerCountry : RemovalProcessing2Choice_
    #else
    public partial class IssuerCountry : RemovalProcessing2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IssuerCountry instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IssuerCountry( string reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountryCode Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public string Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Value { get; init; } 
        #else
        public string Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
