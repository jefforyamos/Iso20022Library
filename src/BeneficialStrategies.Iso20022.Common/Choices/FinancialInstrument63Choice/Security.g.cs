﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Security.  ISO2002 ID# _nj5gMaPvEemf4IaGqCtquA.
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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument63Choice
{
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_nj5gMaPvEemf4IaGqCtquA")]
    [DisplayName("Security")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Security : FinancialInstrument63Choice_
    #else
    public partial class Security : FinancialInstrument63Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Security instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Security( SecurityIdentification25Choice_ reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
        /// </summary>
        [IsoId("_w33Uk5NJEemQB_8XA98K0Q")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityIdentification25Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecurityIdentification25Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIdentification25Choice_ Identification { get; init; } 
        #else
        public SecurityIdentification25Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the financial instrument in free format text.
        /// </summary>
        [IsoId("_w33UlZNJEemQB_8XA98K0Q")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
        /// </summary>
        [IsoId("_w33Ul5NJEemQB_8XA98K0Q")]
        [DisplayName("Short Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtNm")]
        #endif
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ShortName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ShortName { get; init; } 
        #else
        public System.String? ShortName { get; set; } 
        #endif
        
        /// <summary>
        /// Type of security.
        /// </summary>
        [IsoId("_qDzm0pNJEemQB_8XA98K0Q")]
        [DisplayName("Classification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssfctnTp")]
        #endif
        [IsoXmlTag("ClssfctnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ClassificationType32Choice_? ClassificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ClassificationType32Choice_? ClassificationType { get; init; } 
        #else
        public ClassificationType32Choice_? ClassificationType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
