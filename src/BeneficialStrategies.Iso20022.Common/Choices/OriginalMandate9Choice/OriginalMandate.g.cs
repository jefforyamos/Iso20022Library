﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalMandate.  ISO2002 ID# _eBUvc9cZEeqRFcf2R4bPBw.
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
namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate9Choice
{
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_eBUvc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalMandate : OriginalMandate9Choice_
    #else
    public partial class OriginalMandate : OriginalMandate9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalMandate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalMandate( System.String reqMandateIdentification,System.String reqTrackingIndicator,PartyIdentification135 reqCreditor,PartyIdentification135 reqDebtor,BranchAndFinancialInstitutionIdentification6 reqDebtorAgent )
        {
            MandateIdentification = reqMandateIdentification;
            TrackingIndicator = reqTrackingIndicator;
            Creditor = reqCreditor;
            Debtor = reqDebtor;
            DebtorAgent = reqDebtorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_eCqzRdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtId")]
        #endif
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text MandateIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String MandateIdentification { get; init; } 
        #else
        public System.String MandateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification for the mandate request, as assigned by the initiating party.
        /// </summary>
        [IsoId("_eCqzR9cZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Request Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtReqId")]
        #endif
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateRequestIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateRequestIdentification { get; init; } 
        #else
        public System.String? MandateRequestIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the transport authentication details related to the mandate.
        /// </summary>
        [IsoId("_eCqzSdcZEeqRFcf2R4bPBw")]
        [DisplayName("Authentication")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Authntcn")]
        #endif
        [IsoXmlTag("Authntcn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateAuthentication1? Authentication { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateAuthentication1? Authentication { get; init; } 
        #else
        public MandateAuthentication1? Authentication { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of mandate, such as paper, electronic or scheme.
        /// </summary>
        [IsoId("_eCqzS9cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateTypeInformation2? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateTypeInformation2? Type { get; init; } 
        #else
        public MandateTypeInformation2? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
        /// </summary>
        [IsoId("_eCqzTdcZEeqRFcf2R4bPBw")]
        [DisplayName("Occurrences")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ocrncs")]
        #endif
        [IsoXmlTag("Ocrncs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateOccurrences5? Occurrences { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateOccurrences5? Occurrences { get; init; } 
        #else
        public MandateOccurrences5? Occurrences { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
        /// </summary>
        [IsoId("_eCqzT9cZEeqRFcf2R4bPBw")]
        [DisplayName("Tracking Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrckgInd")]
        #endif
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TrackingIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TrackingIndicator { get; init; } 
        #else
        public System.String TrackingIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
        /// </summary>
        [IsoId("_eCqzUdcZEeqRFcf2R4bPBw")]
        [DisplayName("First Collection Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrstColltnAmt")]
        #endif
        [IsoXmlTag("FrstColltnAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? FirstCollectionAmount { get; init; } 
        #else
        public System.Decimal? FirstCollectionAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Fixed amount to be collected from the debtor&apos;s account.
        /// </summary>
        [IsoId("_eCqzU9cZEeqRFcf2R4bPBw")]
        [DisplayName("Collection Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ColltnAmt")]
        #endif
        [IsoXmlTag("ColltnAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? CollectionAmount { get; init; } 
        #else
        public System.Decimal? CollectionAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
        /// </summary>
        [IsoId("_eCqzVdcZEeqRFcf2R4bPBw")]
        [DisplayName("Maximum Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MaxAmt")]
        #endif
        [IsoXmlTag("MaxAmt")]
        [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? MaximumAmount { get; init; } 
        #else
        public System.Decimal? MaximumAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
        /// </summary>
        [IsoId("_eCqzV9cZEeqRFcf2R4bPBw")]
        [DisplayName("Adjustment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adjstmnt")]
        #endif
        [IsoXmlTag("Adjstmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateAdjustment1? Adjustment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateAdjustment1? Adjustment { get; init; } 
        #else
        public MandateAdjustment1? Adjustment { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the reason for the setup of the mandate.
        /// </summary>
        [IsoId("_eCqzWdcZEeqRFcf2R4bPBw")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #else
        public MandateSetupReason1Choice_? Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Credit party that signs the mandate.
        /// </summary>
        [IsoId("_eCqzW9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Scheme Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrSchmeId")]
        #endif
        [IsoXmlTag("CdtrSchmeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
        #else
        public PartyIdentification135? CreditorSchemeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that signs the mandate and to whom an amount of money is due.
        /// </summary>
        [IsoId("_eCqzXdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification135 Creditor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification135 Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135 Creditor { get; init; } 
        #else
        public PartyIdentification135 Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_eCqzX9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? CreditorAccount { get; init; } 
        #else
        public CashAccount40? CreditorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_eCqzYdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_eCqzY9cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtCdtr")]
        #endif
        [IsoXmlTag("UltmtCdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? UltimateCreditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? UltimateCreditor { get; init; } 
        #else
        public PartyIdentification135? UltimateCreditor { get; set; } 
        #endif
        
        /// <summary>
        /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_eCqzZdcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dbtr")]
        #endif
        [IsoXmlTag("Dbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification135 Debtor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification135 Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135 Debtor { get; init; } 
        #else
        public PartyIdentification135 Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_eCqzZ9cZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAcct")]
        #endif
        [IsoXmlTag("DbtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? DebtorAccount { get; init; } 
        #else
        public CashAccount40? DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_eCqzadcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgt")]
        #endif
        [IsoXmlTag("DbtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_eCqza9cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtDbtr")]
        #endif
        [IsoXmlTag("UltmtDbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? UltimateDebtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? UltimateDebtor { get; init; } 
        #else
        public PartyIdentification135? UltimateDebtor { get; set; } 
        #endif
        
        /// <summary>
        /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
        /// </summary>
        [IsoId("_eCqzbdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtRef")]
        #endif
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateReference { get; init; } 
        #else
        public System.String? MandateReference { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information to identify the underlying documents associated with the mandate.
        /// </summary>
        [IsoId("_eCqzb9cZEeqRFcf2R4bPBw")]
        [DisplayName("Referred Document")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDoc")]
        #endif
        [IsoXmlTag("RfrdDoc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReferredMandateDocument1? ReferredDocument { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReferredMandateDocument1? ReferredDocument { get; init; } 
        #else
        public ReferredMandateDocument1? ReferredDocument { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
