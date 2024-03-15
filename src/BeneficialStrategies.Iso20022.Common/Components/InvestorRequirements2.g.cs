﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestorRequirements2.  ISO2002 ID# _47o54aDsEequlaOyi6MUhw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor’s investment requirements.
/// </summary>
[IsoId("_47o54aDsEequlaOyi6MUhw")]
[DisplayName("Investor Requirements")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestorRequirements2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for the preservation of capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05010.
    /// </summary>
    [IsoId("_5SQDEaDsEequlaOyi6MUhw")]
    [DisplayName("Return Profile Preservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflPrsrvtn")]
    #endif
    [IsoXmlTag("RtrPrflPrsrvtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfilePreservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfilePreservation { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfilePreservation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with a client looking for capitalisation growth. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05020.
    /// </summary>
    [IsoId("_5SQDE6DsEequlaOyi6MUhw")]
    [DisplayName("Return Profile Growth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflGrwth")]
    #endif
    [IsoXmlTag("RtrPrflGrwth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileGrowth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileGrowth { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileGrowth { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for income. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05030.
    /// </summary>
    [IsoId("_5SQDFaDsEequlaOyi6MUhw")]
    [DisplayName("Return Profile Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflIncm")]
    #endif
    [IsoXmlTag("RtrPrflIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileIncome { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the hedging profile of a structured security product.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05040. 
    /// </summary>
    [IsoId("_5SQDF6DsEequlaOyi6MUhw")]
    [DisplayName("Return Profile Hedging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflHdgg")]
    #endif
    [IsoXmlTag("RtrPrflHdgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileHedging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileHedging { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileHedging { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the option or leveraged return profile of a structured security product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05050.
    /// </summary>
    [IsoId("_5SQDGaDsEequlaOyi6MUhw")]
    [DisplayName("Option Or Leveraged Return Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnOrLvrgdRtrPrfl")]
    #endif
    [IsoXmlTag("OptnOrLvrgdRtrPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; } 
    #else
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the Return Profile Pension Scheme Germany profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05070.
    /// </summary>
    [IsoId("_5SQDHaDsEequlaOyi6MUhw")]
    [DisplayName("Return Profile Pension Scheme Germany")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflPnsnSchmeDE")]
    #endif
    [IsoXmlTag("RtrPrflPnsnSchmeDE")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum recommended holding period (RHP).
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05080.
    /// </summary>
    [IsoId("_5SQDH6DsEequlaOyi6MUhw")]
    [DisplayName("Minimum Holding Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinHldgPrd")]
    #endif
    [IsoXmlTag("MinHldgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeHorizon2Choice_? MinimumHoldingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeHorizon2Choice_? MinimumHoldingPeriod { get; init; } 
    #else
    public TimeHorizon2Choice_? MinimumHoldingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with investors that have Environmental, Social and Governance (ESG) preferences. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05105.
    /// </summary>
    [IsoId("_ALhA8KDtEequlaOyi6MUhw")]
    [DisplayName("ESG Preferences")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ESGPrefs")]
    #endif
    [IsoXmlTag("ESGPrefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket2Code? ESGPreferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket2Code? ESGPreferences { get; init; } 
    #else
    public TargetMarket2Code? ESGPreferences { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies other specific investment needs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05115.
    /// </summary>
    [IsoId("_XbtJ8KDtEequlaOyi6MUhw")]
    [DisplayName("Other Specific Investment Need")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrSpcfcInvstmtNeed")]
    #endif
    [IsoXmlTag("OthrSpcfcInvstmtNeed")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentNeed2Choice_? OtherSpecificInvestmentNeed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentNeed2Choice_? OtherSpecificInvestmentNeed { get; init; } 
    #else
    public InvestmentNeed2Choice_? OtherSpecificInvestmentNeed { get; set; } 
    #endif
    
    /// <summary>
    /// Other investment need. 
    /// </summary>
    [IsoId("_5SQDJaDsEequlaOyi6MUhw")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherInvestmentNeed1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherInvestmentNeed1? Other { get; init; } 
    #else
    public OtherInvestmentNeed1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
