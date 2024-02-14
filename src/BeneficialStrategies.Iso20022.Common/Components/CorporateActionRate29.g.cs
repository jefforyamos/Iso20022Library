﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate29.  ISO2002 ID# _JemD8fo7EeCVCIR-Uq3c5A.
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
/// Specifies rate details.
/// </summary>
[IsoId("_JemD8fo7EeCVCIR-Uq3c5A")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_JemD9_o7EeCVCIR-Uq3c5A")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForSbcbdRsltntScties")]
    #endif
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat3Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat3Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #else
    public RatioFormat3Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_JemEAfo7EeCVCIR-Uq3c5A")]
    [DisplayName("Additional Quantity For Existing Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForExstgScties")]
    #endif
    [IsoXmlTag("AddtlQtyForExstgScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat3Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat3Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #else
    public RatioFormat3Choice_? AdditionalQuantityForExistingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_JemEC_o7EeCVCIR-Uq3c5A")]
    [DisplayName("New To Old")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewToOd")]
    #endif
    [IsoXmlTag("NewToOd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat15Choice_? NewToOld { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat15Choice_? NewToOld { get; init; } 
    #else
    public RatioFormat15Choice_? NewToOld { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_R7h0Ffo7EeCVCIR-Uq3c5A")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_XXo3dfo7EeCVCIR-Uq3c5A")]
    [DisplayName("Fiscal Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmp")]
    #endif
    [IsoXmlTag("FsclStmp")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FiscalStamp { get; init; } 
    #else
    public System.Decimal? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_bOaUtfo7EeCVCIR-Uq3c5A")]
    [DisplayName("Applicable Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRate")]
    #endif
    [IsoXmlTag("AplblRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ApplicableRate { get; init; } 
    #else
    public System.Decimal? ApplicableRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_e7pbdfo7EeCVCIR-Uq3c5A")]
    [DisplayName("Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtRate")]
    #endif
    [IsoXmlTag("TaxCdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; init; } 
    #else
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
