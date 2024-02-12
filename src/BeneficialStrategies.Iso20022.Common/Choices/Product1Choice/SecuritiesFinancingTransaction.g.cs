﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesFinancingTransaction.  ISO2002 ID# _L8Gl0LVQEeadLcJesEbkTQ.
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
namespace BeneficialStrategies.Iso20022.Choices.Product1Choice
{
    /// <summary>
    /// Attributes relating to repurchase agreement cleared by the CCP.
    /// </summary>
    [IsoId("_L8Gl0LVQEeadLcJesEbkTQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Financing Transaction")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesFinancingTransaction : Product1Choice_
    #else
    public partial class SecuritiesFinancingTransaction : Product1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesFinancingTransaction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesFinancingTransaction( ProductClassification1 reqProductClassification,RepurchaseAgreementType1Choice_ reqRepurchaseAgreementType )
        {
            ProductClassification = reqProductClassification;
            RepurchaseAgreementType = reqRepurchaseAgreementType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0.
        /// </summary>
        [IsoId("_EBtPIDXHEemdWfjs3tykFQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Product Classification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ProductClassification1 ProductClassification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ProductClassification1 ProductClassification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProductClassification1 ProductClassification { get; init; } 
        #else
        public ProductClassification1 ProductClassification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the repo is a general collateral repo or specific repo.
        /// </summary>
        [IsoId("_aYveibcREeabfchHYoktpA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Repurchase Agreement Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; init; } 
        #else
        public RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier for triparty agent if applicable.
        /// </summary>
        [IsoId("_aYvei7cREeabfchHYoktpA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Triparty Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? TripartyAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TripartyAgent { get; init; } 
        #else
        public System.String? TripartyAgent { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
