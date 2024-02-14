﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsListAndBalanceDetails.  ISO2002 ID# _Jg42I_pTEeCLrd06h-p51g.
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
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification18Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_Jg42I_pTEeCLrd06h-p51g")]
    [DisplayName("Accounts List And Balance Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AccountsListAndBalanceDetails : AccountIdentification18Choice_
    #else
    public partial class AccountsListAndBalanceDetails : AccountIdentification18Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AccountsListAndBalanceDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AccountsListAndBalanceDetails( System.String reqSafekeepingAccount )
        {
            SafekeepingAccount = reqSafekeepingAccount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_Jg42M_pTEeCLrd06h-p51g")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SafekeepingAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SafekeepingAccount { get; init; } 
        #else
        public System.String SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_Jg42PfpTEeCLrd06h-p51g")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification36Choice_? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification36Choice_? AccountOwner { get; init; } 
        #else
        public PartyIdentification36Choice_? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_Jg42R_pTEeCLrd06h-p51g")]
        [DisplayName("Safekeeping Place")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgPlc")]
        #endif
        [IsoXmlTag("SfkpgPlc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
        #else
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_Jg42UfpTEeCLrd06h-p51g")]
        [DisplayName("Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Bal")]
        #endif
        [IsoXmlTag("Bal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CorporateActionBalanceDetails10? Balance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CorporateActionBalanceDetails10? Balance { get; init; } 
        #else
        public CorporateActionBalanceDetails10? Balance { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
