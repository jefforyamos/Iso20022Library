﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginLending.  ISO2002 ID# _kyCmN__9Eemefbt-QjTNnA.
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
namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData14Choice
{
    /// <summary>
    /// Data on collateral used for the margin lending transaction.
    /// </summary>
    [IsoId("_kyCmN__9Eemefbt-QjTNnA")]
    [DisplayName("Margin Lending")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginLending : TransactionCollateralData14Choice_
    #else
    public partial class MarginLending : TransactionCollateralData14Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifier of the security subject of the transaction.
        /// </summary>
        [IsoId("_rt67QdLvEem1A4OOmCK97A")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISINOct2015Identifier? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Identification { get; init; } 
        #else
        public System.String? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoId("_rt67Q9LvEem1A4OOmCK97A")]
        [DisplayName("Classification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssfctnTp")]
        #endif
        [IsoXmlTag("ClssfctnTp")]
        [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClassificationType { get; init; } 
        #else
        public System.String? ClassificationType { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity or nominal amount of the security or commodity subject of the transaction.
        /// </summary>
        [IsoId("_rt67RdLvEem1A4OOmCK97A")]
        [DisplayName("Quantity Or Nominal Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtyOrNmnlVal")]
        #endif
        [IsoXmlTag("QtyOrNmnlVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; } 
        #else
        public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; set; } 
        #endif
        
        /// <summary>
        /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
        /// </summary>
        [IsoId("_rt67R9LvEem1A4OOmCK97A")]
        [DisplayName("Unit Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitPric")]
        #endif
        [IsoXmlTag("UnitPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #else
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; set; } 
        #endif
        
        /// <summary>
        /// Market value of asset or collateral component.
        /// </summary>
        [IsoId("_rt67SdLvEem1A4OOmCK97A")]
        [DisplayName("Market Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktVal")]
        #endif
        [IsoXmlTag("MktVal")]
        [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? MarketValue { get; init; } 
        #else
        public System.Decimal? MarketValue { get; set; } 
        #endif
        
        /// <summary>
        /// Code that classifies the risk of the security.
        /// </summary>
        [IsoId("_rt67S9LvEem1A4OOmCK97A")]
        [DisplayName("Quality")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qlty")]
        #endif
        [IsoXmlTag("Qlty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralQualityType1Code? Quality { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralQualityType1Code? Quality { get; init; } 
        #else
        public CollateralQualityType1Code? Quality { get; set; } 
        #endif
        
        /// <summary>
        /// Maturity of the security.
        /// </summary>
        [IsoId("_rt67TdLvEem1A4OOmCK97A")]
        [DisplayName("Maturity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Mtrty")]
        #endif
        [IsoXmlTag("Mtrty")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? Maturity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? Maturity { get; init; } 
        #else
        public System.DateOnly? Maturity { get; set; } 
        #endif
        
        /// <summary>
        /// Data on the securities issuer.
        /// </summary>
        [IsoId("_rt67T9LvEem1A4OOmCK97A")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecurityIssuer2? Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIssuer2? Issuer { get; init; } 
        #else
        public SecurityIssuer2? Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Classification of the type of the security.
        /// </summary>
        [IsoId("_rt67UdLvEem1A4OOmCK97A")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesLendingType3Choice_? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesLendingType3Choice_? Type { get; init; } 
        #else
        public SecuritiesLendingType3Choice_? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the borrower has exclusive access to borrow from the lender&apos;s securities portfolio.
        /// </summary>
        [IsoId("_rt67U9LvEem1A4OOmCK97A")]
        [DisplayName("Exclusive Arrangement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExclsvArrgmnt")]
        #endif
        [IsoXmlTag("ExclsvArrgmnt")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ExclusiveArrangement { get; init; } 
        #else
        public System.String? ExclusiveArrangement { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the collateral taker can reuse the securities provided as a collateral.
        /// </summary>
        [IsoId("_rt67VdLvEem1A4OOmCK97A")]
        [DisplayName("Available For Collateral Reuse")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AvlblForCollReuse")]
        #endif
        [IsoXmlTag("AvlblForCollReuse")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AvailableForCollateralReuse { get; init; } 
        #else
        public System.String? AvailableForCollateralReuse { get; set; } 
        #endif
        
        /// <summary>
        /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
        /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
        /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
        /// </summary>
        [IsoId("_rt67V9LvEem1A4OOmCK97A")]
        [DisplayName("Haircut Or Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HrcutOrMrgn")]
        #endif
        [IsoXmlTag("HrcutOrMrgn")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? HaircutOrMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? HaircutOrMargin { get; init; } 
        #else
        public System.Decimal? HaircutOrMargin { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
