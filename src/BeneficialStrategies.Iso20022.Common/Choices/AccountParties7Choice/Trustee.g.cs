﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Trustee.  ISO2002 ID# _J0DZtQhDEeSUPbC7DbLJpQ.
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
namespace BeneficialStrategies.Iso20022.Choices.AccountParties7Choice
{
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_J0DZtQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Trustee")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Trustee : AccountParties7Choice_
    #else
    public partial class Trustee : AccountParties7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Trustee instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Trustee( Party23Choice_ reqParty )
        {
            Party = reqParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_DxEjkQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty")]
        #endif
        [IsoXmlTag("Pty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Party23Choice_ Party { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Party23Choice_ Party { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party23Choice_ Party { get; init; } 
        #else
        public Party23Choice_ Party { get; set; } 
        #endif
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_DxEjkwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Money Laundering Check")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MnyLndrgChck")]
        #endif
        [IsoXmlTag("MnyLndrgChck")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        #else
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; set; } 
        #endif
        
        /// <summary>
        /// Information to support Know Your Customer processes.
        /// </summary>
        [IsoId("_DxEjlQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Investor Profile Validation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstrPrflVldtn")]
        #endif
        [IsoXmlTag("InvstrPrflVldtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyProfileInformation4? InvestorProfileValidation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyProfileInformation4? InvestorProfileValidation { get; init; } 
        #else
        public PartyProfileInformation4? InvestorProfileValidation { get; set; } 
        #endif
        
        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_DxEjlwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Ownership Beneficiary Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OwnrshBnfcryRate")]
        #endif
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
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
        [IsoId("_DxEjmQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Client Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClntId")]
        #endif
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
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
        [IsoId("_DxEjmwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Fiscal Exemption")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FsclXmptn")]
        #endif
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? FiscalExemption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? FiscalExemption { get; init; } 
        #else
        public System.String? FiscalExemption { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_DxEjnQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Signatory Right Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgntryRghtInd")]
        #endif
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SignatoryRightIndicator { get; init; } 
        #else
        public System.String? SignatoryRightIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_DxEjnwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Mi FID Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MiFIDClssfctn")]
        #endif
        [IsoXmlTag("MiFIDClssfctn")]
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
        [IsoId("_DxEjoQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Information Distribution")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InfDstrbtn")]
        #endif
        [IsoXmlTag("InfDstrbtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InformationDistribution1Code? InformationDistribution { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InformationDistribution1Code? InformationDistribution { get; init; } 
        #else
        public InformationDistribution1Code? InformationDistribution { get; set; } 
        #endif
        
        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor.
        /// </summary>
        [IsoId("_Ul20UQjQEeS5F6qHcKOrew")]
        [DisplayName("FATCA Form Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FATCAFormTp")]
        #endif
        [IsoXmlTag("FATCAFormTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FATCAForm1Choice_? FATCAFormType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FATCAForm1Choice_? FATCAFormType { get; init; } 
        #else
        public FATCAForm1Choice_? FATCAFormType { get; set; } 
        #endif
        
        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor.
        /// </summary>
        [IsoId("_YNqBcQjQEeS5F6qHcKOrew")]
        [DisplayName("FATCA Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FATCASts")]
        #endif
        [IsoXmlTag("FATCASts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FATCAStatus1? FATCAStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FATCAStatus1? FATCAStatus { get; init; } 
        #else
        public FATCAStatus1? FATCAStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
