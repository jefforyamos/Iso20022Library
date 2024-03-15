﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ExpectedCollateralDetails.  ISO2002 ID# _QmevM9p-Ed-ak6NoX_4Aeg_-1089909522.
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
namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral1Choice
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmevM9p-Ed-ak6NoX_4Aeg_-1089909522")]
    [DisplayName("Expected Collateral Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ExpectedCollateralDetails : ExpectedCollateral1Choice_
    #else
    public partial class ExpectedCollateralDetails : ExpectedCollateral1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ExpectedCollateralDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ExpectedCollateralDetails( ExpectedCollateralMovement1 reqVariationMargin )
        {
            VariationMargin = reqVariationMargin;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the expected collateral type and direction for the variation margin.
        /// </summary>
        [IsoId("_UlvaENp-Ed-ak6NoX_4Aeg_259803372")]
        [DisplayName("Variation Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgn")]
        #endif
        [IsoXmlTag("VartnMrgn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExpectedCollateralMovement1 VariationMargin { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExpectedCollateralMovement1 VariationMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExpectedCollateralMovement1 VariationMargin { get; init; } 
        #else
        public ExpectedCollateralMovement1 VariationMargin { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the expected collateral type and direction for the segregated independent amount.
        /// </summary>
        [IsoId("_UlvaEdp-Ed-ak6NoX_4Aeg_-964605282")]
        [DisplayName("Segregated Independent Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgrtdIndpdntAmt")]
        #endif
        [IsoXmlTag("SgrtdIndpdntAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; init; } 
        #else
        public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
