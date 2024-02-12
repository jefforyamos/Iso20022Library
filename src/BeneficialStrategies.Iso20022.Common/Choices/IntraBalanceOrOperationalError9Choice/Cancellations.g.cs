﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancellations.  ISO2002 ID# _p-rkcTnfEem7JZMuWtwtsg.
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
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError9Choice
{
    /// <summary>
    /// Further details of the intrabalance cancellation transactions.
    /// </summary>
    [IsoId("_p-rkcTnfEem7JZMuWtwtsg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellations")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Cancellations : IntraBalanceOrOperationalError9Choice_
    #else
    public partial class Cancellations : IntraBalanceOrOperationalError9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_qIqm6TnfEem7JZMuWtwtsg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Cash Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount38? CashAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount38? CashAccount { get; init; } 
        #else
        public CashAccount38? CashAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owns the account.
        /// </summary>
        [IsoId("_qIqm5znfEem7JZMuWtwtsg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Cash Account Owner")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        #else
        public SystemPartyIdentification8? CashAccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_rLDQsTp-EemwKdP955WBJQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Cash Account Servicer")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
        #endif
        
        /// <summary>
        /// Status and status reason of the transaction.
        /// </summary>
        [IsoId("_qIqm6znfEem7JZMuWtwtsg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Processing Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ProcessingStatus69Choice_? ProcessingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProcessingStatus69Choice_? ProcessingStatus { get; init; } 
        #else
        public ProcessingStatus69Choice_? ProcessingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Further details of the individual intrabalance cancellation transaction.
        /// </summary>
        [IsoId("_qIqm7TnfEem7JZMuWtwtsg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Cancellation")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        public IntraBalanceCancellation6? Cancellation { get; init;  } // Warning: Don't know multiplicity.
        // ID for the above is _qIqm7TnfEem7JZMuWtwtsg
        
        
        #nullable disable
        
    }
}
