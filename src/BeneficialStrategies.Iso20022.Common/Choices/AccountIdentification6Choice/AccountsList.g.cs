﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsList.  ISO2002 ID# _QSgqV9p-Ed-ak6NoX_4Aeg_1395583374.
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
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification6Choice
{
    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_QSgqV9p-Ed-ak6NoX_4Aeg_1395583374")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accounts List")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AccountsList : AccountIdentification6Choice_
    #else
    public partial class AccountsList : AccountIdentification6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AccountsList instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AccountsList( System.String reqSafekeepingAccount )
        {
            SafekeepingAccount = reqSafekeepingAccount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_QSXgZtp-Ed-ak6NoX_4Aeg_-606504210")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Safekeeping Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SafekeepingAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SafekeepingAccount { get; init; } 
        #else
        public System.String SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_QSXgZ9p-Ed-ak6NoX_4Aeg_-1489737497")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Account Owner")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification13Choice_? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification13Choice_? AccountOwner { get; init; } 
        #else
        public PartyIdentification13Choice_? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_QSXgaNp-Ed-ak6NoX_4Aeg_155529938")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Safekeeping Place")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
        #else
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
