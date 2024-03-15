﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingSettlement.  ISO2002 ID# _o1CqqRwkEeOIveEnnb_1-A.
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
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_o1CqqRwkEeOIveEnnb_1-A")]
    [DisplayName("Pending Settlement")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PendingSettlement : TransferStatus1Choice_
    #else
    public partial class PendingSettlement : TransferStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PendingSettlement instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PendingSettlement( PendingSettlementStatusReason2Code reqReason,System.String reqExtendedReason,GenericIdentification1 reqDataSourceScheme,NoReasonCode reqNoSpecifiedReason )
        {
            Reason = reqReason;
            ExtendedReason = reqExtendedReason;
            DataSourceScheme = reqDataSourceScheme;
            NoSpecifiedReason = reqNoSpecifiedReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the settlement pending status.
        /// </summary>
        [IsoId("_RRPjd9p-Ed-ak6NoX_4Aeg_1818056284")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PendingSettlementStatusReason2Code Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PendingSettlementStatusReason2Code Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PendingSettlementStatusReason2Code Reason { get; init; } 
        #else
        public PendingSettlementStatusReason2Code Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the settlement pending status.
        /// </summary>
        [IsoId("_RRPjeNp-Ed-ak6NoX_4Aeg_1820827730")]
        [DisplayName("Extended Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XtndedRsn")]
        #endif
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExtended350Code ExtendedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ExtendedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ExtendedReason { get; init; } 
        #else
        public System.String ExtendedReason { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason for the pending settlement status.
        /// </summary>
        [IsoId("_RRPjedp-Ed-ak6NoX_4Aeg_-685618492")]
        [DisplayName("Data Source Scheme")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DataSrcSchme")]
        #endif
        [IsoXmlTag("DataSrcSchme")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification1 DataSourceScheme { get; init; } 
        #else
        public GenericIdentification1 DataSourceScheme { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RRPjetp-Ed-ak6NoX_4Aeg_-685618527")]
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
