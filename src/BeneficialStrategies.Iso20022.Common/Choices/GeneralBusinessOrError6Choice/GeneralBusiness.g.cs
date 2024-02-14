﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GeneralBusiness.  ISO2002 ID# _Mg4II5lgEeeE1Ya-LgRsuQ.
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
namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError6Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_Mg4II5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GeneralBusiness : GeneralBusinessOrError6Choice_
    #else
    public partial class GeneralBusiness : GeneralBusinessOrError6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Further information about the criticality or importance of a general business information system.
        /// </summary>
        [IsoId("_MpLIgZlgEeeE1Ya-LgRsuQ")]
        [DisplayName("Qualifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qlfr")]
        #endif
        [IsoXmlTag("Qlfr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InformationQualifierType1? Qualifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InformationQualifierType1? Qualifier { get; init; } 
        #else
        public InformationQualifierType1? Qualifier { get; set; } 
        #endif
        
        /// <summary>
        /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
        /// </summary>
        [IsoId("_MpLIg5lgEeeE1Ya-LgRsuQ")]
        [DisplayName("Subject")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sbjt")]
        #endif
        [IsoXmlTag("Sbjt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Subject { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Subject { get; init; } 
        #else
        public System.String? Subject { get; set; } 
        #endif
        
        /// <summary>
        /// General business information, in unstructured form.
        /// </summary>
        [IsoId("_MpLIhZlgEeeE1Ya-LgRsuQ")]
        [DisplayName("Subject Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SbjtDtls")]
        #endif
        [IsoXmlTag("SbjtDtls")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? SubjectDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SubjectDetails { get; init; } 
        #else
        public System.String? SubjectDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
