﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction83.  ISO2002 ID# _Yhis0d-tEeelLeeCyrjnCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction83
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    public required IsoExact2AlphaNumericText TransactionType { get; init; } 
    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    public IsoMax35Text? TransactionSubType { get; init; } 
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    public AdditionalService1? AdditionalService { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 & bit 24
    /// </summary>
    public TransactionAttribute1Code? TransactionAttribute { get; init; } 
    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherTransactionAttribute { get; init; } 
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// </summary>
    public MessageReason2Code? MessageReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    public IsoMax35Text? AlternateMessageReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification11 TransactionIdentification { get; init; } 
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount.   
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent. 
    /// </summary>
    public DetailedAmount20? DetailedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount4? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    public AdditionalAmounts2? AdditionalAmounts { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    public AdditionalFee1? AdditionalFees { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    public FundingService1? FundsServices { get; init; } 
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    public AccountDetails2? AccountFrom { get; init; } 
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    public AccountDetails2? AccountTo { get; init; } 
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
