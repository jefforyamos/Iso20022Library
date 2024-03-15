﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _XFBYs249EeiU9cctagi5ow.
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
namespace BeneficialStrategies.Iso20022.Choices.TransactionOrError4Choice
{
    /// <summary>
    /// Requested information on the payment transaction.
    /// </summary>
    [IsoId("_XFBYs249EeiU9cctagi5ow")]
    [DisplayName("Transaction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Transaction : TransactionOrError4Choice_
    #else
    public partial class Transaction : TransactionOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Destination of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_XO_0F249EeiU9cctagi5ow")]
        [DisplayName("Payment To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtTo")]
        #endif
        [IsoXmlTag("PmtTo")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public System2? PaymentTo { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System2? PaymentTo { get; init; } 
        #else
        public System2? PaymentTo { get; set; } 
        #endif
        
        /// <summary>
        /// Origin of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_XO_0GW49EeiU9cctagi5ow")]
        [DisplayName("Payment From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtFr")]
        #endif
        [IsoXmlTag("PmtFr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public System2? PaymentFrom { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System2? PaymentFrom { get; init; } 
        #else
        public System2? PaymentFrom { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the payment transaction is a debit or credit transaction. |.
        /// </summary>
        [IsoId("_XO_0G249EeiU9cctagi5ow")]
        [DisplayName("Credit Debit Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtDbtInd")]
        #endif
        [IsoXmlTag("CdtDbtInd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #else
        public CreditDebitCode? CreditDebitIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
        /// </summary>
        [IsoId("_XO_0HW49EeiU9cctagi5ow")]
        [DisplayName("Payment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pmt")]
        #endif
        [IsoXmlTag("Pmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentInstruction32? Payment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentInstruction32? Payment { get; init; } 
        #else
        public PaymentInstruction32? Payment { get; set; } 
        #endif
        
        /// <summary>
        /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
        /// </summary>
        [IsoId("_XO_0H249EeiU9cctagi5ow")]
        [DisplayName("Account Entry")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctNtry")]
        #endif
        [IsoXmlTag("AcctNtry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccountAndEntry3? AccountEntry { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccountAndEntry3? AccountEntry { get; init; } 
        #else
        public CashAccountAndEntry3? AccountEntry { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the references of the underlying securities transaction.
        /// </summary>
        [IsoId("_XO_0IW49EeiU9cctagi5ow")]
        [DisplayName("Securities Transaction References")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesTxRefs")]
        #endif
        [IsoXmlTag("SctiesTxRefs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
        #else
        public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
