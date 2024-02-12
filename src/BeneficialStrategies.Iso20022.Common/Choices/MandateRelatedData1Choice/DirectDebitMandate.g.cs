﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectDebitMandate.  ISO2002 ID# _su3YKslxEem0vqvvoqYsqQ.
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
namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData1Choice
{
    /// <summary>
    /// Specific direct debit mandate data.
    /// </summary>
    [IsoId("_su3YKslxEem0vqvvoqYsqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Direct Debit Mandate")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DirectDebitMandate : MandateRelatedData1Choice_
    #else
    public partial class DirectDebitMandate : MandateRelatedData1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_Acqrx249EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Mandate Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateIdentification { get; init; } 
        #else
        public System.String? MandateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the direct debit mandate has been signed by the debtor.
        /// </summary>
        [IsoId("_AcqryW49EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Date Of Signature")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? DateOfSignature { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? DateOfSignature { get; init; } 
        #else
        public System.DateOnly? DateOfSignature { get; set; } 
        #endif
        
        /// <summary>
        /// Indicator notifying whether the underlying mandate is amended or not.
        /// </summary>
        [IsoId("_Acqry249EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Amendment Indicator")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AmendmentIndicator { get; init; } 
        #else
        public System.String? AmendmentIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// List of mandate elements that have been modified.
        /// </summary>
        [IsoId("_AcqrzW49EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Amendment Information Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmendmentInformationDetails13? AmendmentInformationDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmendmentInformationDetails13? AmendmentInformationDetails { get; init; } 
        #else
        public AmendmentInformationDetails13? AmendmentInformationDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional security provisions, such as a digital signature, as provided by the debtor.
        /// </summary>
        [IsoId("_Acqrz249EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Electronic Signature")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax1025Text? ElectronicSignature { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ElectronicSignature { get; init; } 
        #else
        public System.String? ElectronicSignature { get; set; } 
        #endif
        
        /// <summary>
        /// Date of the first collection of a direct debit as per the mandate.
        /// </summary>
        [IsoId("_Acqr0W49EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("First Collection Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? FirstCollectionDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? FirstCollectionDate { get; init; } 
        #else
        public System.DateOnly? FirstCollectionDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date of the final collection of a direct debit as per the mandate.
        /// </summary>
        [IsoId("_Acqr0249EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Final Collection Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? FinalCollectionDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? FinalCollectionDate { get; init; } 
        #else
        public System.DateOnly? FinalCollectionDate { get; set; } 
        #endif
        
        /// <summary>
        /// Regularity with which direct debit instructions are to be created and processed.
        /// </summary>
        [IsoId("_Acqr1W49EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Frequency")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency36Choice_? Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency36Choice_? Frequency { get; init; } 
        #else
        public Frequency36Choice_? Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
        /// </summary>
        [IsoId("_Acqr1249EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #else
        public MandateSetupReason1Choice_? Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the number of days the direct debit instruction must be tracked.
        /// </summary>
        [IsoId("_Acqr2W49EeiU9cctagi5ow")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Tracking Days")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 0 ,MinimumLength = 0)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoExact2NumericText? TrackingDays { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TrackingDays { get; init; } 
        #else
        public System.String? TrackingDays { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
