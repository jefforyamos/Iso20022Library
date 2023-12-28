﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalLocalInstrument1Code.  ISO2002 ID# _ame0gdp-Ed-ak6NoX_4Aeg_-1943783063.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0gdp-Ed-ak6NoX_4Aeg_-1943783063")]
[Description(@"Specifies the external local instrument code in the format of character string with a maximum length of 35 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalLocalInstrumentCode))]
public enum ExternalLocalInstrument1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebitConfirmedElectronicMandate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmA1uPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebitConfirmedElectronicMandate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebitPaperMandateWithPaperAuthorization".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmA1u_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebitPaperMandateWithPaperAuthorization,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebitUnconfirmedElectronicMandate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmJ_ovRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebitUnconfirmedElectronicMandate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchPaymentsAruba".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmJ_pfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BatchPaymentsAruba,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstantPaymentsAruba".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmJ_qPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InstantPaymentsAruba,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmJ_q_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonPreauthorisedDirectDebitAT".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmTwovRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonPreauthorisedDirectDebitAT,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedDirectDebitAT".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmTwpfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedDirectDebitAT,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashPerPost".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmTwqPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CashPerPost,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReturnedCreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmTwq_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ReturnedCreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TruncatedCreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmc6kvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TruncatedCreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmc6lfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReturnedDirectDebits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmc6mPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ReturnedDirectDebits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TruncatedChecks".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmmrkvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TruncatedChecks,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedCreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmmrlfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedCreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedDirectDebits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmmrmPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedDirectDebits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedReturnedCreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmmrm_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedReturnedCreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedReturnedDirectDebits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmmrnvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedReturnedDirectDebits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedTruncatedChecks".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmwckvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedTruncatedChecks,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RevokedTruncatedCreditTransfers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmwclfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RevokedTruncatedCreditTransfers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardClearing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmwcmPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CardClearing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonPreauthorisedDirectDebitDE".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tm5mgvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonPreauthorisedDirectDebitDE,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedDirectDebitDE".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tm5mhfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedDirectDebitDE,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImageBasedChequeCollection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tm5miPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ImageBasedChequeCollection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaperlessChequeCollection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tm5mi_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaperlessChequeCollection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessToBusinessDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tm5mjvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BusinessToBusinessDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessToCustomerDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnDXgvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BusinessToCustomerDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AncillarySystemTransferInitiation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnDXhfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AncillarySystemTransferInitiation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BackupPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnDXiPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BackupPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MandatedPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnDXi_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MandatedPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementBankTransferInitiation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnNIgvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SettlementBankTransferInitiation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedDirectDebitAccéléréAcceleratedClearing2DayOrdinaireNormalClearing4Day".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnNIhfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedDirectDebitAccéléréAcceleratedClearing2DayOrdinaireNormalClearing4Day,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedDirectDebitOrdinaireNormalClearing4Day".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnNIiPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedDirectDebitOrdinaireNormalClearing4Day,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedDirectDebitVérifiéVerifiedClearing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnNIi_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedDirectDebitVérifiéVerifiedClearing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RecoveredBillofExchangeorPromissoryNote".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnNIjvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RecoveredBillofExchangeorPromissoryNote,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonPreauthorisedDirectDebitRIBA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnW5gvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonPreauthorisedDirectDebitRIBA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedRevocableDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnW5hfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedRevocableDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreauthorisedRevocableUrgentDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tngDcvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreauthorisedRevocableUrgentDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentsViaInternetOwnedByCurrence".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tngDdfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentsViaInternetOwnedByCurrence,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstantCreditTransferNotTimeCritical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tngDePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InstantCreditTransferNotTimeCritical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstantCreditTransferTimeCritical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tngDe_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InstantCreditTransferTimeCritical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tngDfvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferNotTimeCritical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnp0cvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferNotTimeCritical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferTimeCritical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnp0dfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferTimeCritical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DutchDomesticBulkPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tnp0ePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DutchDomesticBulkPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DutchUrgentPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tny-YvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DutchUrgentPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentsViaStandaardDigitaleNota".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tny-ZfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentsViaStandaardDigitaleNota,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentViaAcceptgiroOwnedByCurrence".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tn8vYvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentViaAcceptgiroOwnedByCurrence,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncidentManagementCorrection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tn8vZfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    IncidentManagementCorrection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebitInitiatedByTheGovernmentWithSpecialConditions".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tn8vaPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebitInitiatedByTheGovernmentWithSpecialConditions,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MassPaymentBeneficiary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tn8va_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MassPaymentBeneficiary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MassPaymentOurs".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tn8vbvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MassPaymentOurs,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MassPaymentShared".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toF5UvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MassPaymentShared,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toF5VfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    StandingOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneOffAuthorisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toF5WPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OneOffAuthorisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneOffAuthorisationCharities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toF5W_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OneOffAuthorisationCharities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneOffAuthorisationConstructionIndustry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toPqUvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OneOffAuthorisationConstructionIndustry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneOffAuthorisationTuitionFees".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toPqVfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OneOffAuthorisationTuitionFees,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingAuthorisationCompanies".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toPqWPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    StandingAuthorisationCompanies,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingAuthorisationCompaniesWithoutDebtorRevocationRight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toZbUvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    StandingAuthorisationCompaniesWithoutDebtorRevocationRight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingAuthorisationGeneral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toZbVfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    StandingAuthorisationGeneral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingAuthorisationLotteries".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toilQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    StandingAuthorisationLotteries,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConvertedBankPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toilRfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ConvertedBankPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_toilSPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BusinessPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderCustomerCreditTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tosWQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CrossBorderCustomerCreditTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tosWRfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Overnight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentWithERI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tosWSPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PaymentWithERI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SameDayClearedPayments".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tosWS_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SameDayClearedPayments,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CoreNoRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tosWTvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CoreNoRefund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectDebitFixedAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to2HQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DirectDebitFixedAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPADirectDebitCore".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to2HRfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPADirectDebitCore,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPAB2BDirectDebitAMI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to_RMvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPAB2BDirectDebitAMI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPABusinessToBusinessDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to_RNfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPABusinessToBusinessDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPACoreD1DirectDebitAMI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to_ROPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPACoreD1DirectDebitAMI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPACoreDirectDebitAMI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to_RO_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPACoreDirectDebitAMI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPADirectDebit1DaySettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_to_RPvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPADirectDebit1DaySettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SEPAFADirectDebitAMI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpJCMvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SEPAFADirectDebitAMI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CLSClearedFXForEurex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpJCNfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CLSClearedFXForEurex,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CLSClearedFXForLCH".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpJCOPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CLSClearedFXForLCH,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstantCreditTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpJCO_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InstantCreditTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AuthenticatedDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpJCPvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AuthenticatedDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnauthenticatedDirectDebit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpSzMvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    UnauthenticatedDirectDebit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashConcentrationIntragroup".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpSzNfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CashConcentrationIntragroup,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpb9IvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BankTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CheckSameDaySettlementWire".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpb9JfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CheckSameDaySettlementWire,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpluIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CustomerTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerTransferPlus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpluJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CustomerTransferPlus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DepositToSendersAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpluKPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DepositToSendersAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FedFundsReturned".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpluK_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    FedFundsReturned,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FedFundsSold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpvfIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    FedFundsSold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonValueServiceMessage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpvfJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonValueServiceMessage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DrawdownResponseValueToHonorADrawdownRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpvfKPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DrawdownResponseValueToHonorADrawdownRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankToBankDrawdownRequestOrResponseNonvalue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpvfK_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BankToBankDrawdownRequestOrResponseNonvalue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerOrCorporateDrawdownRequestOrResponseNonvalue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tpvfLvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CustomerOrCorporateDrawdownRequestOrResponseNonvalue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternationalACH".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp4pEvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InternationalACH,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashConcentrationOrDisbursementCorporateCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp4pFfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CashConcentrationOrDisbursementCorporateCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateTradeExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp4pGPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CorporateTradeExchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrearrangedPaymentOrDepositConsumerCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp4pG_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PrearrangedPaymentOrDepositConsumerCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerInitiatedEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp4pHvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CustomerInitiatedEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepresentedCheckEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqCaEvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RepresentedCheckEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountsReceivableCheck".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqCaFfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AccountsReceivableCheck,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternetInitiatedEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqCaGPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InternetInitiatedEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PointOfPurchase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqLkAvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PointOfPurchase,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PointOfSale".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqLkBfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PointOfSale,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TelephoneInitiatedEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tqLkCPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TelephoneInitiatedEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstantCreditTransferPreferred".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_It7dAVEFEey6cYDbEubNXg")]
    [Description(@"??")]
    InstantCreditTransferPreferred,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditTransferPreferred".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_K0CN4VEFEey6cYDbEubNXg")]
    [Description(@"??")]
    CreditTransferPreferred,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultiDayPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yIC_seAnEey0k8vo1GQhqQ")]
    [Description(@"??")]
    MultiDayPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalLocalInstrument1CodeMetadataExtensions
{
    private static readonly ExternalLocalInstrument1CodeDropdownSource _dropdownSource = new ExternalLocalInstrument1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalLocalInstrument1CodeDropdownRow GetMetadata(this ExternalLocalInstrument1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


