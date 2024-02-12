﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrimaryOwner.  ISO2002 ID# _tHD44RRiEeOKWo1NF21OVw.
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
namespace BeneficialStrategies.Iso20022.Choices.AccountParties4Choice
{
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_tHD44RRiEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Primary Owner")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PrimaryOwner : AccountParties4Choice_
    #else
    public partial class PrimaryOwner : AccountParties4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PrimaryOwner instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PrimaryOwner( Party16Choice_ reqParty )
        {
            Party = reqParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_Ez9zERRjEeOKWo1NF21OVw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Party")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Party16Choice_ Party { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public Party16Choice_ Party { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party16Choice_ Party { get; init; } 
        #else
        public Party16Choice_ Party { get; set; } 
        #endif
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_Ez9zExRjEeOKWo1NF21OVw")]
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
        /// Information to support Know Your Customer processes.
        /// </summary>
        [IsoId("_Ez9zFRRjEeOKWo1NF21OVw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Investor Profile Validation")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyProfileInformation3? InvestorProfileValidation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyProfileInformation3? InvestorProfileValidation { get; init; } 
        #else
        public PartyProfileInformation3? InvestorProfileValidation { get; set; } 
        #endif
        
        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_Ez9zFxRjEeOKWo1NF21OVw")]
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
        [IsoId("_Ez9zGRRjEeOKWo1NF21OVw")]
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
        [IsoId("_Ez9zGxRjEeOKWo1NF21OVw")]
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
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_Ez9zHRRjEeOKWo1NF21OVw")]
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
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_Ez9zHxRjEeOKWo1NF21OVw")]
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
        [IsoId("_Ez9zIRRjEeOKWo1NF21OVw")]
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
}
