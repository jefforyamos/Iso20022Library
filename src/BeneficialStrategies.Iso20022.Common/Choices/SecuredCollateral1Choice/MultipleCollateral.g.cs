﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MultipleCollateral.  ISO2002 ID# _jiGBoJgAEeSfnc-VXAEapg.
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
namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice
{
    /// <summary>
    /// Identifies all securities pledged when the transaction is collateralised with more than one security. 
    /// Usage:
    /// In case of multi-collateral repo, the nominal amount of each collateralised security must be provided.
    /// </summary>
    [IsoId("_jiGBoJgAEeSfnc-VXAEapg")]
    [DisplayName("Multiple Collateral")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MultipleCollateral : SecuredCollateral1Choice_
    #else
    public partial class MultipleCollateral : SecuredCollateral1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MultipleCollateral instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MultipleCollateral( System.String reqISIN )
        {
            ISIN = reqISIN;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
        /// </summary>
        [IsoId("_m6QfAZf6EeSfnc-VXAEapg")]
        [DisplayName("Nominal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmnlAmt")]
        #endif
        [IsoXmlTag("NmnlAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? NominalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? NominalAmount { get; init; } 
        #else
        public System.Decimal? NominalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_uqx1AZf6EeSfnc-VXAEapg")]
        [DisplayName("ISIN")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ISIN")]
        #endif
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISINIdentifier ISIN { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ISIN { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ISIN { get; init; } 
        #else
        public System.String ISIN { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
