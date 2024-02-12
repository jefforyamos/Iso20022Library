﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Pension5.  ISO2002 ID# _w2XZYelmEeuvhrZwLF0fDg.
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
/// Attributes of a pension.
/// </summary>
[IsoId("_w2XZYelmEeuvhrZwLF0fDg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Pension")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Pension5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Pension5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Pension5( PensionSchemeType3Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEHw-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionPolicy1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionPolicy1? Identification { get; init; } 
    #else
    public PensionPolicy1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEHxelmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PensionSchemeType3Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PensionSchemeType3Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionSchemeType3Choice_ Type { get; init; } 
    #else
    public PensionSchemeType3Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_xOEHx-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Scope")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #else
    public PensionTransferScope1Choice_? TransferScope { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_xOEHyelmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReference1? TaxReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReference1? TaxReference { get; init; } 
    #else
    public TaxReference1? TaxReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_xOEHy-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawdown Tranche Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DrawdownTrancheIdentification { get; init; } 
    #else
    public System.String? DrawdownTrancheIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Drawdown status of the pension.
    /// </summary>
    [IsoId("_xOEHzelmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawdown Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
    #else
    public DrawdownStatus1Choice_? DrawdownStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    [IsoId("_xOEHz-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawdown Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrawdownType2Choice_? DrawdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownType2Choice_? DrawdownType { get; init; } 
    #else
    public DrawdownType2Choice_? DrawdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of drawdown tranches.
    /// </summary>
    [IsoId("__IHAsOlmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Drawdown Tranches")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDrawdownTranches { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDrawdownTranches { get; init; } 
    #else
    public System.UInt64? NumberOfDrawdownTranches { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEH0elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Estimated Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? EstimatedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? EstimatedValue { get; init; } 
    #else
    public DateAndAmount2? EstimatedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer forms part of a block transfer.
    /// </summary>
    [IsoId("_xOEH0-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Block Transfer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockTransfer { get; init; } 
    #else
    public System.String? BlockTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// When the transfer is part of a block transfer, reference to link several items.
    /// </summary>
    [IsoId("_xOEH1elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Block Transfer Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BlockTransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockTransferReference { get; init; } 
    #else
    public System.String? BlockTransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
    /// </summary>
    [IsoId("_xOEH1-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Free Cash Protection")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TaxFreeCashProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxFreeCashProtection { get; init; } 
    #else
    public System.String? TaxFreeCashProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash that is tax free.
    /// </summary>
    [IsoId("_xOEH2elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Free Cash Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    #else
    public DateAndAmount2? TaxFreeCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEH2-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Of Pension Policy Or Plan Or Scheme")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    #else
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has retirement age protection.
    /// </summary>
    [IsoId("_xOEH3elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Retirement Age Protection")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RetirementAgeProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RetirementAgeProtection { get; init; } 
    #else
    public System.String? RetirementAgeProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Age at which the pension policy, plan or scheme holder retires.
    /// </summary>
    [IsoId("_xOEH3-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Retirement Age")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? RetirementAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RetirementAge { get; init; } 
    #else
    public System.UInt64? RetirementAge { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension benefits are shared.
    /// </summary>
    [IsoId("_xOEH4elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sharing")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Sharing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sharing { get; init; } 
    #else
    public System.String? Sharing { get; set; } 
    #endif
    
    /// <summary>
    /// Type of lump sum paid to a member of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEH4-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lump Sum Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LumpSumType1Choice_? LumpSumType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LumpSumType1Choice_? LumpSumType { get; init; } 
    #else
    public LumpSumType1Choice_? LumpSumType { get; set; } 
    #endif
    
    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEH5elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pension Order")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionOrder1? PensionOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionOrder1? PensionOrder { get; init; } 
    #else
    public PensionOrder1? PensionOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
    /// </summary>
    [IsoId("_xOEH5-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ring Fenced Drawdown Assets")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RingFencedDrawdownAssets { get; init; } 
    #else
    public System.String? RingFencedDrawdownAssets { get; set; } 
    #endif
    
    /// <summary>
    /// Money Purchase Annual Allowance (MPAA) details.
    /// </summary>
    [IsoId("_xOEH6elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Money Purchase Annual Allowance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    #else
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
    /// </summary>
    [IsoId("_xOEH6-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safeguard Benefit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SafeguardBenefit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SafeguardBenefit { get; init; } 
    #else
    public System.String? SafeguardBenefit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has non-safeguarded guaranteed benefits.
    /// </summary>
    [IsoId("_xOEH7elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Non Safeguarded Guaranteed Benefits")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonSafeguardedGuaranteedBenefits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonSafeguardedGuaranteedBenefits { get; init; } 
    #else
    public System.String? NonSafeguardedGuaranteedBenefits { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
    /// </summary>
    [IsoId("_xOEH7-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lifetime Allowance Protection")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LifetimeAllowanceProtection { get; init; } 
    #else
    public System.String? LifetimeAllowanceProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the client has any lifetime allowance protection.
    /// </summary>
    [IsoId("_xOEH8elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Lifetime Allowance Protection")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ClientLifetimeAllowanceProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientLifetimeAllowanceProtection { get; init; } 
    #else
    public System.String? ClientLifetimeAllowanceProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a benefit crystallisation event (BCE) has occurred. This includes ‘age 75 checks’.
    /// </summary>
    [IsoId("_xOEH8-lmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Benefit Crystallisation Event Occurred")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BenefitCrystallisationEventOccurred { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BenefitCrystallisationEventOccurred { get; init; } 
    #else
    public System.String? BenefitCrystallisationEventOccurred { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the transfer is only in relation to underlying assets, and that the wrapper transfer will occur separately.
    /// </summary>
    [IsoId("_Bg110OlrEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Non Wrapper Transfer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonWrapperTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonWrapperTransfer { get; init; } 
    #else
    public System.String? NonWrapperTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xOEH9elmEeuvhrZwLF0fDg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
