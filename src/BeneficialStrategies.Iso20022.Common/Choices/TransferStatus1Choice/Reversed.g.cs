﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reversed.  ISO2002 ID# _o1CqrxwkEeOIveEnnb_1-A.
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
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_o1CqrxwkEeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reversed")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reversed : TransferStatus1Choice_
    #else
    public partial class Reversed : TransferStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reversed instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reversed( System.String reqReason,GenericIdentification1 reqDataSourceScheme,NoReasonCode reqNoSpecifiedReason )
        {
            Reason = reqReason;
            DataSourceScheme = reqDataSourceScheme;
            NoSpecifiedReason = reqNoSpecifiedReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the reversal status.
        /// </summary>
        [IsoId("_RQptltp-Ed-ak6NoX_4Aeg_-1949430313")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Reason { get; init; } 
        #else
        public System.String Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason for the reversed status.
        /// </summary>
        [IsoId("_RQptl9p-Ed-ak6NoX_4Aeg_-1949430294")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Data Source Scheme")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification1 DataSourceScheme { get; init; } 
        #else
        public GenericIdentification1 DataSourceScheme { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RQptmNp-Ed-ak6NoX_4Aeg_1619833408")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("No Specified Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #else
        public NoReasonCode NoSpecifiedReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
