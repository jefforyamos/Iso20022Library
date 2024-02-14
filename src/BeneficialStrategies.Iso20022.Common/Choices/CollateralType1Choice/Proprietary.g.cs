﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _AYq0INokEeC60axPepSq7g_-1106261733.
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
namespace BeneficialStrategies.Iso20022.Choices.CollateralType1Choice
{
    /// <summary>
    /// Type of collateral expressed as a proprietary code.
    /// </summary>
    [IsoId("_AYq0INokEeC60axPepSq7g_-1106261733")]
    [DisplayName("Proprietary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proprietary : CollateralType1Choice_
    #else
    public partial class Proprietary : CollateralType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Proprietary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Proprietary( System.String reqIdentification,System.String reqIssuer )
        {
            Identification = reqIdentification;
            Issuer = reqIssuer;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_ARz-MNokEeC60axPepSq7g_1535322318")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact4AlphaNumericText Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_ARz-MdokEeC60axPepSq7g_-757724104")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_ARz-MtokEeC60axPepSq7g_-109945117")]
        [DisplayName("Scheme Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchmeNm")]
        #endif
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SchemeName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SchemeName { get; init; } 
        #else
        public System.String? SchemeName { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
