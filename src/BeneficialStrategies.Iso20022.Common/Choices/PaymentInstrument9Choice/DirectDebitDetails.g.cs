﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectDebitDetails.  ISO2002 ID# _VK1rMdp-Ed-ak6NoX_4Aeg_853690904.
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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument9Choice
{
    /// <summary>
    /// Instruction, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
    /// </summary>
    [IsoId("_VK1rMdp-Ed-ak6NoX_4Aeg_853690904")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Direct Debit Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DirectDebitDetails : PaymentInstrument9Choice_
    #else
    public partial class DirectDebitDetails : PaymentInstrument9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DirectDebitDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DirectDebitDetails( CashAccountIdentification1Choice_ reqDebtorAccountIdentification,FinancialInstitutionIdentification3Choice_ reqFirstAgent )
        {
            DebtorAccountIdentification = reqDebtorAccountIdentification;
            FirstAgent = reqFirstAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_VMep99p-Ed-ak6NoX_4Aeg_-615142697")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor Account Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CashAccountIdentification1Choice_ DebtorAccountIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CashAccountIdentification1Choice_ DebtorAccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccountIdentification1Choice_ DebtorAccountIdentification { get; init; } 
        #else
        public CashAccountIdentification1Choice_ DebtorAccountIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
        /// </summary>
        [IsoId("_VMep-Np-Ed-ak6NoX_4Aeg_-615142680")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? DebtorIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? DebtorIdentification { get; init; } 
        #else
        public PartyIdentification2Choice_? DebtorIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_VMep-dp-Ed-ak6NoX_4Aeg_-615142662")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Creditor Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? CreditorIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? CreditorIdentification { get; init; } 
        #else
        public PartyIdentification2Choice_? CreditorIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
        /// </summary>
        [IsoId("_VMep-tp-Ed-ak6NoX_4Aeg_-615142645")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("First Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_ FirstAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
        /// </summary>
        [IsoId("_VMep-9p-Ed-ak6NoX_4Aeg_-615142627")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Final Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification3Choice_? FinalAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_? FinalAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_? FinalAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
        /// </summary>
        [IsoId("_VMep_Np-Ed-ak6NoX_4Aeg_-615142354")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Registration Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? RegistrationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegistrationIdentification { get; init; } 
        #else
        public System.String? RegistrationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
        /// </summary>
        [IsoId("_VMoa8Np-Ed-ak6NoX_4Aeg_-615142337")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Mandate Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateIdentification { get; init; } 
        #else
        public System.String? MandateIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
