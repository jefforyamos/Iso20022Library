﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Portfolio.  ISO2002 ID# _3fnhcUXfEeGY6MkiuzuPOA_-1022877665.
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
namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio3Choice
{
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_3fnhcUXfEeGY6MkiuzuPOA_-1022877665")]
    [DisplayName("Portfolio")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Portfolio : ISAPortfolio3Choice_
    #else
    public partial class Portfolio : ISAPortfolio3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Additional information related to the portfolio.
        /// </summary>
        [IsoId("_TU0kwNp-Ed-ak6NoX_4Aeg_501703515")]
        [DisplayName("Portfolio Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtflInf")]
        #endif
        [IsoXmlTag("PrtflInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public SimpleValueList<System.String> PortfolioInformation { get; init; } = new SimpleValueList<System.String>(){};
        
        
        #nullable disable
        
    }
}
