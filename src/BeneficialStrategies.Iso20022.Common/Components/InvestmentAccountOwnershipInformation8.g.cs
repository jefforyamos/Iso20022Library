﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountOwnershipInformation8.  ISO2002 ID# _JZMzcRRQEeOKWo1NF21OVw.
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
/// Characteristics of the ownership of an investment account.
/// </summary>
[IsoId("_JZMzcRRQEeOKWo1NF21OVw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Investment Account Ownership Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountOwnershipInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccountOwnershipInformation8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccountOwnershipInformation8( Party15Choice_ reqParty )
    {
        Party = reqParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about the organisation or individual person.
    /// </summary>
    [IsoId("_JwaZkxRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party15Choice_ Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Party15Choice_ Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party15Choice_ Party { get; init; } 
    #else
    public Party15Choice_ Party { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_JwaZlRRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Money Laundering Check")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
    #else
    public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of ownership or beneficiary ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    [IsoId("_JwaZlxRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ownership Beneficiary Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OwnershipBeneficiaryRate { get; init; } 
    #else
    public System.Decimal? OwnershipBeneficiaryRate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_JwaZmRRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientIdentification { get; init; } 
    #else
    public System.String? ClientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
    /// </summary>
    [IsoId("_JwaZmxRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fiscal Exemption")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FiscalExemption { get; init; } 
    #else
    public System.String? FiscalExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account owner signature is required to authorise transactions on the account.
    /// </summary>
    [IsoId("_JwaZnRRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Signatory Right Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SignatoryRightIndicator { get; init; } 
    #else
    public System.String? SignatoryRightIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the party profile to be inserted or deleted.
    /// </summary>
    [IsoId("_JwaZnxRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modified Investor Profile Validation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(10)]
    #endif
    public ValueList<ModificationScope19> ModifiedInvestorProfileValidation { get; init; } = new ValueList<ModificationScope19>(){};
    
    /// <summary>
    /// Details about the MiFID classification of the account owner.
    /// </summary>
    [IsoId("_JwaZoRRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Mi FID Classification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MiFIDClassification1? MiFIDClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MiFIDClassification1? MiFIDClassification { get; init; } 
    #else
    public MiFIDClassification1? MiFIDClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how information is sent to the account holder.
    /// </summary>
    [IsoId("_JwaZoxRQEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Information Distribution")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InformationDistribution1Code? InformationDistribution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationDistribution1Code? InformationDistribution { get; init; } 
    #else
    public InformationDistribution1Code? InformationDistribution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
