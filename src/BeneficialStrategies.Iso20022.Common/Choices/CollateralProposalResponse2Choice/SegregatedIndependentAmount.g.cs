﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _vslfM2TUEeSSTJlMfOKFsA.
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
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse2Choice
{
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount only.
    /// </summary>
    [IsoId("_vslfM2TUEeSSTJlMfOKFsA")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SegregatedIndependentAmount : CollateralProposalResponse2Choice_
    #else
    public partial class SegregatedIndependentAmount : CollateralProposalResponse2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SegregatedIndependentAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SegregatedIndependentAmount( System.String reqCollateralProposalIdentification,CollateralProposalResponse1Code reqType,CollateralResponse1 reqResponse )
        {
            CollateralProposalIdentification = reqCollateralProposalIdentification;
            Type = reqType;
            Response = reqResponse;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier for a collateral proposal.
        /// </summary>
        [IsoId("_wJv8U2TUEeSSTJlMfOKFsA")]
        [DisplayName("Collateral Proposal Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollPrpslId")]
        #endif
        [IsoXmlTag("CollPrpslId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text CollateralProposalIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String CollateralProposalIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String CollateralProposalIdentification { get; init; } 
        #else
        public System.String CollateralProposalIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the collateral proposal is an initial or a counter proposal.
        /// </summary>
        [IsoId("_wJv8VWTUEeSSTJlMfOKFsA")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralProposalResponse1Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralProposalResponse1Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralProposalResponse1Code Type { get; init; } 
        #else
        public CollateralProposalResponse1Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Provides response details for each of the proposed collateral pieces.
        /// </summary>
        [IsoId("_cpnaMGT4EeSnseycwS8fpA")]
        [DisplayName("Response")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rspn")]
        #endif
        [IsoXmlTag("Rspn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralResponse1 Response { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralResponse1 Response { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralResponse1 Response { get; init; } 
        #else
        public CollateralResponse1 Response { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
