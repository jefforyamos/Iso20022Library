﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reconciled.  ISO2002 ID# _QxzOadp-Ed-ak6NoX_4Aeg_-1746354035.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus1Choice
{
    /// <summary>
    /// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
    /// </summary>
    [IsoId("_QxzOadp-Ed-ak6NoX_4Aeg_-1746354035")]
    [DisplayName("Reconciled")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reconciled : EventProcessingStatus1Choice_
    #else
    public partial class Reconciled : EventProcessingStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reconciled instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reconciled( NoReasonCode reqNoSpecifiedReason )
        {
            NoSpecifiedReason = reqNoSpecifiedReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        [DisplayName("No Specified Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoSpcfdRsn")]
        #endif
        [IsoXmlTag("NoSpcfdRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #else
        public NoReasonCode NoSpecifiedReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
