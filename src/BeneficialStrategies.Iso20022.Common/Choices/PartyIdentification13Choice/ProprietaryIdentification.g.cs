﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _QQIEstp-Ed-ak6NoX_4Aeg_582553128.
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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification13Choice
{
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QQIEstp-Ed-ak6NoX_4Aeg_582553128")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryIdentification : PartyIdentification13Choice_
    #else
    public partial class ProprietaryIdentification : PartyIdentification13Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryIdentification( System.String reqIdentification,System.String reqIssuer )
        {
            Identification = reqIdentification;
            Issuer = reqIssuer;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P-ZbjNp-Ed-ak6NoX_4Aeg_993133587")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Identification { get; init; } 
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
        [IsoId("_P-Zbjdp-Ed-ak6NoX_4Aeg_174179906")]
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
        [IsoId("_P-ilcNp-Ed-ak6NoX_4Aeg_879294521")]
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
