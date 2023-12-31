﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountInformationType1Code.  ISO2002 ID# _I_zgUH6GEeSAlrUr1Vow5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I_zgUH6GEeSAlrUr1Vow5g")]
[Description(@"Specifies the type of account information.")]
[DerivedFrom(typeof(AccountInformationTypeCode))]
public enum AccountInformationType1Code
{
    /// <summary>
    /// Name of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IntermediaryBankNameOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "IBND")]
    [IsoId("_5uluIX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of intermediary bank for dealt currency.")]
    IntermediaryBankNameOfDealtCurrency,
    
    /// <summary>
    /// Number of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IntermediaryBankNumberOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "IBCC")]
    [IsoId("_50Dc8X6HEeSAlrUr1Vow5g")]
    [Description(@"Number of intermediary bank for contra currency.")]
    IntermediaryBankNumberOfContraCurrency,
    
    /// <summary>
    /// Number of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IntermediaryBankNumberOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "IBDC")]
    [IsoId("_55bsMX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of intermediary bank for dealt currency.")]
    IntermediaryBankNumberOfDealtCurrency,
    
    /// <summary>
    /// BIC code of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionBICCodeOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "BIBC")]
    [IsoId("_6MzUIX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionBICCodeOfContraCurrency,
    
    /// <summary>
    /// BIC code of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionBICCodeOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "BIBD")]
    [IsoId("_6SMxgX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Name of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionNameOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "BINC")]
    [IsoId("_6XsVgX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNameOfContraCurrency,
    
    /// <summary>
    /// Name of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionNameOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_6dCvkX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNameOfDealtCurrency,
    
    /// <summary>
    /// Number of beneficiary institution for contra currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionNumberOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "BICC")]
    [IsoId("_6ocHQX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of beneficiary institution for contra currency.")]
    BeneficiaryInstitutionNumberOfContraCurrency,
    
    /// <summary>
    /// Number of beneficiary institution for dealt currency.
    /// Encoded/decoded by serializers as "BeneficiaryInstitutionNumberOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "BIDC")]
    [IsoId("_6tx6QX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of beneficiary institution for dealt currency.")]
    BeneficiaryInstitutionNumberOfDealtCurrency,
    
    /// <summary>
    /// Margin settlement account number of CFETS.
    /// Encoded/decoded by serializers as "CFETSMarginSettlementAccountNumber".
    /// </summary>
    [EnumMember(Value = "CMSA")]
    [IsoId("_6zI7YX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of CFETS.")]
    CFETSMarginSettlementAccountNumber,
    
    /// <summary>
    /// BIC code of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CorrespondentBankBICCodeOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "CBBC")]
    [IsoId("_606dAX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of correspondent bank for contra currency.")]
    CorrespondentBankBICCodeOfContraCurrency,
    
    /// <summary>
    /// BIC code of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CorrespondentBankBICCodeOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "CBBD")]
    [IsoId("_66MloX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of correspondent bank for dealt currency.")]
    CorrespondentBankBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Name of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CorrespondentBankNameOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "CBNC")]
    [IsoId("_6_eHMX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of correspondent bank for contra currency.")]
    CorrespondentBankNameOfContraCurrency,
    
    /// <summary>
    /// Name of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CorrespondentBankNameOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "CBND")]
    [IsoId("_7BSsIX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of correspondent bank for dealt currency.")]
    CorrespondentBankNameOfDealtCurrency,
    
    /// <summary>
    /// Number of correspondent bank for contra currency.
    /// Encoded/decoded by serializers as "CorrespondentBankNumberOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "CBCC")]
    [IsoId("_7GofIX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of correspondent bank for contra currency.")]
    CorrespondentBankNumberOfContraCurrency,
    
    /// <summary>
    /// Number of correspondent bank for dealt currency.
    /// Encoded/decoded by serializers as "CorrespondentBankNumberOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "CBDC")]
    [IsoId("_7L6nwX6HEeSAlrUr1Vow5g")]
    [Description(@"Number of correspondent bank for dealt currency.")]
    CorrespondentBankNumberOfDealtCurrency,
    
    /// <summary>
    /// Specifies the current account.
    /// Encoded/decoded by serializers as "CurrentAccount".
    /// </summary>
    [EnumMember(Value = "CUAC")]
    [IsoId("_7Nq7QX6HEeSAlrUr1Vow5g")]
    [Description(@"Specifies the current account.")]
    CurrentAccount,
    
    /// <summary>
    /// Specifies the deposit account.
    /// Encoded/decoded by serializers as "DepositAccount".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_7S-SAX6HEeSAlrUr1Vow5g")]
    [Description(@"Specifies the deposit account.")]
    DepositAccount,
    
    /// <summary>
    /// Account name of fund custodian.
    /// Encoded/decoded by serializers as "FundCustodianAccountName".
    /// </summary>
    [EnumMember(Value = "FCAA")]
    [IsoId("_7YRBsX6HEeSAlrUr1Vow5g")]
    [Description(@"Account name of fund custodian.")]
    FundCustodianAccountName,
    
    /// <summary>
    /// Account number of fund custodian.
    /// Encoded/decoded by serializers as "FundCustodianAccountNumber".
    /// </summary>
    [EnumMember(Value = "FCAN")]
    [IsoId("_7hJQ4X6HEeSAlrUr1Vow5g")]
    [Description(@"Account number of fund custodian.")]
    FundCustodianAccountNumber,
    
    /// <summary>
    /// Name of fund custodian bank.
    /// Encoded/decoded by serializers as "FundCustodianBankName".
    /// </summary>
    [EnumMember(Value = "FCBN")]
    [IsoId("_7mbZgX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of fund custodian bank.")]
    FundCustodianBankName,
    
    /// <summary>
    /// BIC code of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IntermediaryBankBICCodeOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "IBBC")]
    [IsoId("_7rv-YX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of intermediary bank for contra currency.")]
    IntermediaryBankBICCodeOfContraCurrency,
    
    /// <summary>
    /// BIC code of intermediary bank for dealt currency.
    /// Encoded/decoded by serializers as "IntermediaryBankBICCodeOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "IBBD")]
    [IsoId("_7xCuEX6HEeSAlrUr1Vow5g")]
    [Description(@"BIC code of intermediary bank for dealt currency.")]
    IntermediaryBankBICCodeOfDealtCurrency,
    
    /// <summary>
    /// Name of intermediary bank for contra currency.
    /// Encoded/decoded by serializers as "IntermediaryBankNameOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "IBNC")]
    [IsoId("_72UPoX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of intermediary bank for contra currency.")]
    IntermediaryBankNameOfContraCurrency,
    
    /// <summary>
    /// Custodian account name of margin.
    /// Encoded/decoded by serializers as "MarginCustodianAccountName".
    /// </summary>
    [EnumMember(Value = "MCAA")]
    [IsoId("_8qp2oX6HEeSAlrUr1Vow5g")]
    [Description(@"Custodian account name of margin.")]
    MarginCustodianAccountName,
    
    /// <summary>
    /// Custodian account number of margin.
    /// Encoded/decoded by serializers as "MarginCustodianAccountNumber".
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_8wHlcX6HEeSAlrUr1Vow5g")]
    [Description(@"Custodian account number of margin.")]
    MarginCustodianAccountNumber,
    
    /// <summary>
    /// Code of margin custodian institution.
    /// Encoded/decoded by serializers as "MarginCustodianInstitutionCode".
    /// </summary>
    [EnumMember(Value = "MCIC")]
    [IsoId("_81o-oX6HEeSAlrUr1Vow5g")]
    [Description(@"Code of margin custodian institution.")]
    MarginCustodianInstitutionCode,
    
    /// <summary>
    /// Name of margin custodian institution.
    /// Encoded/decoded by serializers as "MarginCustodianInstitutionName".
    /// </summary>
    [EnumMember(Value = "MCIN")]
    [IsoId("_86__wX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of margin custodian institution.")]
    MarginCustodianInstitutionName,
    
    /// <summary>
    /// Settlement account name of margin.
    /// Encoded/decoded by serializers as "MarginSettlementAccountName".
    /// </summary>
    [EnumMember(Value = "MSAA")]
    [IsoId("_9AY2EX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement account name of margin.")]
    MarginSettlementAccountName,
    
    /// <summary>
    /// Settlement bank name of margin.
    /// Encoded/decoded by serializers as "MarginSettlementBankName".
    /// </summary>
    [EnumMember(Value = "MSBN")]
    [IsoId("_9COCEX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement bank name of margin.")]
    MarginSettlementBankName,
    
    /// <summary>
    /// Description of multi currency account.
    /// Encoded/decoded by serializers as "MultiCurrencyAccountDescription".
    /// </summary>
    [EnumMember(Value = "MCAD")]
    [IsoId("_9Hm4YX6HEeSAlrUr1Vow5g")]
    [Description(@"Description of multi currency account.")]
    MultiCurrencyAccountDescription,
    
    /// <summary>
    /// Note for dealt currency.
    /// Encoded/decoded by serializers as "NoteOfDealtCurrency".
    /// </summary>
    [EnumMember(Value = "NODC")]
    [IsoId("_9JXy8X6HEeSAlrUr1Vow5g")]
    [Description(@"Note for dealt currency.")]
    NoteOfDealtCurrency,
    
    /// <summary>
    /// Account chinese name of securities custodians.
    /// Encoded/decoded by serializers as "SecuritiesCustodianAccountChineseName".
    /// </summary>
    [EnumMember(Value = "SCAC")]
    [IsoId("_9OrJsX6HEeSAlrUr1Vow5g")]
    [Description(@"Account chinese name of securities custodians.")]
    SecuritiesCustodianAccountChineseName,
    
    /// <summary>
    /// Account name of securities custodians.
    /// Encoded/decoded by serializers as "SecuritiesCustodianAccountName".
    /// </summary>
    [EnumMember(Value = "SCAA")]
    [IsoId("_9Qa2IX6HEeSAlrUr1Vow5g")]
    [Description(@"Account name of securities custodians.")]
    SecuritiesCustodianAccountName,
    
    /// <summary>
    /// Margin settlement account number of other institutions.
    /// Encoded/decoded by serializers as "OtherMarginSettlementAccountNumber".
    /// </summary>
    [EnumMember(Value = "OMSA")]
    [IsoId("_9ZggsX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of other institutions.")]
    OtherMarginSettlementAccountNumber,
    
    /// <summary>
    /// Note for contra currency.
    /// Encoded/decoded by serializers as "NoteOfContraCurrency".
    /// </summary>
    [EnumMember(Value = "NOCC")]
    [IsoId("_9e1soX6HEeSAlrUr1Vow5g")]
    [Description(@"Note for contra currency.")]
    NoteOfContraCurrency,
    
    /// <summary>
    /// Settlement bank sort code of margin.
    /// Encoded/decoded by serializers as "MarginSettlementBankSortCode".
    /// </summary>
    [EnumMember(Value = "MSBS")]
    [IsoId("_9kJDYX6HEeSAlrUr1Vow5g")]
    [Description(@"Settlement bank sort code of margin.")]
    MarginSettlementBankSortCode,
    
    /// <summary>
    /// Margin settlement account number of CDC.
    /// Encoded/decoded by serializers as "MarginSettlementAccountNumber".
    /// </summary>
    [EnumMember(Value = "MSAN")]
    [IsoId("_9pbzEX6HEeSAlrUr1Vow5g")]
    [Description(@"Margin settlement account number of CDC.")]
    MarginSettlementAccountNumber,
    
    /// <summary>
    /// Account number of securities custodians.
    /// Encoded/decoded by serializers as "SecuritiesCustodianAccountNumber".
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_-K-Z4X6HEeSAlrUr1Vow5g")]
    [Description(@"Account number of securities custodians.")]
    SecuritiesCustodianAccountNumber,
    
    /// <summary>
    /// Code of securities custodian institution.
    /// Encoded/decoded by serializers as "SecuritiesCustodianInstitutionCode".
    /// </summary>
    [EnumMember(Value = "SCIC")]
    [IsoId("_-QS-wX6HEeSAlrUr1Vow5g")]
    [Description(@"Code of securities custodian institution.")]
    SecuritiesCustodianInstitutionCode,
    
    /// <summary>
    /// Name of securities custodian institution.
    /// Encoded/decoded by serializers as "SecuritiesCustodianInstitutionName".
    /// </summary>
    [EnumMember(Value = "SCIN")]
    [IsoId("_-VoKsX6HEeSAlrUr1Vow5g")]
    [Description(@"Name of securities custodian institution.")]
    SecuritiesCustodianInstitutionName,
    
    /// <summary>
    /// Status of cash account.
    /// Encoded/decoded by serializers as "StatusOfCashAccount".
    /// </summary>
    [EnumMember(Value = "SOCA")]
    [IsoId("_-a66YX6HEeSAlrUr1Vow5g")]
    [Description(@"Status of cash account.")]
    StatusOfCashAccount,
    
    /// <summary>
    /// Status of securities custodian account.
    /// Encoded/decoded by serializers as "StatusOfSecuritiesCustodianAccount".
    /// </summary>
    [EnumMember(Value = "SSCA")]
    [IsoId("_-gORIX6HEeSAlrUr1Vow5g")]
    [Description(@"Status of securities custodian account.")]
    StatusOfSecuritiesCustodianAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountInformationType1CodeMetadataExtensions
{
    private static readonly AccountInformationType1CodeDropdownSource _dropdownSource = new AccountInformationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountInformationType1CodeDropdownRow GetMetadata(this AccountInformationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


