﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GeneralInvestment.  ISO2002 ID# _X-C5I-lfEeu9cf4XM82AQQ.
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
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio7Choice
{
    /// <summary>
    /// Portfolio is a general investment.
    /// </summary>
    [IsoId("_X-C5I-lfEeu9cf4XM82AQQ")]
    [DisplayName("General Investment")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GeneralInvestment : FundPortfolio7Choice_
    #else
    public partial class GeneralInvestment : FundPortfolio7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of investment.
        /// </summary>
        [IsoId("_h9fnMZNuEembCsVG-3f_AA")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GeneralInvestmentAccountType2Choice_? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GeneralInvestmentAccountType2Choice_? Type { get; init; } 
        #else
        public GeneralInvestmentAccountType2Choice_? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the account is, for example, in a nominee name or own name.
        /// </summary>
        [IsoId("_J7IRsDOQEeqjy7_SkdcoGg")]
        [DisplayName("Ownership Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OwnrshTp")]
        #endif
        [IsoXmlTag("OwnrshTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountOwnershipType6Code? OwnershipType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountOwnershipType6Code? OwnershipType { get; init; } 
        #else
        public AccountOwnershipType6Code? OwnershipType { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money invested.
        /// </summary>
        [IsoId("_h9fnM5NuEembCsVG-3f_AA")]
        [DisplayName("Current Investment Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurInvstmtAmt")]
        #endif
        [IsoXmlTag("CurInvstmtAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? CurrentInvestmentAmount { get; init; } 
        #else
        public System.Decimal? CurrentInvestmentAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Estimated value of the assets.
        /// </summary>
        [IsoId("_h9fnNZNuEembCsVG-3f_AA")]
        [DisplayName("Estimated Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EstmtdVal")]
        #endif
        [IsoXmlTag("EstmtdVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndAmount2? EstimatedValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndAmount2? EstimatedValue { get; init; } 
        #else
        public DateAndAmount2? EstimatedValue { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the portfolio.
        /// </summary>
        [IsoId("_h9fnN5NuEembCsVG-3f_AA")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #else
        public AdditionalInformation15? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
