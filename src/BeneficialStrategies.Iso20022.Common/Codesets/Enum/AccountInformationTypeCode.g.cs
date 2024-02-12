﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountInformationTypeCode.  ISO2002 ID# _2dtucEa8EeSm2psHh_KSCw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2dtucEa8EeSm2psHh_KSCw")]
[Description(@"Specifies the type of account information.")]
[Derivations(typeof(AccountInformationType1Code))]
public enum AccountInformationTypeCode
{
    /// <summary>
    /// Account number of securities custodians.
    /// Encoded/decoded by serializers as "SCAN".
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_GecKoEa-EeSm2psHh_KSCw")]
    [Description(@"Account number of securities custodians.")]
    SecuritiesCustodianAccountNumber,
    
    /// <summary>
    /// Account name of securities custodians.
    /// Encoded/decoded by serializers as "SCAA".
    /// </summary>
    [EnumMember(Value = "SCAA")]
    [IsoId("_GjtsMEa-EeSm2psHh_KSCw")]
    [Description(@"Account name of securities custodians.")]
    SecuritiesCustodianAccountName,
    
    /// <summary>
    /// Margin settlement account number of CDC.
    /// Encoded/decoded by serializers as "MSAN".
    /// </summary>
    [EnumMember(Value = "MSAN")]
    [IsoId("_GmGR0Ea-EeSm2psHh_KSCw")]
    [Description(@"Margin settlement account number of CDC.")]
    MarginSettlementAccountNumber,
    
    /// <summary>
    /// Custodian account number of margin.
    /// Encoded/decoded by serializers as "MCAN".
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_GoWUkEa-EeSm2psHh_KSCw")]
    [Description(@"Custodian account number of margin.")]
    MarginCustodianAccountNumber,
    
    /// <summary>
    /// Settlement bank name of margin.
    /// Encoded/decoded by serializers as "MSBN".
    /// </summary>
    [EnumMember(Value = "MSBN")]
    [IsoId("_GqtsEEa-EeSm2psHh_KSCw")]
    [Description(@"Settlement bank name of margin.")]
    MarginSettlementBankName,
    
    /// <summary>
    /// Name of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBNC".
    /// </summary>
    [EnumMember(Value = "IBNC")]
    [IsoId("_GtONgEa-EeSm2psHh_KSCw")]
    [Description(@"Name of intermediary bank for contra currency.")]
    IntermediaryBankNameOfContraCurrency,
    
    /// <summary>
    /// Name of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIND".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_GtPboEa-EeSm2psHh_KSCw")]
    [Description(@"Name of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNameOfDealtCurrency,
    
    /// <summary>
    /// BIC code of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBBC".
    /// </summary>
    [EnumMember(Value = "CBBC")]
    [IsoId("_GvgFcEa-EeSm2psHh_KSCw")]
    [Description(@"BIC code of correspondent bank for contra currency.")]
    CorrespondentBankBICCodeOfContraCurrency,
    
    /// <summary>
    /// BIC code of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIBD".
    /// </summary>
    [EnumMember(Value = "BIBD")]
    [IsoId("_GxTcQEa-EeSm2psHh_KSCw")]
    [Description(@"BIC code of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Name of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBNC".
    /// </summary>
    [EnumMember(Value = "CBNC")]
    [IsoId("_GzkGEEa-EeSm2psHh_KSCw")]
    [Description(@"Name of correspondent bank for contra currency.")]
    CorrespondentBankNameOfContraCurrency,
    
    /// <summary>
    /// Number of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BIDC".
    /// </summary>
    [EnumMember(Value = "BIDC")]
    [IsoId("_G1Xc4Ea-EeSm2psHh_KSCw")]
    [Description(@"Number of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNumberOfDealtCurrency,
    
    /// <summary>
    /// Number of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CBCC".
    /// </summary>
    [EnumMember(Value = "CBCC")]
    [IsoId("_G1y6sEa-EeSm2psHh_KSCw")]
    [Description(@"Number of correspondent bank for contra currency.")]
    CorrespondentBankNumberOfContraCurrency,
    
    /// <summary>
    /// Name of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBND".
    /// </summary>
    [EnumMember(Value = "CBND")]
    [IsoId("_G3sYIEa-EeSm2psHh_KSCw")]
    [Description(@"Name of correspondent bank for dealt currency.")]
    CorrespondentBankNameOfDealtCurrency,
    
    /// <summary>
    /// BIC code of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BIBC".
    /// </summary>
    [EnumMember(Value = "BIBC")]
    [IsoId("_G5hkIEa-EeSm2psHh_KSCw")]
    [Description(@"BIC code of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionBICCodeOfContraCurrency,
    
    /// <summary>
    /// BIC code of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBBD".
    /// </summary>
    [EnumMember(Value = "CBBD")]
    [IsoId("_G7vKoEa-EeSm2psHh_KSCw")]
    [Description(@"BIC code of correspondent bank for dealt currency.")]
    CorrespondentBankBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Name of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BINC".
    /// </summary>
    [EnumMember(Value = "BINC")]
    [IsoId("_G9nZ8Ea-EeSm2psHh_KSCw")]
    [Description(@"Name of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNameOfContraCurrency,
    
    /// <summary>
    /// Number of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CBDC".
    /// </summary>
    [EnumMember(Value = "CBDC")]
    [IsoId("_G_iFgEa-EeSm2psHh_KSCw")]
    [Description(@"Number of correspondent bank for dealt currency.")]
    CorrespondentBankNumberOfDealtCurrency,
    
    /// <summary>
    /// Number of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BICC".
    /// </summary>
    [EnumMember(Value = "BICC")]
    [IsoId("_HBwTEEa-EeSm2psHh_KSCw")]
    [Description(@"Number of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNumberOfContraCurrency,
    
    /// <summary>
    /// Name of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBND".
    /// </summary>
    [EnumMember(Value = "IBND")]
    [IsoId("_HDn7UEa-EeSm2psHh_KSCw")]
    [Description(@"Name of intermediary bank for dealt currency.")]
    IntermediaryBankNameOfDealtCurrency,
    
    /// <summary>
    /// Note for contra currency.
    /// Encoded/decoded by serializers as "NOCC".
    /// </summary>
    [EnumMember(Value = "NOCC")]
    [IsoId("_HFb5MEa-EeSm2psHh_KSCw")]
    [Description(@"Note for contra currency.")]
    NoteOfContraCurrency,
    
    /// <summary>
    /// BIC code of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBBD".
    /// </summary>
    [EnumMember(Value = "IBBD")]
    [IsoId("_HF3XAEa-EeSm2psHh_KSCw")]
    [Description(@"BIC code of intermediary bank for dealt currency.")]
    IntermediaryBankBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Number of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBCC".
    /// </summary>
    [EnumMember(Value = "IBCC")]
    [IsoId("_HJiWEEa-EeSm2psHh_KSCw")]
    [Description(@"Number of intermediary bank for contra currency.")]
    IntermediaryBankNumberOfContraCurrency,
    
    /// <summary>
    /// Number of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IBDC".
    /// </summary>
    [EnumMember(Value = "IBDC")]
    [IsoId("_HLW7AEa-EeSm2psHh_KSCw")]
    [Description(@"Number of intermediary bank for dealt currency.")]
    IntermediaryBankNumberOfDealtCurrency,
    
    /// <summary>
    /// Account chinese name of securities custodians.
    /// Encoded/decoded by serializers as "SCAC".
    /// </summary>
    [EnumMember(Value = "SCAC")]
    [IsoId("_HzIFoEa-EeSm2psHh_KSCw")]
    [Description(@"Account chinese name of securities custodians.")]
    SecuritiesCustodianAccountChineseName,
    
    /// <summary>
    /// Specifies the current account.
    /// Encoded/decoded by serializers as "CUAC".
    /// </summary>
    [EnumMember(Value = "CUAC")]
    [IsoId("_H1h5YEa-EeSm2psHh_KSCw")]
    [Description(@"Specifies the current account.")]
    CurrentAccount,
    
    /// <summary>
    /// Specifies the deposit account.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_H33bsEa-EeSm2psHh_KSCw")]
    [Description(@"Specifies the deposit account.")]
    DepositAccount,
    
    /// <summary>
    /// Description of multi currency account.
    /// Encoded/decoded by serializers as "MCAD".
    /// </summary>
    [EnumMember(Value = "MCAD")]
    [IsoId("_H4S5gEa-EeSm2psHh_KSCw")]
    [Description(@"Description of multi currency account.")]
    MultiCurrencyAccountDescription,
    
    /// <summary>
    /// Margin settlement account number of other institutions.
    /// Encoded/decoded by serializers as "OMSA".
    /// </summary>
    [EnumMember(Value = "OMSA")]
    [IsoId("_H6YkMEa-EeSm2psHh_KSCw")]
    [Description(@"Margin settlement account number of other institutions.")]
    OtherMarginSettlementAccountNumber,
    
    /// <summary>
    /// Margin settlement account number of CFETS.
    /// Encoded/decoded by serializers as "CMSA".
    /// </summary>
    [EnumMember(Value = "CMSA")]
    [IsoId("_H8mxwEa-EeSm2psHh_KSCw")]
    [Description(@"Margin settlement account number of CFETS.")]
    CFETSMarginSettlementAccountNumber,
    
    /// <summary>
    /// Code of securities custodian institution.
    /// Encoded/decoded by serializers as "SCIC".
    /// </summary>
    [EnumMember(Value = "SCIC")]
    [IsoId("_H-bWsEa-EeSm2psHh_KSCw")]
    [Description(@"Code of securities custodian institution.")]
    SecuritiesCustodianInstitutionCode,
    
    /// <summary>
    /// Code of margin custodian institution.
    /// Encoded/decoded by serializers as "MCIC".
    /// </summary>
    [EnumMember(Value = "MCIC")]
    [IsoId("_H-20gEa-EeSm2psHh_KSCw")]
    [Description(@"Code of margin custodian institution.")]
    MarginCustodianInstitutionCode,
    
    /// <summary>
    /// Settlement bank sort code of margin.
    /// Encoded/decoded by serializers as "MSBS".
    /// </summary>
    [EnumMember(Value = "MSBS")]
    [IsoId("_IArZcEa-EeSm2psHh_KSCw")]
    [Description(@"Settlement bank sort code of margin.")]
    MarginSettlementBankSortCode,
    
    /// <summary>
    /// Status of cash account.
    /// Encoded/decoded by serializers as "SOCA".
    /// </summary>
    [EnumMember(Value = "SOCA")]
    [IsoId("_IChMgEa-EeSm2psHh_KSCw")]
    [Description(@"Status of cash account.")]
    StatusOfCashAccount,
    
    /// <summary>
    /// Status of securities custodian account.
    /// Encoded/decoded by serializers as "SSCA".
    /// </summary>
    [EnumMember(Value = "SSCA")]
    [IsoId("_IExPQEa-EeSm2psHh_KSCw")]
    [Description(@"Status of securities custodian account.")]
    StatusOfSecuritiesCustodianAccount,
    
    /// <summary>
    /// Custodian account name of margin.
    /// Encoded/decoded by serializers as "MCAA".
    /// </summary>
    [EnumMember(Value = "MCAA")]
    [IsoId("_IGkmEEa-EeSm2psHh_KSCw")]
    [Description(@"Custodian account name of margin.")]
    MarginCustodianAccountName,
    
    /// <summary>
    /// Settlement account name of margin.
    /// Encoded/decoded by serializers as "MSAA".
    /// </summary>
    [EnumMember(Value = "MSAA")]
    [IsoId("_IIZyEEa-EeSm2psHh_KSCw")]
    [Description(@"Settlement account name of margin.")]
    MarginSettlementAccountName,
    
    /// <summary>
    /// Account name of fund custodian.
    /// Encoded/decoded by serializers as "FCAA".
    /// </summary>
    [EnumMember(Value = "FCAA")]
    [IsoId("_IKn_oEa-EeSm2psHh_KSCw")]
    [Description(@"Account name of fund custodian.")]
    FundCustodianAccountName,
    
    /// <summary>
    /// Account number of fund custodian.
    /// Encoded/decoded by serializers as "FCAN".
    /// </summary>
    [EnumMember(Value = "FCAN")]
    [IsoId("_IKpNwEa-EeSm2psHh_KSCw")]
    [Description(@"Account number of fund custodian.")]
    FundCustodianAccountNumber,
    
    /// <summary>
    /// Name of fund custodian bank.
    /// Encoded/decoded by serializers as "FCBN".
    /// </summary>
    [EnumMember(Value = "FCBN")]
    [IsoId("_IMirMEa-EeSm2psHh_KSCw")]
    [Description(@"Name of fund custodian bank.")]
    FundCustodianBankName,
    
    /// <summary>
    /// Name of securities custodian institution.
    /// Encoded/decoded by serializers as "SCIN".
    /// </summary>
    [EnumMember(Value = "SCIN")]
    [IsoId("_IOZsYEa-EeSm2psHh_KSCw")]
    [Description(@"Name of securities custodian institution.")]
    SecuritiesCustodianInstitutionName,
    
    /// <summary>
    /// Name of margin custodian institution.
    /// Encoded/decoded by serializers as "MCIN".
    /// </summary>
    [EnumMember(Value = "MCIN")]
    [IsoId("_IQnS4Ea-EeSm2psHh_KSCw")]
    [Description(@"Name of margin custodian institution.")]
    MarginCustodianInstitutionName,
    
    /// <summary>
    /// Note for dealt currency.
    /// Encoded/decoded by serializers as "NODC".
    /// </summary>
    [EnumMember(Value = "NODC")]
    [IsoId("_hvOIUEbLEeSm2psHh_KSCw")]
    [Description(@"Note for dealt currency.")]
    NoteOfDealtCurrency,
    
    /// <summary>
    /// BIC code of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IBBC".
    /// </summary>
    [EnumMember(Value = "IBBC")]
    [IsoId("_VpQmoEbMEeSm2psHh_KSCw")]
    [Description(@"BIC code of intermediary bank for contra currency.")]
    IntermediaryBankBICCodeOfContraCurrency,
    
}
