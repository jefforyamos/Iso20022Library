﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralReuseUpdate.  ISO2002 ID# _MzHkR8K8EeuMhqg3CsEu6Q.
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
namespace BeneficialStrategies.Iso20022.Choices.ReuseDataReport6Choice
{
    /// <summary>
    /// Information on collateral reusability for multiple transactions.
    /// </summary>
    [IsoId("_MzHkR8K8EeuMhqg3CsEu6Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Reuse Update")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CollateralReuseUpdate : ReuseDataReport6Choice_
    #else
    public partial class CollateralReuseUpdate : ReuseDataReport6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CollateralReuseUpdate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CollateralReuseUpdate( System.DateTime reqReportingDateTime,CounterpartyData87 reqCounterparty,System.DateOnly reqEventDay )
        {
            ReportingDateTime = reqReportingDateTime;
            Counterparty = reqCounterparty;
            EventDay = reqEventDay;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_jZla0cK8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Technical Record Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_jZla08K8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reporting Date Time")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ReportingDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateTime ReportingDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ReportingDateTime { get; init; } 
        #else
        public System.DateTime ReportingDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_jZla1cK8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Counterparty")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyData87 Counterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CounterpartyData87 Counterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyData87 Counterparty { get; init; } 
        #else
        public CounterpartyData87 Counterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the security or cash pledged as collateral.
        /// </summary>
        [IsoId("_jZla18K8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Collateral Component")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralType19? CollateralComponent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralType19? CollateralComponent { get; init; } 
        #else
        public CollateralType19? CollateralComponent { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_jZla2cK8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Event Day")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDay { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateOnly EventDay { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDay { get; init; } 
        #else
        public System.DateOnly EventDay { get; set; } 
        #endif
        
        /// <summary>
        /// Information on funding sources used to finance margin loans.
        /// </summary>
        [IsoId("_jZla28K8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Funding Source")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FundingSource3? FundingSource { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FundingSource3? FundingSource { get; init; } 
        #else
        public FundingSource3? FundingSource { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_jZla3cK8EeuCIrYISEfoUg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Supplementary Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
